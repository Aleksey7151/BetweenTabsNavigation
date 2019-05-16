using BetweenTabsNavigation.Core.Navigation;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels
{
    public sealed class EntryViewModel : LifecycleViewModel
    {
        private readonly INavigationService _navigationService;

        public EntryViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Initialize(bool recreated)
        {
            base.Initialize(recreated);

            if (!recreated)
            {
                _navigationService.NavigateToHome(this);
            }
        }
    }
}
