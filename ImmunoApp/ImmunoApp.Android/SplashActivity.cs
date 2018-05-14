using Acr.UserDialogs;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using ImmunoApp.Droid;
using System;
using System.Threading.Tasks;

/// <summary>
/// Class for splash screen for android app
/// author: Christian Bender
/// Source: https://developer.xamarin.com/samples/monodroid/SplashScreen/
/// </summary>
[Activity(Label = "ImmunoApp", Icon = "@drawable/icon", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
public class SplashActivity : AppCompatActivity
{

    /// <summary>
    /// Is called on creation of the app
    /// </summary>
    /// <param name="savedInstanceState"></param>
    /// <param name="persistentState"></param>
    public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
    {
        //Init the UserDialogs Instance
        //UserDialogs.Init(this);
        base.OnCreate(savedInstanceState, persistentState);
    }

    /// <summary>
    /// Call mainactivity on resume
    /// </summary>
    protected override void OnResume()
    {
        Console.WriteLine("Android Splashactivity Resume");
        base.OnResume();
        Task startupWork = new Task(() => { SimulateStartup(); });
        startupWork.Start();
    }

    /// <summary>
    /// Simulates background work that happens behind the splash screen. Waits currently for 3 seconds
    /// </summary>
    async void SimulateStartup()
    {
        await Task.Delay(3000); 
        StartActivity(new Intent(Application.Context, typeof(MainActivity)));
    }
}