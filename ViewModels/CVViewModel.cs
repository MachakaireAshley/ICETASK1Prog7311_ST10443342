using MyCVApp.Models;

namespace MyCVApp.ViewModels
{
    public class CVViewModel
    {
        public Person PersonalInfo { get; set; } = new Person();
        public List<Education> EducationList { get; set; } = new List<Education>();
        public List<Experience> ExperienceList { get; set; } = new List<Experience>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<ClubActivity> Activities { get; set; } = new List<ClubActivity>();
        public List<Project> Projects { get; set; } = new List<Project>();


        // Grouped skills for better display
        public List<Skill> TechnicalSkills => Skills?.Where(s => s.Category == SkillCategory.Technical).ToList() ?? new List<Skill>();
        public List<Skill> LanguageSkills => Skills?.Where(s => s.Category == SkillCategory.Language).ToList() ?? new List<Skill>();
        public List<Skill> SoftSkills => Skills?.Where(s => s.Category == SkillCategory.Soft).ToList() ?? new List<Skill>();

        // Fintech-focused skills
        public List<Skill> FintechSkills => TechnicalSkills?.Where(s =>
            s.Name.Contains("SQL") ||
            s.Name.Contains("C#") ||
            s.Name.Contains("Java") ||
            s.Name.Contains("Security") ||
            s.Name.Contains("Blockchain")).ToList() ?? new List<Skill>();

        // Grouped experiences
        public List<Experience> Internships => ExperienceList?.Where(e => e.Type == ExperienceType.Internship).ToList() ?? new List<Experience>();
        public List<Experience> VolunteerWork => ExperienceList?.Where(e => e.Type == ExperienceType.Volunteer).ToList() ?? new List<Experience>();

        // Fintech projects
        public List<Project> FintechProjects => Projects?.Where(p => p.IsFintechRelated).ToList() ?? new List<Project>();
    }
}