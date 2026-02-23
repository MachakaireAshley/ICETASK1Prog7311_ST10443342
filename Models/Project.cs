using System.ComponentModel.DataAnnotations;

namespace MyCVApp.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string TechStack { get; set; } = string.Empty;

        [Url]
        [Display(Name = "GitHub Repository")]
        public string? GitHubUrl { get; set; }

        [Url]
        [Display(Name = "Live Demo")]
        public string? LiveDemoUrl { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime DateCompleted { get; set; }

        public bool IsFintechRelated { get; set; }

        public List<string> KeyFeatures { get; set; } = new List<string>();
    }
}