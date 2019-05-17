using Cirrious.FluentLayouts.Touch;
using FlexiMvvm.Views;
using UIKit;

namespace BetweenTabsNavigation.iOS.Views.Details
{
    internal sealed class DetailsView : LayoutView
    {
        public UITextField ResultTextField { get; private set; }

        public UIButton AcceptButton { get; private set; }

        protected override void SetupSubviews()
        {
            base.SetupSubviews();

            BackgroundColor = UIColor.White;

            ResultTextField = new UITextField
            {
                AccessibilityHint = "Enter result",
                BackgroundColor = UIColor.Yellow
            };

            AcceptButton = new UIButton(UIButtonType.System);
            AcceptButton.SetTitle("Accept", UIControlState.Normal);
        }

        protected override void SetupLayout()
        {
            base.SetupLayout();

            this.AddLayoutSubview(ResultTextField)
                .AddLayoutSubview(AcceptButton);
        }

        protected override void SetupLayoutConstraints()
        {
            base.SetupLayoutConstraints();

            this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            this.AddConstraints(
                ResultTextField.AtLeftOf(this, 24),
                ResultTextField.AtRightOf(this, 24),
                ResultTextField.WithSameCenterY(this));

            this.AddConstraints(
                AcceptButton.Below(ResultTextField, 24),
                AcceptButton.WithSameCenterX(this));
        }
    }
}