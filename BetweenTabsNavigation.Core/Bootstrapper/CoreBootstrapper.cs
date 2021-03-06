﻿using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Details;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Bootstrappers;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.Bootstrapper
{
    public sealed class CoreBootstrapper : IBootstrapper
    {
        public void Execute(BootstrapperConfig config)
        {
            var simpleIoc = config.GetSimpleIoc();

            simpleIoc.Register(() => new EntryViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new BottomTabBarViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new FirstTabViewModel());
            simpleIoc.Register(() => new SecondTabViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new ThirdTabViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new DetailsViewModel(simpleIoc.Get<INavigationService>()));

            LifecycleViewModelProvider.SetFactory(new DefaultLifecycleViewModelFactory(simpleIoc));
        }
    }
}
