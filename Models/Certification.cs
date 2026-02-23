using System.ComponentModel.DataAnnotations;

namespace MyCVApp.Models
{
    public class Certification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Issuer { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Date Obtained")]
        public DateTime DateObtained { get; set; }

        [Url]
        [Display(Name = "Credential URL")]
        public string? CredentialUrl { get; set; }
    }
}