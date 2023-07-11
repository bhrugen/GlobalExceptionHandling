using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WhatsWrongAPI.Models
{
    public class Villa
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Comments { get; set; }
        public string?  Description{ get; set; }
        public bool InService { get; set; }
        public bool IsAavailable { get; set; }
        [ValidateNever]
        public ICollection<VillaAmenity> VillaAmenity { get; set; }
        [ValidateNever]
        public ICollection<VillaSpeciality> VillaSpecialities { get; set; }
        [ValidateNever]
        public ICollection<VillaPricing> VillaPricings { get; set; }
        [ValidateNever]
        public ICollection<VillaCategory> VillaCategories { get; set; }

    }



}
