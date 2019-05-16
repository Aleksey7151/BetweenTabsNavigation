using System.Windows.Input;
using BetweenTabsNavigation.Core.Navigation;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels.Tabs
{
    public sealed class FirstTabViewModel : LifecycleViewModel
    {
        private readonly INavigationService _navigationService;

        public FirstTabViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand GoToNextCommand => CommandProvider.Get(GoToNext);

        private void GoToNext()
        {
            _navigationService.NavigateToSecondPage(this);
        }
    }
}
