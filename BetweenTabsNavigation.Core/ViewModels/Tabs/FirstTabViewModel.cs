using System.Windows.Input;
using BetweenTabsNavigation.Core.Navigation;
using BetweenTabsNavigation.Core.ViewModels.Details;
using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels.Tabs
{
    public sealed class FirstTabViewModel : LifecycleViewModel, ILifecycleViewModelWithResultHandler
    {
        private string _result;

        public string Result
        {
            get => _result;
            set => SetValue(ref _result, value);
        }

        public void HandleResult(ResultCode resultCode, Result result)
        {
            if (result is DetailsResult detailsResult)
            {
                Result = detailsResult.Value;
            }
        }
    }
}
