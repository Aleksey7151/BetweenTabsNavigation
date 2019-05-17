using BetweenTabsNavigation.Core.ViewModels.Details;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;

namespace BetweenTabsNavigation.iOS.Views.Details
{
    internal sealed class DetailsViewController : BindableViewController<DetailsViewModel>
    {
        public new DetailsView View
        {
            get => (DetailsView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new DetailsView();
        }

        public override void Bind(BindingSet<DetailsViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            bindingSet.Bind(View.ResultTextField)
                .For(v => v.TextAndEditingChangedBinding())
                .To(vm => vm.Result);

            bindingSet.Bind(View.AcceptButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.AcceptCommand);
        }
    }
}