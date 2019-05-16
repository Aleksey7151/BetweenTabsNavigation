using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using BetweenTabsNavigation.iOS.Views;
using BetweenTabsNavigation.iOS.Views.Tabs;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.iOS.Navigation
{
    internal sealed class AppNavigationService : NavigationService, INavigationService
    {
        public void NavigateToHome(EntryViewModel fromViewModel)
        {
            var rootNavigationController = NavigationViewProvider.GetViewController<RootNavigationController, EntryViewModel>(fromViewModel);
            var homeViewController = new HomeViewController();

            Navigate(rootNavigationController, homeViewController, true);
        }

        public void NavigateToFirstPage(HomeViewModel fromViewModel)
        {
        }

        public void NavigateToSecondPage(FirstTabViewModel fromTabViewModel)
        {
            var firstViewController = NavigationViewProvider.GetViewController<FirstTabViewController, FirstTabViewModel>(fromTabViewModel);

            firstViewController.NavigationController.PushViewController(new SecondTabViewController(), true);
        }

        public void NavigateToThirdPage(SecondTabViewModel fromTabViewModel)
        {
            var secondViewController = NavigationViewProvider.GetViewController<SecondTabViewController, SecondTabViewModel>(fromTabViewModel);

            secondViewController.NavigationController.PushViewController(new ThirdTabViewController(), true);
        }

        public void NavigateBack<TResult>(ILifecycleViewModelWithResult<TResult> fromViewModel, ResultCode resultCode, TResult result)
            where TResult : Result
        {
            var fromView = NavigationViewProvider.Get(fromViewModel);

            NavigateBack(fromView, resultCode, result, true);
        }
    }
}