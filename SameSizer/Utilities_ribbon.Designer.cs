namespace SameSizer
{
    partial class Utilities_ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Utilities_ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUtilities = this.Factory.CreateRibbonTab();
            this.groupSize = this.Factory.CreateRibbonGroup();
            this.groupAlign = this.Factory.CreateRibbonGroup();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.groupLayers = this.Factory.CreateRibbonGroup();
            this.ckLayer1 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer2 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer3 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer4 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer5 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer6 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer7 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer8 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer9 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer10 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer11 = this.Factory.CreateRibbonCheckBox();
            this.ckLayer12 = this.Factory.CreateRibbonCheckBox();
            this.btnSizerHeight = this.Factory.CreateRibbonButton();
            this.btnSizerWidth = this.Factory.CreateRibbonButton();
            this.btnSizerFull = this.Factory.CreateRibbonButton();
            this.btnAlignTop = this.Factory.CreateRibbonButton();
            this.btnAlignMiddle = this.Factory.CreateRibbonButton();
            this.btnAlignBottom = this.Factory.CreateRibbonButton();
            this.btnAlignLeft = this.Factory.CreateRibbonButton();
            this.btnAlignCenter = this.Factory.CreateRibbonButton();
            this.btnAlignRight = this.Factory.CreateRibbonButton();
            this.tabUtilities.SuspendLayout();
            this.groupSize.SuspendLayout();
            this.groupAlign.SuspendLayout();
            this.groupLayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUtilities
            // 
            this.tabUtilities.Groups.Add(this.groupSize);
            this.tabUtilities.Groups.Add(this.groupAlign);
            this.tabUtilities.Groups.Add(this.groupLayers);
            this.tabUtilities.Label = "Utilities";
            this.tabUtilities.Name = "tabUtilities";
            // 
            // groupSize
            // 
            this.groupSize.Items.Add(this.btnSizerHeight);
            this.groupSize.Items.Add(this.btnSizerWidth);
            this.groupSize.Items.Add(this.btnSizerFull);
            this.groupSize.Label = "Sizer";
            this.groupSize.Name = "groupSize";
            // 
            // groupAlign
            // 
            this.groupAlign.Items.Add(this.btnAlignTop);
            this.groupAlign.Items.Add(this.btnAlignMiddle);
            this.groupAlign.Items.Add(this.btnAlignBottom);
            this.groupAlign.Items.Add(this.separator1);
            this.groupAlign.Items.Add(this.btnAlignLeft);
            this.groupAlign.Items.Add(this.btnAlignCenter);
            this.groupAlign.Items.Add(this.btnAlignRight);
            this.groupAlign.Label = "Aligner";
            this.groupAlign.Name = "groupAlign";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // groupLayers
            // 
            this.groupLayers.Items.Add(this.ckLayer1);
            this.groupLayers.Items.Add(this.ckLayer2);
            this.groupLayers.Items.Add(this.ckLayer3);
            this.groupLayers.Items.Add(this.ckLayer4);
            this.groupLayers.Items.Add(this.ckLayer5);
            this.groupLayers.Items.Add(this.ckLayer6);
            this.groupLayers.Items.Add(this.ckLayer7);
            this.groupLayers.Items.Add(this.ckLayer8);
            this.groupLayers.Items.Add(this.ckLayer9);
            this.groupLayers.Items.Add(this.ckLayer10);
            this.groupLayers.Items.Add(this.ckLayer11);
            this.groupLayers.Items.Add(this.ckLayer12);
            this.groupLayers.Label = "Visible Layers";
            this.groupLayers.Name = "groupLayers";
            // 
            // ckLayer1
            // 
            this.ckLayer1.Label = "Layer #1";
            this.ckLayer1.Name = "ckLayer1";
            // 
            // ckLayer2
            // 
            this.ckLayer2.Label = "Layer #2";
            this.ckLayer2.Name = "ckLayer2";
            // 
            // ckLayer3
            // 
            this.ckLayer3.Label = "Layer #3";
            this.ckLayer3.Name = "ckLayer3";
            // 
            // ckLayer4
            // 
            this.ckLayer4.Label = "Layer #4";
            this.ckLayer4.Name = "ckLayer4";
            // 
            // ckLayer5
            // 
            this.ckLayer5.Label = "Layer #5";
            this.ckLayer5.Name = "ckLayer5";
            // 
            // ckLayer6
            // 
            this.ckLayer6.Label = "Layer #6";
            this.ckLayer6.Name = "ckLayer6";
            // 
            // ckLayer7
            // 
            this.ckLayer7.Label = "Layer #7";
            this.ckLayer7.Name = "ckLayer7";
            // 
            // ckLayer8
            // 
            this.ckLayer8.Label = "Layer #8";
            this.ckLayer8.Name = "ckLayer8";
            // 
            // ckLayer9
            // 
            this.ckLayer9.Label = "Layer #9";
            this.ckLayer9.Name = "ckLayer9";
            // 
            // ckLayer10
            // 
            this.ckLayer10.Label = "Layer #10";
            this.ckLayer10.Name = "ckLayer10";
            // 
            // ckLayer11
            // 
            this.ckLayer11.Label = "Layer #11";
            this.ckLayer11.Name = "ckLayer11";
            // 
            // ckLayer12
            // 
            this.ckLayer12.Label = "Layer #12";
            this.ckLayer12.Name = "ckLayer12";
            // 
            // btnSizerHeight
            // 
            this.btnSizerHeight.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSizerHeight.Description = "Resize all selected items to the same height as the primary selection.";
            this.btnSizerHeight.Enabled = false;
            this.btnSizerHeight.Image = global::SameSizer.Properties.Resources.resize_height;
            this.btnSizerHeight.Label = "Resize Height";
            this.btnSizerHeight.Name = "btnSizerHeight";
            this.btnSizerHeight.ScreenTip = "Resize all selected items to the same height as the primary selection.";
            this.btnSizerHeight.ShowImage = true;
            this.btnSizerHeight.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSizerHeight_Click);
            // 
            // btnSizerWidth
            // 
            this.btnSizerWidth.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSizerWidth.Description = "Resize all selected items to the same width as the primary selection.";
            this.btnSizerWidth.Enabled = false;
            this.btnSizerWidth.Image = global::SameSizer.Properties.Resources.resize_width;
            this.btnSizerWidth.Label = "Resize Width";
            this.btnSizerWidth.Name = "btnSizerWidth";
            this.btnSizerWidth.ScreenTip = "Resize all selected items to the same width as the primary selection.";
            this.btnSizerWidth.ShowImage = true;
            this.btnSizerWidth.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSizerWidth_Click);
            // 
            // btnSizerFull
            // 
            this.btnSizerFull.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSizerFull.Description = "Resize all selected items to the same size as the primary selection.";
            this.btnSizerFull.Enabled = false;
            this.btnSizerFull.Image = global::SameSizer.Properties.Resources.resize_all;
            this.btnSizerFull.Label = "Resize All";
            this.btnSizerFull.Name = "btnSizerFull";
            this.btnSizerFull.ScreenTip = "Resize all selected items to the same size as the primary selection.";
            this.btnSizerFull.ShowImage = true;
            this.btnSizerFull.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSizerFull_Click);
            // 
            // btnAlignTop
            // 
            this.btnAlignTop.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAlignTop.Description = "Align all selected items to the top edge of the primary selection.";
            this.btnAlignTop.Enabled = false;
            this.btnAlignTop.Image = global::SameSizer.Properties.Resources.align_top;
            this.btnAlignTop.Label = "Align Top";
            this.btnAlignTop.Name = "btnAlignTop";
            this.btnAlignTop.ScreenTip = "Align all selected items to the top edge of the primary selection.";
            this.btnAlignTop.ShowImage = true;
            this.btnAlignTop.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAlignTop_Click);
            // 
            // btnAlignMiddle
            // 
            this.btnAlignMiddle.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAlignMiddle.Description = "Align all selected items to the middle of the primary selection.";
            this.btnAlignMiddle.Enabled = false;
            this.btnAlignMiddle.Image = global::SameSizer.Properties.Resources.align_middle;
            this.btnAlignMiddle.Label = "Align Middle";
            this.btnAlignMiddle.Name = "btnAlignMiddle";
            this.btnAlignMiddle.ScreenTip = "Align all selected items to the middle of the primary selection.";
            this.btnAlignMiddle.ShowImage = true;
            this.btnAlignMiddle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAlignMiddle_Click);
            // 
            // btnAlignBottom
            // 
            this.btnAlignBottom.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAlignBottom.Description = "Align all selected items to the bottom edge of the primary selection.";
            this.btnAlignBottom.Enabled = false;
            this.btnAlignBottom.Image = global::SameSizer.Properties.Resources.align_bottom;
            this.btnAlignBottom.Label = "Align Bottom";
            this.btnAlignBottom.Name = "btnAlignBottom";
            this.btnAlignBottom.ScreenTip = "Align all selected items to the bottom edge of the primary selection.";
            this.btnAlignBottom.ShowImage = true;
            this.btnAlignBottom.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAlignBottom_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAlignLeft.Description = "Align all selected items to the left edge of the primary selection.";
            this.btnAlignLeft.Enabled = false;
            this.btnAlignLeft.Image = global::SameSizer.Properties.Resources.align_left;
            this.btnAlignLeft.Label = "Align Left";
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.ScreenTip = "Align all selected items to the left edge of the primary selection.";
            this.btnAlignLeft.ShowImage = true;
            this.btnAlignLeft.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAlignLeft_Click);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAlignCenter.Description = "Align all selected items to the center of the primary selection.";
            this.btnAlignCenter.Enabled = false;
            this.btnAlignCenter.Image = global::SameSizer.Properties.Resources.align_center;
            this.btnAlignCenter.Label = "Align Center";
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.ScreenTip = "Align all selected items to the center of the primary selection.";
            this.btnAlignCenter.ShowImage = true;
            this.btnAlignCenter.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAlignCenter_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAlignRight.Description = "Align all selected items to the right edge of the primary selection.";
            this.btnAlignRight.Enabled = false;
            this.btnAlignRight.Image = global::SameSizer.Properties.Resources.align_right;
            this.btnAlignRight.Label = "Align Right";
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.ScreenTip = "Align all selected items to the right edge of the primary selection.";
            this.btnAlignRight.ShowImage = true;
            this.btnAlignRight.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAlignRight_Click);
            // 
            // Utilities_ribbon
            // 
            this.Name = "Utilities_ribbon";
            this.RibbonType = "Microsoft.Visio.Drawing";
            this.Tabs.Add(this.tabUtilities);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Utilities_ribbon_Load);
            this.tabUtilities.ResumeLayout(false);
            this.tabUtilities.PerformLayout();
            this.groupSize.ResumeLayout(false);
            this.groupSize.PerformLayout();
            this.groupAlign.ResumeLayout(false);
            this.groupAlign.PerformLayout();
            this.groupLayers.ResumeLayout(false);
            this.groupLayers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Office.Tools.Ribbon.RibbonTab tabUtilities;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSize;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSizerFull;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSizerHeight;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSizerWidth;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupAlign;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAlignTop;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAlignMiddle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAlignBottom;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAlignLeft;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAlignCenter;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAlignRight;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupLayers;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer2;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer3;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer4;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer5;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer6;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer7;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer8;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer9;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer10;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer11;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckLayer12;
        //internal ckTriState ckAssgLayer1;
    }

    partial class ThisRibbonCollection
    {
        internal Utilities_ribbon Utilities_ribbon
        {
            get { return this.GetRibbon<Utilities_ribbon>(); }
        }
    }
}
