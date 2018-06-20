using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace ImmunoApp.Droid
{
    [Activity(Label = "ImmunoApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //Create and add Toolbar and Tab Layout
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            //Init the UserDialogs Instance
            UserDialogs.Init(this);
            //UserDialogs.Init(() => (Activity)Forms.Context);

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            if (UserDialogs.Instance == null)
            {
                Console.WriteLine("Instance of UserDialogs is null");
            }
        }


        /// <summary>
        /// Needs to be implemented: If user is authenticated, just call the resume of the App
        /// </summary>
        protected override void OnResume()
        {
            Console.WriteLine("Android Mainactivity Resume");
            base.OnResume();
        }
    }
}

