using Cirrious.FluentLayouts.Touch;
using FlexiMvvm.Views;
using UIKit;

namespace BetweenTabsNavigation.iOS.Views.Tabs
{
    internal sealed class FirstTabView : LayoutView
    {
        private UILabel HeaderLabel { get; set; }

        public UILabel ResultLabel { get; private set; }

        protected override void SetupSubviews()
        {
            base.SetupSubviews();

            BackgroundColor = UIColor.White;

            HeaderLabel = new UILabel { Text = "Home screen" };

            ResultLabel = new UILabel();
        }

        protected override void SetupLayout()
        {
            base.SetupLayout();

            this.AddLayoutSubview(HeaderLabel)
                .AddLayoutSubview(ResultLabel);
        }

        protected override void SetupLayoutConstraints()
        {
            base.SetupLayoutConstraints();

            this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            this.AddConstraints(
                HeaderLabel.WithSameCenterX(this),
                HeaderLabel.WithSameCenterY(this));

            this.AddConstraints(
                ResultLabel.Below(HeaderLabel, 24),
                ResultLabel.WithSameCenterX(this));
        }
    }
}