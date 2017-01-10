using AutoMapper;
using Core.ViewModels;
using Core.ViewModels.Components;
using DataAccess.Models.Components;
using DataAccess.Models.Facilities;

namespace Core.Utilities
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Component, ComponentViewModel>()
                    .Include<Switch, SwitchViewModel>()
                    .Include<SmoothSlider, SmoothSliderViewModel>()
                    .Include<StepSlider, StepSliderViewModel>();
                config.CreateMap<Switch, SwitchViewModel>();
                config.CreateMap<SmoothSlider, SmoothSliderViewModel>();
                config.CreateMap<StepSlider, StepSliderViewModel>();

                config.CreateMap<Facility, FacilityViewModel>();
            });
        }
    }
}