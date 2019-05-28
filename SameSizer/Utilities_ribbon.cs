/*
Copyright 2019 Triple Take Technologies

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial 
portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Visio = Microsoft.Office.Interop.Visio;

namespace SameSizer
{
    public partial class Utilities_ribbon
    {
        Visio.Application vApp;


        private void Utilities_ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            // Grab a reference to the currently running application instance
            vApp = Globals.ThisAddIn.Application;

            // Define the event handler for whenever the selection changes
            vApp.SelectionChanged += vApp_SelectionChanged;

            // Define the event handlers for the layers functionality
            vApp.DocumentCreated += vApp_DocumentCreated;
            vApp.DocumentOpened += vApp_DocumentOpened;
            vApp.BeforeDocumentClose += vApp_BeforeDocumentClose;
            vApp.WindowTurnedToPage += vApp_WindowTurnedToPage;
            vApp_WindowTurnedToPage(vApp.ActiveWindow);
            vApp.CellChanged += vApp_CellChanged; // This is used to help track when a layer gets added or removed
        }

        #region "Layers Code"

        private int LAYERS_LAST_KNOWN_COUNT = 0;
        private const int MAX_SUPPORTED_LAYERS = 12;

        void vApp_CellChanged(Visio.Cell Cell)
        {
            if (vApp.ActivePage.Layers.Count != LAYERS_LAST_KNOWN_COUNT)
            {
//                System.Diagnostics.Debug.WriteLine("Previous {0} : Current {1}", LAYERS_LAST_KNOWN_COUNT, vApp.ActivePage.Layers.Count);
                LAYERS_LAST_KNOWN_COUNT = vApp.ActivePage.Layers.Count;
                vApp_WindowTurnedToPage(vApp.ActiveWindow);
            }
        }

        void vApp_BeforeDocumentClose(Visio.Document Doc)
        {
            RibbonCheckBox[] ckAll = GetAllLayerCKs();
            for (int i = 0; i < MAX_SUPPORTED_LAYERS; i++) ckAll[i].Visible = false;
        }

        void vApp_DocumentOpened(Visio.Document Doc)
        {
            vApp_WindowTurnedToPage(vApp.ActiveWindow);
        }
        private RibbonCheckBox[] GetAllLayerCKs()
        {

            RibbonCheckBox[] arrCK = {
                                         this.ckLayer1, this.ckLayer2, this.ckLayer3, 
                                         this.ckLayer4, this.ckLayer5, this.ckLayer6,
                                         this.ckLayer7, this.ckLayer8, this.ckLayer9,
                                         this.ckLayer10, this.ckLayer11, this.ckLayer12
                                     };
            return arrCK;
        }

        void vApp_WindowTurnedToPage(Visio.Window Window)
        {
            Visio.Page Page = null;

            int i = 0;
            RibbonCheckBox ck = null;


            RibbonCheckBox[] ckAll = GetAllLayerCKs();
            for (i = 0; i < MAX_SUPPORTED_LAYERS; i++) ckAll[i].Visible = false;

            if (Window != null)
            {
                Page = Window.Page;
                if (Page != null)
                {
                    i = 0;
                    foreach (Visio.Layer lay in Page.Layers)
                    {
                        if (i < MAX_SUPPORTED_LAYERS)
                        {
                            ck = ckAll[i];
                            this.groupLayers.SuspendLayout();
                            ck.Click += ck_Click;
                            ck.Tag = lay;
                            ck.Checked = lay.CellsC[4].ResultIU == 1 ? true : false;
                            ck.Label = lay.Name;
                            ck.Visible = true;
                            this.groupLayers.ResumeLayout();
                        }
                        i++;
                    }


                    LAYERS_LAST_KNOWN_COUNT = Page.Layers.Count;

                
                }
            }
        }

        void ck_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonCheckBox ck = (RibbonCheckBox)sender;
            Visio.Layer lay = (Visio.Layer)ck.Tag;
            lay.CellsC[4].Formula = ck.Checked ? "1" : "0";
        }

        void vApp_DocumentCreated(Visio.Document Doc)
        {
            vApp_WindowTurnedToPage(vApp.ActiveWindow);
        }

        void vApp_SelectionChanged(Microsoft.Office.Interop.Visio.Window Window)
        {
            // Enable the buttons whenever 2 or more objects are selected.
            btnSizerHeight.Enabled = btnSizerWidth.Enabled = btnSizerFull.Enabled = 
                btnAlignTop.Enabled = btnAlignMiddle.Enabled = btnAlignBottom.Enabled = 
                btnAlignLeft.Enabled = btnAlignCenter.Enabled = btnAlignRight.Enabled = 
                (vApp.ActiveWindow.Selection.Count > 1);
        }

        #endregion

        #region "Resizer Code"

        private void btnSizerFull_Click(object sender, RibbonControlEventArgs e)
        {
            ReSize(true, true);
        }

        private void btnSizerHeight_Click(object sender, RibbonControlEventArgs e)
        {
            ReSize(true, false);
        }

        private void btnSizerWidth_Click(object sender, RibbonControlEventArgs e)
        {
            ReSize(false, true);
        }

        /// <summary>
        /// ReSize - resize all selected objects to the same height and/or width of the primary selection
        /// </summary>
        /// <param name="Height">Boolean.  If true, resize all objects to be the same height.</param>
        /// <param name="Width">Boolean.  If true, resize all objects to be the same width.</param>
        private void ReSize(bool Height, bool Width)
        {
            // Grab a reference to the current active window
            Visio.Window aw = vApp.ActiveWindow;

            // Iterate over each selected shape
            foreach (Visio.Shape x in aw.Selection)
            {
                // Only bother resizing items other than the PrimaryItem
                if (x != aw.Selection.PrimaryItem)
                {
                    // Only resize the width if Width is true.
                    // Additionaly, only resize if the widths currently differ.
                    // This way, Ctrl-Z becomes a little more friendly (without this
                    // extra check, the resize to the same width would cause Ctrl-Z
                    // to appear to have no effect, requiring Ctrl-Z to be pressed
                    // an additional time.
                    if (Width && x.Cells["Width"].ResultIU != aw.Selection.PrimaryItem.Cells["Width"].ResultIU) x.Cells["Width"].ResultIU = aw.Selection.PrimaryItem.Cells["Width"].ResultIU;

                    // Same thing for Height.
                    if (Height && x.Cells["Height"].ResultIU != aw.Selection.PrimaryItem.Cells["Height"].ResultIU) x.Cells["Height"].ResultIU = aw.Selection.PrimaryItem.Cells["Height"].ResultIU;
                }
            }
        }

        #endregion

        #region "Aligner Code"

        private void btnAlignTop_Click(object sender, RibbonControlEventArgs e)
        {
            Align(Visio.VisHorizontalAlignTypes.visHorzAlignNone, Visio.VisVerticalAlignTypes.visVertAlignTop);
        }

        private void btnAlignMiddle_Click(object sender, RibbonControlEventArgs e)
        {
            Align(Visio.VisHorizontalAlignTypes.visHorzAlignNone, Visio.VisVerticalAlignTypes.visVertAlignMiddle);
        }

        private void btnAlignBottom_Click(object sender, RibbonControlEventArgs e)
        {
            Align(Visio.VisHorizontalAlignTypes.visHorzAlignNone, Visio.VisVerticalAlignTypes.visVertAlignBottom);
        }

        private void btnAlignLeft_Click(object sender, RibbonControlEventArgs e)
        {
            Align(Visio.VisHorizontalAlignTypes.visHorzAlignLeft, Visio.VisVerticalAlignTypes.visVertAlignNone);
        }

        private void btnAlignCenter_Click(object sender, RibbonControlEventArgs e)
        {
            Align(Visio.VisHorizontalAlignTypes.visHorzAlignCenter, Visio.VisVerticalAlignTypes.visVertAlignNone);
        }

        private void btnAlignRight_Click(object sender, RibbonControlEventArgs e)
        {
            Align(Visio.VisHorizontalAlignTypes.visHorzAlignRight, Visio.VisVerticalAlignTypes.visVertAlignNone);
        }


        /// <summary>
        /// Align - aligns all selected objects to the same top/middle/bottom and/or left/center/right
        /// </summary>
        /// <param name="Horizontal">VisHorizontalAlignTypes indicating left/center/right</param>
        /// <param name="Vertical">VisVerticalAlignTypes indicating top/middle/bottom</param>
        private void Align(Visio.VisHorizontalAlignTypes Horizontal, Visio.VisVerticalAlignTypes Vertical)
        {
            // Grab a reference to the current active window
            Visio.Window aw = vApp.ActiveWindow;

            // Use built-in Align function
            aw.Selection.Align(Horizontal, Vertical, false);
        }

        #endregion




    }
}
