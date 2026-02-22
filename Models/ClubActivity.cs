using System.ComponentModel.DataAnnotations;

namespace MyCVApp.Models
{
    public class ClubActivity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public string Institution { get; set; } = string.Empty;

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Year")]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Year")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Activity Type")]
        public ActivityType Type { get; set; }
    }

    public enum ActivityType
    {
        Club,
        Sport,
        Leadership,
        Volunteer
    }
}