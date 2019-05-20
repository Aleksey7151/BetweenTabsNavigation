using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Details;
using BetweenTabsNavigation.Core.ViewModels.Tabs;

namespace BetweenTabsNavigation.Core.Navigation
{
    public interface INavigationService
    {
        void NavigateToHome(EntryViewModel fromViewModel);

        void NavigateToFirstTab(BottomTabBarViewModel fromViewModel, bool isDefault);

        void NavigateToSecondTab(BottomTabBarViewModel fromViewModel, bool isDefault);

        void NavigateToThirdTab(BottomTabBarViewModel fromViewModel, bool isDefault);

        void NavigateToDetails(ThirdTabViewModel fromViewModel);

        void NavigateToFirstTabWithResult(DetailsViewModel fromViewModel, DetailsResult result);
    }
}
