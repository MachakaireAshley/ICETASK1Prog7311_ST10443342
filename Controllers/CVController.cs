using Microsoft.AspNetCore.Mvc;
using MyCVApp.Models;
using MyCVApp.ViewModels;

namespace MyCVApp.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CVViewModel
            {
                PersonalInfo = new Person(),

                EducationList = new List<Education>
                {
                    new Education
                    {
                        Institution = "IIE MSA / Emeris University",
                        Degree = "Bachelor of Computer and Information in Application",
                        Location = "Johannesburg, South Africa",
                        StartDate = new DateTime(2024, 1, 1),
                        EndDate = new DateTime(2026, 12, 31),
                        IsCurrent = true,
                        Description = "Class Representative 2024 - present, Member of IT Society 2024-present"
                    },
                    new Education
                    {
                        Institution = "Arundel School",
                        Degree = "High School Diploma",
                        Location = "Harare, Zimbabwe",
                        StartDate = new DateTime(2017, 1, 1),
                        EndDate = new DateTime(2022, 12, 31),
                        Description = "Member of First Aid Club, Volleyball Team, Toastmaster, Basketball Assistant"
                    },
                    new Education
                    {
                        Institution = "Gateway Primary School",
                        Degree = "Primary Education",
                        Location = "Harare, Zimbabwe",
                        StartDate = new DateTime(2012, 5, 1),
                        EndDate = new DateTime(2016, 12, 31),
                        Description = "Member of Choir Club, Sign Language Club, Drama Club"
                    }
                },

                ExperienceList = new List<Experience>
                {
                    
                    new Experience
                    {
                        JobTitle = "Intern",
                        Company = "Family Practice",
                        Location = "Harare, Zimbabwe",
                        StartDate = new DateTime(2023, 1, 1),
                        EndDate = new DateTime(2023, 12, 31),
                        Type = ExperienceType.Internship,
                        Responsibilities = new List<string>
                        {
                            "Assisted in patient intake processes by accurately recording medical histories, enhancing efficiency in patient flow",
                            "Explored new technologies and approaches to streamline processes",
                            "Supported staff members in their daily tasks, reducing workload burden and allowing for increased focus on higher-priority assignments"
                        }
                    },
                    new Experience
                    {
                        JobTitle = "Volunteer Assistant",
                        Company = "High School",
                        Location = "Harare, Zimbabwe",
                        StartDate = new DateTime(2022, 1, 1),
                        EndDate = new DateTime(2022, 12, 31),
                        Type = ExperienceType.Volunteer,
                        Responsibilities = new List<string>
                        {
                            "Assisted in organizing basketball events, enhancing student participation and fostering school engagement",
                            "Supported engaging, fun and smooth-running events by helping with organization and planning",
                            "Helped in coaching the younger teams and assisted in drills"
                        }
                    }
                },

                Skills = new List<Skill>
                {
                    // Technical Skills
                    new Skill { Name = "Microsoft Software", Category = SkillCategory.Technical, ProficiencyLevel = 4 },
                    new Skill { Name = "Java", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "C#", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "Android Studio", Category = SkillCategory.Technical, ProficiencyLevel = 2 },
                    new Skill { Name = "HTML", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "SQL", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "JavaScript", Category = SkillCategory.Technical, ProficiencyLevel = 2 },
                    new Skill { Name = "GitHub", Category = SkillCategory.Technical, ProficiencyLevel = 4 },
                    
                    // Languages
                    new Skill { Name = "English", Category = SkillCategory.Language, ProficiencyLevel = 5 },
                    new Skill { Name = "Shona", Category = SkillCategory.Language, ProficiencyLevel = 5 },
                    new Skill { Name = "French", Category = SkillCategory.Language, ProficiencyLevel = 2 },
                    
                    // Soft Skills
                    new Skill { Name = "Excellent Communication", Category = SkillCategory.Soft, ProficiencyLevel = 5 },
                    new Skill { Name = "Organized", Category = SkillCategory.Soft, ProficiencyLevel = 4 },
                    new Skill { Name = "Problem Solving", Category = SkillCategory.Soft, ProficiencyLevel = 4 },
                    new Skill { Name = "Meticulous", Category = SkillCategory.Soft, ProficiencyLevel = 4 },
                    new Skill { Name = "Detail-oriented", Category = SkillCategory.Soft, ProficiencyLevel = 5 }
                },

                Activities = new List<ClubActivity>
                {
                    new ClubActivity { Name = "IT Society", Role = "Vice President", Institution = "Emeris University", Type = ActivityType.Club, StartDate = new DateTime(2024, 1, 1) },
                    new ClubActivity { Name = "First Aid Club", Role = "Member", Institution = "Arundel School", Type = ActivityType.Club, StartDate = new DateTime(2017, 1, 1), EndDate = new DateTime(2022, 12, 31) },
                    new ClubActivity { Name = "Volleyball", Role = "Team Member", Institution = "Arundel School", Type = ActivityType.Sport, StartDate = new DateTime(2018, 1, 1), EndDate = new DateTime(2022, 12, 31) },
                    new ClubActivity { Name = "Toastmaster", Role = "Member", Institution = "Arundel School", Type = ActivityType.Club, StartDate = new DateTime(2021, 1, 1), EndDate = new DateTime(2022, 12, 31) },
                    new ClubActivity { Name = "Basketball", Role = "Assistant Coach", Institution = "Arundel School", Type = ActivityType.Leadership, StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 12, 31) },
                    new ClubActivity { Name = "Choir Club", Role = "Member", Institution = "Gateway Primary School", Type = ActivityType.Club, StartDate = new DateTime(2012, 1, 1), EndDate = new DateTime(2016, 12, 31) },
                    new ClubActivity { Name = "Sign Language Club", Role = "Member", Institution = "Gateway Primary School", Type = ActivityType.Club, StartDate = new DateTime(2012, 1, 1), EndDate = new DateTime(2013, 12, 31) },
                    new ClubActivity { Name = "Drama Club", Role = "Member", Institution = "Gateway Primary School", Type = ActivityType.Club, StartDate = new DateTime(2015, 1, 1), EndDate = new DateTime(2016, 12, 31) }
                }
            };

            return View(viewModel);
        }
    }
}