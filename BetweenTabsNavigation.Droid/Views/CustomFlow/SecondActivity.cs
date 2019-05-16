using Android.App;
using Android.OS;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;

namespace NavigationFlow.Droid.Views.CustomFlow
{
    [Activity(Label = "SecondActivity")]
    internal sealed class SecondActivity : BindableAppCompatActivity<SecondTabViewModel>
    {
        private SecondActivityViewHolder ViewHolder { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_second);

            ViewHolder = new SecondActivityViewHolder(this);
        }

        public override void Bind(BindingSet<SecondTabViewModel> bindingSet)
        {
            bindingSet.Bind(ViewHolder.NextButton)
                .For(v => v.ClickBinding())
                .To(vm => vm.GoToNextCommand);
        }
    }
}