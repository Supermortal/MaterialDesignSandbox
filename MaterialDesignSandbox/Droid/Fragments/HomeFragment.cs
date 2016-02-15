
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using Supermortal.Common.Droid.Abstract;

namespace MaterialDesignSandbox.Droid.Fragments
{
    public class HomeFragment : ModuleFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.HomeFragment, container, false);
        }

        public override void OnResume()
        {
            base.OnResume();
        }
    }
}

