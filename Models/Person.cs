using System.ComponentModel.DataAnnotations;

namespace MyCVApp.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "Ashley Spiwe Machakaire";

        [Display(Name = "Professional Title")]
        public string ProfessionalTitle { get; set; } = "Bachelor of computer and information sciences in Application Development | Aspiring FinTech Developer";

        [Display(Name = "Short Tagline")]
        public string Tagline { get; set; } = "Building secure, scalable financial technology solutions";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "machakaireashley@gmail.com";

        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; } = "+27 76 876 7229"; // Added this for single phone display

        [Display(Name = "Phone 1")]
        public string PhoneNumber1 { get; set; } = "+27 76 876 7229";

        [Display(Name = "Phone 2")]
        public string PhoneNumber2 { get; set; } = "+263 77 142 7848";

        public string Address { get; set; } = "144 Peter Road, Ruimsig, Roodepoort, Johannesburg 1724";

        [Url]
        [Display(Name = "LinkedIn Profile")]
        public string LinkedInUrl { get; set; } = "https://linkedin.com/in/ashley-machakaire-005a82362";

        [Url]
        [Display(Name = "GitHub Profile")]
        public string GitHubUrl { get; set; } = "https://github.com/yourusername";

        public string Location { get; set; } = "Johannesburg, South Africa";

        public string Summary { get; set; } = "I'm a final-year Computer Science student passionate about leveraging technology to solve financial challenges. I enjoy building secure, scalable applications that make financial services more accessible. Currently exploring blockchain, payment gateways, and financial data visualization.";

        public string AboutMe { get; set; } = "I'm a detail-oriented Computer Science student at Emeris with a passion for fintech innovation. My interest lies in how technology can democratize financial services and create inclusive economic opportunities. I combine strong technical fundamentals with meticulous attention to security and user experience — qualities essential in financial technology. When I'm not coding, I'm exploring emerging trends in digital banking, attending fintech webinars, or contributing to open-source projects.";
    }
}