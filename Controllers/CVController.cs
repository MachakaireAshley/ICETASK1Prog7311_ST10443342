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
                        Degree = "Bachelor of Computer and Information Sciences in Application",
                        Location = "Johannesburg, South Africa",
                        StartDate = new DateTime(2024, 1, 1),
                        EndDate = new DateTime(2026, 12, 31),
                        IsCurrent = true,
                        Description = "Relevant Modules: Database Management, Information Security, Web Development, Object-Oriented Programming | Class Representative 2024-present | IT Society Vice-President"
                    },
                    new Education
                    {
                        Institution = "Arundel School",
                        Degree = "High School Diploma",
                        Location = "Harare, Zimbabwe",
                        StartDate = new DateTime(2017, 1, 1),
                        EndDate = new DateTime(2022, 12, 31),
                        Description = "Toastmaster (2021-2022) | First Aid Club (2017-2022) | Volleyball Team (2018-2022) | Basketball Assistant Coach (2022)"
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
                            "Managed patient data entry with 100% accuracy, demonstrating attention to detail essential for financial record-keeping",
                            "Streamlined administrative processes, reducing patient wait times by 15% through technology exploration",
                            "Handled confidential information with discretion and professionalism"
                        }
                    },
                    new Experience
                    {
                        JobTitle = "Volunteer Assistant Coach",
                        Company = "Arundel School Basketball",
                        Location = "Harare, Zimbabwe",
                        StartDate = new DateTime(2022, 1, 1),
                        EndDate = new DateTime(2022, 12, 31),
                        Type = ExperienceType.Volunteer,
                        Responsibilities = new List<string>
                        {
                            "Organized events for 50+ participants, developing project coordination skills",
                            "Coached junior teams, building leadership and communication abilities",
                            "Collaborated with coaching staff to plan effective practice sessions"
                        }
                    }
                },

                Skills = new List<Skill>
                {
                    // Technical Skills
                    new Skill { Name = "C#", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "Java", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "SQL", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "HTML/CSS", Category = SkillCategory.Technical, ProficiencyLevel = 4 },
                    new Skill { Name = "JavaScript", Category = SkillCategory.Technical, ProficiencyLevel = 1 },
                    new Skill { Name = "ASP.NET MVC", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "Python", Category = SkillCategory.Technical, ProficiencyLevel = 1 },
                    new Skill { Name = "Git/GitHub", Category = SkillCategory.Technical, ProficiencyLevel = 3 },
                    new Skill { Name = "Microsoft Office Suite", Category = SkillCategory.Technical, ProficiencyLevel = 4 },
                    new Skill { Name = "Data Analysis", Category = SkillCategory.Technical, ProficiencyLevel = 2 },
                    new Skill { Name = "Basic Cybersecurity Principles", Category = SkillCategory.Technical, ProficiencyLevel = 2 },
                    
                    // Languages
                    new Skill { Name = "English (Fluent)", Category = SkillCategory.Language, ProficiencyLevel = 5 },
                    new Skill { Name = "Shona (Native)", Category = SkillCategory.Language, ProficiencyLevel = 5 },
                    new Skill { Name = "French (Beginner)", Category = SkillCategory.Language, ProficiencyLevel = 2 },
                    new Skill { Name = "Sign Language (Beginner)", Category = SkillCategory.Language, ProficiencyLevel = 1 },
                    
                    // Soft Skills
                    new Skill { Name = "Attention to Detail", Category = SkillCategory.Soft, ProficiencyLevel = 5 },
                    new Skill { Name = "Problem Solving", Category = SkillCategory.Soft, ProficiencyLevel = 4 },
                    new Skill { Name = "Communication", Category = SkillCategory.Soft, ProficiencyLevel = 5 },
                    new Skill { Name = "Organization", Category = SkillCategory.Soft, ProficiencyLevel = 4 },
                    new Skill { Name = "Team Collaboration", Category = SkillCategory.Soft, ProficiencyLevel = 4 },
                    new Skill { Name = "Adaptability", Category = SkillCategory.Soft, ProficiencyLevel = 4 }
                },

                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "Personal Shopping Site",
                        Description = "A web application that sells clothing and allows users to buy clothes and track their purchase. Built with ASP.NET MVC and SQL Server, featuring secure user authentication for manager, admin and user.",
                        TechStack = "C#, ASP.NET MVC, SQL Server, Bootstrap, Chart.js",
                        GitHubUrl = "https://github.com/MachakaireAshley/ST10443342_CLDV6212_POE.git",
                        LiveDemoUrl = " abcretailersashley-e8gud4hqe3agcnap.canadacentral-01.azurewebsites.net",
                        DateCompleted = new DateTime(2024, 11, 15),
                        IsFintechRelated = true,
                        KeyFeatures = new List<string>
                        {
                            "User authentication",
                            "Interactive shopping that allows user to scroll through products",
                            "Automated calculation of costs",
                            "Tracking Products to see for approval"
                        }
                    }                    
                },

                Activities = new List<ClubActivity>
                {
                    new ClubActivity { Name = "IT Society", Role = "Active Member", Institution = "IIE MSA/ Emeris University", Type = ActivityType.Club, StartDate = new DateTime(2024, 1, 1) },
                    new ClubActivity { Name = "Toastmasters", Role = "Member", Institution = "Arundel School", Type = ActivityType.Club, StartDate = new DateTime(2021, 1, 1), EndDate = new DateTime(2022, 12, 31) },
                    new ClubActivity { Name = "Volleyball Team", Role = "Player", Institution = "Arundel School", Type = ActivityType.Sport, StartDate = new DateTime(2018, 1, 1), EndDate = new DateTime(2022, 12, 31) }
                }
            };

            return View(viewModel);
        }

        // Add endpoint to download PDF version
        public IActionResult DownloadPdf()
        {
            return View();
        }
    }
}