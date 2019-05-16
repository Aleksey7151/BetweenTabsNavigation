using BetweenTabsNavigation.Core.Navigation;
using FlexiMvvm.Bootstrappers;
using NavigationFlow.iOS.Navigation;

namespace NavigationFlow.iOS.Bootstrapper
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