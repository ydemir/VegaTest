using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AracTescil.Models
{
    public class Marka
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Ad { get; set; }

        public ICollection<Model> Modeller { get; set; } 

        public Marka()
        {
            Modeller = new Collection<Model>();
        }
         
    }
}
