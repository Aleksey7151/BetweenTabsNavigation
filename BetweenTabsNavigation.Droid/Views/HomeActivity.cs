using Android.App;
using Android.OS;
using BetweenTabsNavigation.Core.ViewModels;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;

namespace BetweenTabsNavigation.Droid.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    internal sealed class HomeActivity : BindableAppCompatActivity<BottomTabBarViewModel>
    {
        //private HomeActivityViewHolder ViewHolder { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_home);

            //ViewHolder = new HomeActivityViewHolder(this);
        }

        public override void Bind(BindingSet<BottomTabBarViewModel> bindingSet)
        {
            /*bindingSet.Bind(ViewHolder.NextButton)
                .For(v => v.ClickBinding())
                .To(vm => vm.StartSeparateFlowCommand);*/
        }
    }
}