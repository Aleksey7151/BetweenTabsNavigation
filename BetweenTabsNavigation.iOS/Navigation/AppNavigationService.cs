using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
using NavigationFlow.Core.ViewModels;
using NavigationFlow.iOS.Views;
using NavigationFlow.iOS.Views.CustomFlow;

namespace NavigationFlow.iOS.Navigation
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
            var homeViewController = NavigationViewProvider.GetViewController<HomeViewController, HomeViewModel>(fromViewModel);
            var customFlowNavigationController = new CustomFlowNavigationController();
            customFlowNavigationController.PushViewController(new FirstViewController(), false);

            NavigateForResult<CustomFlowNavigationController, FlowResult>(
                homeViewController,
                customFlowNavigationController,
                true,
                NavigationStrategy.Forward.PresentViewController());
        }

        public void NavigateToSecondPage(FirstTabViewModel fromTabViewModel)
        {
            var firstViewController = NavigationViewProvider.GetViewController<FirstViewController, FirstTabViewModel>(fromTabViewModel);

            firstViewController.NavigationController.PushViewController(new SecondViewController(), true);
        }

        public void NavigateToThirdPage(SecondTabViewModel fromTabViewModel)
        {
            var secondViewController = NavigationViewProvider.GetViewController<SecondViewController, SecondTabViewModel>(fromTabViewModel);

            secondViewController.NavigationController.PushViewController(new ThirdViewController(), true);
        }

        public void NavigateBack<TResult>(ILifecycleViewModelWithResult<TResult> fromViewModel, ResultCode resultCode, TResult result)
            where TResult : Result
        {
            var fromView = NavigationViewProvider.Get(fromViewModel);

            NavigateBack(fromView, resultCode, result, true);
        }

        public void NavigateBack(FirstTabViewModel fromTabViewModel, ResultCode resultCode, FlowResult result)
        {
            var firstViewController = NavigationViewProvider.GetViewController<FirstViewController, FirstTabViewModel>(fromTabViewModel);
            var customFlowNavigationController = (CustomFlowNavigationController)firstViewController.NavigationController;

            NavigateBack(customFlowNavigationController, resultCode, result, true);
        }

        public void NavigateBack(ThirdTabViewModel fromTabViewModel, ResultCode resultCode, FlowResult result)
        {
            var thirdViewController = NavigationViewProvider.GetViewController<ThirdViewController, ThirdTabViewModel>(fromTabViewModel);
            var customFlowNavigationController = (CustomFlowNavigationController)thirdViewController.NavigationController;

            NavigateBack(customFlowNavigationController, resultCode, result, true);
        }
    }
}