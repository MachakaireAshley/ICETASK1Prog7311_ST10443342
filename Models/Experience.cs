using System.ComponentModel.DataAnnotations;

namespace MyCVApp.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Company/Organization")]
        public string Company { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Current")]
        public bool IsCurrent { get; set; }

        public List<string> Responsibilities { get; set; } = new List<string>();

        [Display(Name = "Experience Type")]
        public ExperienceType Type { get; set; }
    }

    public enum ExperienceType
    {
        Internship,
        Volunteer,
        Work
    }
}