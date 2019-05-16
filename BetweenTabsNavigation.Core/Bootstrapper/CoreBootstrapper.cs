using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Bootstrappers;
using FlexiMvvm.ViewModels;
using NavigationFlow.Core.ViewModels;

namespace BetweenTabsNavigation.Core.Bootstrapper
{
    public sealed class CoreBootstrapper : IBootstrapper
    {
        public void Execute(BootstrapperConfig config)
        {
            var simpleIoc = config.GetSimpleIoc();

            simpleIoc.Register(() => new EntryViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new HomeViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new FirstTabViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new SecondTabViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new ThirdTabViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new CustomFlowNavigationViewModel());

            LifecycleViewModelProvider.SetFactory(new DefaultLifecycleViewModelFactory(simpleIoc));
        }
    }
}
