using BetweenTabsNavigation.Core.ViewModels;

namespace BetweenTabsNavigation.Core.Navigation
{
    public interface INavigationService
    {
        void NavigateToHome(EntryViewModel fromViewModel);

        void NavigateToFirstTab(BottomTabBarViewModel fromViewModel, bool isDefault);

        void NavigateToSecondTab(BottomTabBarViewModel fromViewModel, bool isDefault);

        void NavigateToThirdTab(BottomTabBarViewModel fromViewModel, bool isDefault);
    }
}
