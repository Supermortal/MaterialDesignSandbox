using SupportActivity = Android.Support.V7.App.AppCompatActivity;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;

using Android.App;
using Android.Widget;
using Android.OS;

namespace MaterialDesignSandbox.Droid
{
    [Activity(Label = "Material Design Sandbox", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/MyTheme")]
    public class MainActivity : SupportActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            var toolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = Resources.GetString(Resource.String.app_name);
        }
    }
}


