using BetweenTabsNavigation.Core.ViewModels;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;

namespace BetweenTabsNavigation.iOS.Views
{
    internal sealed class HomeViewController : BindableViewController<HomeViewModel>
    {
        public new HomeView View
        {
            get => (HomeView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new HomeView();
        }

        public override void Bind(BindingSet<HomeViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            bindingSet.Bind(View.NextButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.StartSeparateFlowCommand);
        }
    }
}