using System.ComponentModel.DataAnnotations;
using Core.ViewModels.Components;

namespace Core.Validators
{
    class StepSliderViewModelValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            StepSliderViewModel slider = value as StepSliderViewModel;
            if (slider.MaxValue <= slider.MinValue 
                || slider.MaxValue - slider.MinValue < slider.Step)
            {
                return false;
            }
            return true;
        }
    }
}