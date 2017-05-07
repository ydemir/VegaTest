using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracTescil.Models
{
    [Table("Modeller")]
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Ad { get; set; }

        public Marka Marka { get; set; }
        public int MarkaId { get; set; }

        
    }
}
