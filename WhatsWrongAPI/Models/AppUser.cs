using System.ComponentModel.DataAnnotations;

namespace WhatsWrongAPI.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public void PopulateFullName()
        {
            FullName = FirstName + LastName;
        }
    }
}
