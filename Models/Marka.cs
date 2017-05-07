using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AracTescil.Models
{
    public class Marka
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public ICollection<Model> Modeller { get; set; }

        //Marka.Modeller=new Collection<Modeller>();

        public Marka()
        {
            Modeller = new Collection<Model>();
        }
         
    }
}
