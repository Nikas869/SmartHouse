using Core.Validators;

namespace Core.ViewModels.Components
{
    [SmoothSliderViewModelValidator]
    public class SmoothSliderViewModel : ComponentViewModel
    {
        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public int Value { get; set; }
    }
}