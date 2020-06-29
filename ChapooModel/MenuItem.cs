using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class MenuItem
    {
        public int ID { get; set; }
        public string Beschrijving { get; set; }
        public int Menu { get; set; } 
        public decimal Prijs { get; set; }
        public int typeGerecht { get; set; } //1 = voorgerecht, 2 = hoofdgerecht, 3 = nagerecht, 4 = tussengerecht en 5 = drinken
        public bool IsAlcoholisch { get; set; }

        public decimal BTW
        {
            get
            {
                if (IsAlcoholisch)
                {
                    return Prijs * 0.21M;
                }
                return Prijs * 0.06M;
            }
        }

        public override string ToString()
        {
            return $"{Beschrijving}";
        }
    }
}
