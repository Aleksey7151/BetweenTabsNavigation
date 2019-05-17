using System.Windows.Input;
using BetweenTabsNavigation.Core.Navigation;
using FlexiMvvm.Commands;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels
{
    public sealed class BottomTabBarViewModel : LifecycleViewModel
    {
        private const BottomTabBarItem DefaultItem = BottomTabBarItem.First;

        private readonly INavigationService _navigationService;

        public BottomTabBarViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public BottomTabBarItem SelectedItem
        {
            get => State.GetEnum(defaultValue: BottomTabBarItem.None);
            private set => State.SetEnum(value);
        }

        public Command<BottomTabBarItem> NavigateToItemCommand => CommandProvider.Get<BottomTabBarItem>(NavigateToItem, CanNavigateToItem);

        public Command SelectDefaultItemCommand => CommandProvider.Get(SelectDefaultItem);

        public override void Initialize(bool recreated)
        {
            base.Initialize(recreated);

            if (!recreated)
            {
                NavigateToItem(DefaultItem);
            }
        }

        private void NavigateToItem(BottomTabBarItem item)
        {
            var isDefaultItem = item == DefaultItem;

            switch (item)
            {
                case BottomTabBarItem.First:
                    _navigationService.NavigateToFirstTab(this, isDefaultItem);
                    SelectedItem = item;
                    break;
                case BottomTabBarItem.Second:
                    _navigationService.NavigateToSecondTab(this, isDefaultItem);
                    SelectedItem = item;
                    break;
                case BottomTabBarItem.Third:
                    _navigationService.NavigateToThirdTab(this, isDefaultItem);
                    SelectedItem = item;
                    break;
                default:
                    /* DiagnosticLogger.NonCriticalIssue($"'{item}' side bar menu item is not handled."); */
                    break;
            }
        }

        private bool CanNavigateToItem(BottomTabBarItem item)
        {
            return item != SelectedItem && item != BottomTabBarItem.None;
        }

        private void SelectDefaultItem()
        {
            SelectedItem = DefaultItem;
        }
    }
}
