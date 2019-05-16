using BetweenTabsNavigation.Core.ViewModels;
using BetweenTabsNavigation.Core.ViewModels.Tabs;

namespace BetweenTabsNavigation.Core.Navigation
{
    public interface INavigationService
    {
        void NavigateToHome(EntryViewModel fromViewModel);

        void NavigateToFirstPage(HomeViewModel fromViewModel);

        void NavigateToSecondPage(FirstTabViewModel fromTabViewModel);

        void NavigateToThirdPage(SecondTabViewModel fromTabViewModel);
    }
}
