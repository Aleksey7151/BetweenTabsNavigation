using Cirrious.FluentLayouts.Touch;
using FlexiMvvm.Views;
using UIKit;

namespace BetweenTabsNavigation.iOS.Views.Tabs
{
    internal sealed class ThirdTabView : LayoutView
    {
        private UILabel HeaderLabel { get; set; }

        public UIButton NextButton { get; private set; }

        protected override void SetupSubviews()
        {
            base.SetupSubviews();

            BackgroundColor = UIColor.White;

            HeaderLabel = new UILabel { Text = "Third Tab" };

            NextButton = new UIButton(UIButtonType.System);
            NextButton.SetTitle("Open details page", UIControlState.Normal);
        }

        protected override void SetupLayout()
        {
            base.SetupLayout();

            this.AddLayoutSubview(HeaderLabel)
                .AddLayoutSubview(NextButton);
        }

        protected override void SetupLayoutConstraints()
        {
            base.SetupLayoutConstraints();

            this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            this.AddConstraints(
                HeaderLabel.WithSameCenterX(this),
                HeaderLabel.WithSameCenterY(this));

            this.AddConstraints(
                NextButton.Below(HeaderLabel, 24),
                NextButton.WithSameCenterX(this));
        }
    }
}