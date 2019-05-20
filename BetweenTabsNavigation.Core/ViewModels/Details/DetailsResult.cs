using FlexiMvvm.ViewModels;

namespace BetweenTabsNavigation.Core.ViewModels.Details
{
    public sealed class DetailsResult : Result
    {
        public DetailsResult(string value)
        {
            Value = value;
        }

        public string Value
        {
            get => Bundle.GetString();
            private set => Bundle.SetString(value);
        }
    }
}
