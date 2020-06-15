using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class TafelStatus
    {
        public int tafelNummer { get; set; } //TafelID
        public bool tafelBezetting { get; set; } //is_Bezet
    }

    public class OrderStatus
    {
        public int tafelNummer { get; set; } //TafelID
        public int bestellingId { get; set; } //BestellingID
        public bool bestellingStatus { get; set; } //is_Gereed

    }
}
