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

            bindingSet.Bind(View.NextButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.OpenDetailsCommand);
        }
    }
}