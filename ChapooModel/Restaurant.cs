using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class TafelStatus
    {
        public int tafelNummmer { get; set; } //Tafel ID
        public int bestellingId { get; set; } //Bestelling ID
        public bool bestellingStatus { get; set; } //Bestelling Status

    }
}
