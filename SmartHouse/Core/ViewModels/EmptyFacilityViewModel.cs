using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels
{
    public class EmptyFacilityViewModel
    {
        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string Name { get; set; }
    }
}