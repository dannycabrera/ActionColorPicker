using System;
using UIKit;
using ActionComponents;

namespace iOSActionColorPicker
{
	public partial class FirstViewController : UIViewController
	{
		protected FirstViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void SelectColor(Foundation.NSObject sender) {
			// Create picker
			var picker = new ACColorPickerViewController();
			picker.Title = "Select a Pretty Color";
			picker.Color = colorWell.Color;

			// Wireup events
			picker.SelectionFinished += (color) => {
				DismissViewController(true, null);
				colorWell.Color = color;
			};

			// Display
			PresentViewController(picker, true, null);
		}
	}
}
