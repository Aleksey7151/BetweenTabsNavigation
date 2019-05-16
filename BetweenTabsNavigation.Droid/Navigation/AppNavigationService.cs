using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using BetweenTabsNavigation.Droid.Views;
using FlexiMvvm.Navigation;

namespace BetweenTabsNavigation.Droid.Navigation
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
        }

        public void NavigateToSecondPage(FirstTabViewModel fromTabViewModel)
        {
        }

        public void NavigateToThirdPage(SecondTabViewModel fromTabViewModel)
        {
        }
    }
}