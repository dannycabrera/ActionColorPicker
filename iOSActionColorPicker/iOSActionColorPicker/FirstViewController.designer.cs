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
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		ActionComponents.ACColorWell colorWell { get; set; }

		[Action ("SelectColor:")]
		partial void SelectColor (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (colorWell != null) {
				colorWell.Dispose ();
				colorWell = null;
			}
		}
	}
}
