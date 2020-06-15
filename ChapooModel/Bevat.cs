using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Bevat
    {
        public int bestellingID { get; set; }
        public int menuItemID { get; set; }
        public string menuItemBeschrijving { get; set; }
        public int typeGerecht { get; set; }
        public bool is_Gereed { get; set; }
        public string Opmerkingen { get; set; }
        public int Aantal { get; set; }
        public DateTime tijdOpname { get; set; }
    }
}
