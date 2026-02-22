using System.ComponentModel.DataAnnotations;

namespace MyCVApp.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Institution { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Qualification")]
        public string Degree { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public string? Description { get; set; }

        [Display(Name = "Current")]
        public bool IsCurrent { get; set; }
    }
}