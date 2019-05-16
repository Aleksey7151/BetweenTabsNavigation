using System;
using Android.App;
using Android.Runtime;
using BetweenTabsNavigation.Core.Bootstrapper;
using BetweenTabsNavigation.Droid.Bootstrapper;
using FlexiMvvm.Bootstrappers;
using FlexiMvvm.Ioc;

namespace BetweenTabsNavigation.Droid
{
    [Application]
    public sealed class Application : Android.App.Application
    {
        public Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            var config = new BootstrapperConfig();
            config.SetSimpleIoc(new SimpleIoc());

            var compositeBootstrapper = new CompositeBootstrapper(new AndroidBootstrapper(), new CoreBootstrapper());
            compositeBootstrapper.Execute(config);
        }
    }
}