using BetweenTabsNavigation.Core.Bootstrapper;
using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Droid.Navigation;
using FlexiMvvm.Bootstrappers;

namespace BetweenTabsNavigation.Droid.Bootstrapper
{
    internal sealed class AndroidBootstrapper : IBootstrapper
    {
        public void Execute(BootstrapperConfig config)
        {
            var simpleIoc = config.GetSimpleIoc();
            simpleIoc.Register<INavigationService>(() => new AppNavigationService());
        }
    }
}