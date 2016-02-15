using System;

using Android.App;
using Android.Runtime;

namespace MaterialDesignSandbox.Droid
{
    [Application]
    public class MaterialDesignSandboxApplication : Android.App.Application
    {
        public MaterialDesignSandboxApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }
    }
}

