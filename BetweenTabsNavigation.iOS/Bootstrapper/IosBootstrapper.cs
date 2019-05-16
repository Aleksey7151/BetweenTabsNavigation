using BetweenTabsNavigation.Core.Bootstrapper;
using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.iOS.Navigation;
using FlexiMvvm.Bootstrappers;

namespace BetweenTabsNavigation.iOS.Bootstrapper
{
    internal sealed class IosBootstrapper : IBootstrapper
    {
        public void Execute(BootstrapperConfig config)
        {
            var simpleIoc = config.GetSimpleIoc();
            simpleIoc.Register<INavigationService>(() => new AppNavigationService());
        }
    }
}