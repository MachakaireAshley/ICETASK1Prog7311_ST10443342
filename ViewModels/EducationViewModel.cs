using System.ComponentModel.DataAnnotations;

namespace MyCVApp.ViewModels
{
    public class EducationViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Institution")]
        public string Institution { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Qualification")]
        public string Degree { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Start Year")]
        public int StartYear { get; set; }

        [Display(Name = "End Year")]
        public int? EndYear { get; set; }

        [Display(Name = "Current")]
        public bool IsCurrent { get; set; }

        public string? Activities { get; set; }
    }
}