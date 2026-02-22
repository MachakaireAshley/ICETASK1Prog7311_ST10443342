using System.ComponentModel.DataAnnotations;

namespace MyCVApp.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Skill Category")]
        public SkillCategory Category { get; set; }

        [Range(1, 5)]
        public int ProficiencyLevel { get; set; } // 1-5 scale
    }

    public enum SkillCategory
    {
        Technical,
        Language,
        Soft
    }
}