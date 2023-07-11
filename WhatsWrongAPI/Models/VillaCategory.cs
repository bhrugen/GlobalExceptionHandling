using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WhatsWrongAPI.Models
{
    public class VillaCategory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Villa")]
        public int VillaId { get; set; }

        public Villa Villa { get; set; }

        public string CategoryName { get; set; }


    }
}
