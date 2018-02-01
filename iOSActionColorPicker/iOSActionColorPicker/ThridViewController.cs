using System;
using Foundation;
using UIKit;
using ActionComponents;

namespace iOSActionColorPicker
{
	public partial class ThridViewController : UIViewController
	{
		public ThridViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Wireup the color bar
			hueBar.HueChanged += (hue) => {
				// Set new cube hue
				colorCube.Hue = hue;
				Console.WriteLine(hue);
			};

			// Wireup color cube
			colorCube.ColorChanged += (color) => {
				colorWell.Color = color;
			};
		}
	}
}
