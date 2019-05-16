using Android.App;
using BetweenTabsNavigation.Core.ViewModels;
using FlexiMvvm.Views;

namespace BetweenTabsNavigation.Droid.Views
{
    [Activity(Label = "SplashScreenActivity", NoHistory = true, MainLauncher = true)]
    internal sealed class SplashScreenActivity : AppCompatActivity<EntryViewModel>
    {
    }
}