using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WhatsWrongAPI.Models
{
    public class VillaAmenityVM
    {
        public VillaAmenity? VillaAmenity { get; set; }
        [ValidateNever]
        public SelectList? VillaList { get; set; }
    }
}
