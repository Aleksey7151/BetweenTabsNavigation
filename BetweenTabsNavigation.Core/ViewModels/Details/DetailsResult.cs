using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels.Details
{
    public sealed class DetailsResult : Result
    {
        public string Value
        {
            get => Bundle.GetString();
            set => Bundle.SetString(value);
        }
    }
}
