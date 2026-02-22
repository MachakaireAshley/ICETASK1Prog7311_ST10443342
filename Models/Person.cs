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
        public string ProfessionalTitle { get; set; } = "Computer Science Student";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "machakaireashley@gmail.com";

        [Display(Name = "Phone 1")]
        public string PhoneNumber1 { get; set; } = "+27 76 876 7229";

        [Display(Name = "Phone 2")]
        public string PhoneNumber2 { get; set; } = "+263 77 142 7848";

        public string Address { get; set; } = "144 Peter Road, Ruimsig, Roodepoort, Johannesburg 1724";

        [Url]
        [Display(Name = "LinkedIn Profile")]
        public string LinkedInUrl { get; set; } = "www.linkedin.com/in/ashley-machakaire-111071382";

        public string Summary { get; set; } = "I am a hardworking student with extensive knowledge of core subject matter. I am meticulous and detail-oriented with excellent observational, organizational, and communication skills. I have proven the ability to enhance operational efficiency through technology exploration and strong interpersonal skills.";
    }
}