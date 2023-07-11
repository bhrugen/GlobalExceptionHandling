using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WhatsWrongAPI.Models
{
    public class VillaAmenity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Villa")]
        public int VillaId { get; set; }

        [ValidateNever]
        public Villa Villa { get; set; }

        public string Name { get; set; }
        public double AmenityRating { get; set; }


    }
}
