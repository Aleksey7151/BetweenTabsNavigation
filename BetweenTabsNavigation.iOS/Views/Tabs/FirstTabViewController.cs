using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using UIKit;

namespace BetweenTabsNavigation.iOS.Views.Tabs
{
    internal sealed class FirstTabViewController : BindableViewController<FirstTabViewModel>
    {
        private UIBarButtonItem CloseButton { get; } = new UIBarButtonItem("Close", UIBarButtonItemStyle.Plain, null);

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

            bindingSet.Bind(View.NextButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.GoToNextCommand);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            NavigationItem.LeftBarButtonItem = CloseButton;
        }
    }
}