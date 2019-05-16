using System.Windows.Input;
using BetweenTabsNavigation.Core.Navigation;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels
{
    public sealed class HomeViewModel : LifecycleViewModel
    {
        private readonly INavigationService _navigationService;

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand StartSeparateFlowCommand => CommandProvider.Get(StartFlow);

        private void StartFlow()
        {
            _navigationService.NavigateToFirstPage(this);
        }
    }
}
