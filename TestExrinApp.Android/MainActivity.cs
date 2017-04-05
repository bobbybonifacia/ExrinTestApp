using System;

using Android.App;
using Android.Bluetooth;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Exrin.Framework;
using Xamarin.Forms;

namespace TestExrinApp.Droid
{
	[Activity(Label = "TestExrinApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			Exrin.Framework.App.Init(new PlatformOptions() { Platform = Device.OS.ToString() });
			LoadApplication(new App());
		}
	}
}

