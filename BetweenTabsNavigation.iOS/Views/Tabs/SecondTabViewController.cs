using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Views;

namespace BetweenTabsNavigation.iOS.Views.Tabs
{
    internal sealed class SecondTabViewController : BindableViewController<SecondTabViewModel>
    {
        public new SecondTabView View
        {
            get => (SecondTabView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new SecondTabView();
        }
    }
}