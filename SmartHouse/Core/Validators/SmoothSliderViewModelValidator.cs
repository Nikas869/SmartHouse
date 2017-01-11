using System.ComponentModel.DataAnnotations;
using Core.ViewModels.Components;

namespace Core.Validators
{
    class SmoothSliderViewModelValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            SmoothSliderViewModel slider = value as SmoothSliderViewModel;
            if (slider.MaxValue <= slider.MinValue)
            {
                return false;
            }
            return true;
        }
    }
}