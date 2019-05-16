using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;

namespace NavigationFlow.iOS.Views.CustomFlow
{
    internal sealed class SecondViewController : BindableViewController<SecondTabViewModel>
    {
        public new SecondView View
        {
            get => (SecondView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new SecondView();
        }

        public override void Bind(BindingSet<SecondTabViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            bindingSet.Bind(View.NextButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.GoToNextCommand);
        }
    }
}