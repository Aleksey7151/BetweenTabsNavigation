using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.iOS.Views;
using BetweenTabsNavigation.iOS.Views.Tabs;
using FlexiMvvm.Navigation;

namespace BetweenTabsNavigation.iOS.Navigation
{
    internal sealed class AppNavigationService : NavigationService, INavigationService
    {
        public void NavigateToHome(EntryViewModel fromViewModel)
        {
            var rootNavigationController = NavigationViewProvider.GetViewController<RootNavigationController, EntryViewModel>(fromViewModel);
            var homeViewController = new BottomTabBarViewController();

            Navigate(rootNavigationController, homeViewController, true);
        }

        public void NavigateToFirstTab(BottomTabBarViewModel fromViewModel, bool isDefault)
        {
            var hostView = NavigationViewProvider.GetViewController<BottomTabBarViewController, BottomTabBarViewModel>(fromViewModel);
            hostView.SetContent(hostView.FirstTabNavigationController, () => new FirstTabViewController());
        }

        public void NavigateToSecondTab(BottomTabBarViewModel fromViewModel, bool isDefault)
        {
            var hostView = NavigationViewProvider.GetViewController<BottomTabBarViewController, BottomTabBarViewModel>(fromViewModel);
            hostView.SetContent(hostView.SecondTabNavigationController, () => new SecondTabViewController());
        }

        public void NavigateToThirdTab(BottomTabBarViewModel fromViewModel, bool isDefault)
        {
            var hostView = NavigationViewProvider.GetViewController<BottomTabBarViewController, BottomTabBarViewModel>(fromViewModel);
            hostView.SetContent(hostView.ThirdTabNavigationController, () => new ThirdTabViewController());
        }
    }
}