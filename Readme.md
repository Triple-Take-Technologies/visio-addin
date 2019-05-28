# Visio Utilities AddIn

Triple Take Technologies was founded by a couple of Solutions Architects.  We spend a lot of time in [Visio](https://products.office.com/en-us/visio/flowchart-software).  Like, a lot.  We wrote this addin to Visio to help streamline our use of it.

This addin surfaces 3 main feature groups.

- The ability to resize objects to the same width, height, or both.
- The ability to align objects to the same top, bottom, left, right, or middle (horizontal and vertical!).
- Easier access to show/hide various layers of objects.  This is basically the same functionality that Visio already provides, just fewer clicks to access.

## Building the AddIn
Clone the repo, open in Visual Studio 2017 (2019 probably works as well, but we haven't tried it), and build.  **Note that you may need to install support for building Office applications as such support is not a mandatory part of the Visual Studio installation.**  Once the addin is built, it should automatically be registered with Visio - just launch Visio and look for the new "Utilities" tab once you have a drawing open.

## Installing the AddIn Without Building
Just looking to use the addin?  Look for an installer on our [Releases](https://github.com/Triple-Take-Technologies/visio-addin/releases) page.

## Using the AddIn

### Resizing and Aligning
Once installed, the addin will create a new tab in the Visio Ribbon toolbar named "Utilities".  The first 3 items will be in a group named "Sizer".  The next 6 will be in a group named "Aligner".  All 9 if these items will be grayed out until you have at least 2 objects selected in your Visio diagram.

After you select at least 2 objects in your Visio diagram, one of those items will be the "primary" object.  Visio will showcase this with a heavier outline than the other objects.  The 9 toolbar items will then be enabled, and will operate using this primary object as its reference point.  In other words, if you click "Resize Height", all currently selected objects will be resized to be the same height as the primary object.

### Layers
If your Visio diagram has at least 1 layer defined, you'll see one checkbox appear in the Ribbon for each layer, up to a maximum of 12 (see Limitations, below).  If the layer is visible, the checkbox will be checked.  If the layer is invisible, the checkbox will be unchecked.  Toggle those checkboxes to change the visibility of the layers.

## Known Limitations
- Currently, there is a hard limit of 12 supported layers.  If your diagram has more than 12 layers, the addin layer functionality may not work as expected.

___
Disclaimer:  this project is not in any way associated with Microsoft!

(c) 2019 Triple Take Technologies
