using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using BetweenTabsNavigation.Droid.Views.CustomFlow;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
using NavigationFlow.Core.ViewModels;
using NavigationFlow.Droid.Views;
using NavigationFlow.Droid.Views.CustomFlow;

namespace NavigationFlow.Droid.Navigation
{
    internal sealed class AppNavigationService : NavigationService, INavigationService
    {
        public void NavigateToHome(EntryViewModel fromViewModel)
        {
            var fromView = NavigationViewProvider.GetActivity<SplashScreenActivity, EntryViewModel>(fromViewModel);

            Navigate<HomeActivity>(fromView);
        }

        public void NavigateToFirstPage(HomeViewModel fromViewModel)
        {
            var fromView = NavigationViewProvider.GetActivity<HomeActivity, HomeViewModel>(fromViewModel);

            NavigateForResult<FirstActivity, FlowResult>(fromView);
        }

        public void NavigateToSecondPage(FirstTabViewModel fromTabViewModel)
        {
            var fromView = NavigationViewProvider.GetActivity<FirstActivity, FirstTabViewModel>(fromTabViewModel);

            NavigateForResult<SecondActivity, FlowResult>(fromView);
        }

        public void NavigateToThirdPage(SecondTabViewModel fromTabViewModel)
        {
            var fromView = NavigationViewProvider.GetActivity<SecondActivity, SecondTabViewModel>(fromTabViewModel);

            NavigateForResult<ThirdActivity, FlowResult>(fromView);
        }

        public void NavigateBack<TResult>(ILifecycleViewModelWithResult<TResult> fromViewModel, ResultCode resultCode, TResult result)
            where TResult : Result
        {
            var fromView = NavigationViewProvider.Get(fromViewModel);

            NavigateBack(fromView, resultCode, result);
        }

        public void NavigateBack(ThirdTabViewModel fromTabViewModel, ResultCode resultCode, FlowResult result)
        {
            NavigateBack<FlowResult>(fromTabViewModel, resultCode, result);
        }

        public void NavigateBack(FirstTabViewModel fromTabViewModel, ResultCode resultCode, FlowResult result)
        {
            NavigateBack<FlowResult>(fromTabViewModel, resultCode, result);
        }
    }
}