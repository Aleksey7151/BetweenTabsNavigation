using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;

namespace BetweenTabsNavigation.iOS.Views.Tabs
{
    internal sealed class ThirdTabViewController : BindableViewController<ThirdTabViewModel>
    {
        public new ThirdTabView View
        {
            get => (ThirdTabView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new ThirdTabView();
        }

        public override void Bind(BindingSet<ThirdTabViewModel> bindingSet)
        {
            base.Bind(bindingSet);
        }
    }
}