using Android.App;
using Android.OS;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using NavigationFlow.Droid;
using NavigationFlow.Droid.Views;

namespace BetweenTabsNavigation.Droid.Views.CustomFlow
{
    [Activity(Label = "FirstActivity")]
    internal sealed class FirstActivity : BindableAppCompatActivity<FirstTabViewModel>
    {
        private FirstActivityViewHolder ViewHolder { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_first);

            ViewHolder = new FirstActivityViewHolder(this);
        }

        public override void Bind(BindingSet<FirstTabViewModel> bindingSet)
        {
            bindingSet.Bind(ViewHolder.NextButton)
                .For(v => v.ClickBinding())
                .To(vm => vm.GoToNextCommand);
        }
    }
}