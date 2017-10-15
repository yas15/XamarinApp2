using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "MyApp_V2", MainLauncher = true, Icon = "@drawable/robot_2")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

