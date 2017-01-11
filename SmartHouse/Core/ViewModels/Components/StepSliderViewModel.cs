using Core.Validators;

namespace Core.ViewModels.Components
{
    [StepSliderViewModelValidator]
    public class StepSliderViewModel : ComponentViewModel
    {
        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public int Step { get; set; }

        public int Value { get; set; }
    }
}