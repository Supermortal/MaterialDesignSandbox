using SupportActivity = Android.Support.V7.App.AppCompatActivity;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;

using Android.App;
using Android.Widget;
using Android.OS;

using Supermortal.Common.Droid.Abstract;

using MaterialDesignSandbox.Droid.Fragments;

namespace MaterialDesignSandbox.Droid.Activities
{
    [Activity(Label = "Material Design Sandbox", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/MyTheme")]
    public class MainActivity : ModuleActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            var toolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = Resources.GetString(Resource.String.app_name);

            RegisterModule<HomeFragment>("Home");
            RegisterModule<TestFragment>("Test Module");

            SetupDrawer(Resource.Layout.DrawerItem, Resource.Id.left_drawer, Resource.Id.drawer_layout, Resource.String.app_name, Resource.String.app_name, Resource.Id.main);
            toolbar.Click += (object sender, System.EventArgs e) =>
            {
                ToggleDrawer();
            };

            ShowFragment(0);
        }
    }
}


