using System.Linq;
using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Details;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using BetweenTabsNavigation.iOS.Views;
using BetweenTabsNavigation.iOS.Views.Details;
using BetweenTabsNavigation.iOS.Views.Tabs;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
using FlexiMvvm.Views;

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

        public void NavigateToDetails(ThirdTabViewModel fromViewModel)
        {
            var thirdTabViewController = NavigationViewProvider.GetViewController<ThirdTabViewController, ThirdTabViewModel>(fromViewModel);
            thirdTabViewController.NavigationController.PushViewController(new DetailsViewController(), true);
        }

        public void NavigateToFirstTabWithResult(DetailsViewModel fromViewModel, DetailsResult result)
        {
            var detailsViewController = NavigationViewProvider.GetViewController<DetailsViewController, DetailsViewModel>(fromViewModel);

            if (detailsViewController.NavigationController?.ParentViewController is BottomTabBarViewController hostViewController)
            {
                var viewController = hostViewController
                    .FirstTabNavigationController
                    .ViewControllers
                    ?.FirstOrDefault();

                if (viewController is FirstTabViewController firstTabViewController)
                {
                    firstTabViewController.HandleResult(fromViewModel, new ResultSetEventArgs(ResultCode.Ok, result));
                }

                hostViewController.SetContent(hostViewController.FirstTabNavigationController, () => new FirstTabViewController());
            }
        }
    }
}