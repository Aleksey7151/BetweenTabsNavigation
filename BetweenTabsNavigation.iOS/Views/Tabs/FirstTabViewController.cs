using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;

namespace BetweenTabsNavigation.iOS.Views.Tabs
{
    internal sealed class FirstTabViewController : BindableViewController<FirstTabViewModel>
    {
        public new FirstTabView View
        {
            get => (FirstTabView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new FirstTabView();
        }

        public override void Bind(BindingSet<FirstTabViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            bindingSet.Bind(View.ResultLabel)
                .For(v => v.TextBinding())
                .To(vm => vm.Result);
        }
    }
}