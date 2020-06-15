using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Rekening
    {
        public int ID { get; set; }
        public int KlantID { get; set; }
        public DateTime Datum { get; set; }
        public decimal TotaalPrijs { get; set; }
        public decimal Fooi { get; set; }
        public decimal BTW { get; set; }
    }
}
