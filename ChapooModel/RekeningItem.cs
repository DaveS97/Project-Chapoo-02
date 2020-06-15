using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class RekeningItem
    {
        public int ID { get; set; }
        public int RekeningID { get; set; }
        public int MenuItemID { get; set; }
        public int Aantal { get; set; }
        public string Omschrijving { get; set; }
        public decimal Prijs { get; set; }
    }
}
