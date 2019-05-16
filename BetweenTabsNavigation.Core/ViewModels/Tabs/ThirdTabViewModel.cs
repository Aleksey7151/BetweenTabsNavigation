using BetweenTabsNavigation.Core.Navigation;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels.Tabs
{
    public sealed class ThirdTabViewModel : LifecycleViewModel
    {
        private readonly INavigationService _navigationService;

        public ThirdTabViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
