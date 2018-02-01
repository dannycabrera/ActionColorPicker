﻿using Android.App;
using Android.Widget;
using Android.OS;
using ActionComponents;

namespace AndroidActionColorPicker
{
	[Activity(Label = "AndroidActionColorPicker", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Testing
			var hueBar = FindViewById<ACHueBar>(Resource.Id.hueBar);
			var colorCube = FindViewById<ACColorCube>(Resource.Id.colorCube);
			var colorWell = FindViewById<ACColorWell>(Resource.Id.colorWell);

			// Wireup the color bar
			hueBar.HueChanged += (hue) => {
				// Set new cube hue
				colorCube.Hue = hue;
			};

			// Wireup color cube
			colorCube.ColorChanged += (color) => {
				colorWell.CurrentColor = color;
			};
		}
	}
}

