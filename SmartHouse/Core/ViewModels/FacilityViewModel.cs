using System;
using System.Collections.Generic;
using Core.ViewModels.Components;

namespace Core.ViewModels
{
    public class FacilityViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<ComponentViewModel> Components { get; set; }
    }
}