using System.Windows.Input;
using BetweenTabsNavigation.Core.Navigation;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels.Details
{
    public sealed class DetailsViewModel : LifecycleViewModel
    {
        private readonly INavigationService _navigationService;

        public DetailsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand AcceptCommand => CommandProvider.Get(Accept);

        public string Result
        {
            get => State.GetString();
            set => State.SetString(value);
        }

        private void Accept()
        {
        }
    }
}
