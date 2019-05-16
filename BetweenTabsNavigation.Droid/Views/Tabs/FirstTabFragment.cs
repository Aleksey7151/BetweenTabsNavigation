using Android.OS;
using Android.Views;
using BetweenTabsNavigation.Core.ViewModels.Tabs;
using FlexiMvvm.Views;

namespace BetweenTabsNavigation.Droid.Views.Tabs
{
    public class FirstTabFragment : BindableFragment<FirstTabViewModel>
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}