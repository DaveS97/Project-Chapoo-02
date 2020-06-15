using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Bon
    {
        public int klantID { get; set; }
        public decimal Prijs { get; set; }
        public string Omschrijving { get; set; }
        public int Aantal { get; set; }
        public bool Alcoholisch { get; set; }
        public int BedienerID { get; set; }

    }
}
