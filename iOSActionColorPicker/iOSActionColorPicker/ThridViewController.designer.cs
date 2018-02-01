// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace iOSActionColorPicker
{
	[Register ("ThridViewController")]
	partial class ThridViewController
	{
		[Outlet]
		ActionComponents.ACColorCube colorCube { get; set; }

		[Outlet]
		ActionComponents.ACColorWell colorWell { get; set; }

		[Outlet]
		ActionComponents.ACHueBar hueBar { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (colorCube != null) {
				colorCube.Dispose ();
				colorCube = null;
			}

			if (hueBar != null) {
				hueBar.Dispose ();
				hueBar = null;
			}

			if (colorWell != null) {
				colorWell.Dispose ();
				colorWell = null;
			}
		}
	}
}
