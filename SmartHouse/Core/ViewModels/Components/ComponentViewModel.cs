using System;
using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels.Components
{
    public class ComponentViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(5), MaxLength(255)]
        public string Name { get; set; }
    }
}