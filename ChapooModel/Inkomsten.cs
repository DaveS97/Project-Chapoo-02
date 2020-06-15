using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Inkomsten
    {
        public int BonID { get; set; } 
        public int BedienerID { get; set; } 
        public double Fooi { get; set; } 
        public double BTW { get; set; } 
        public double Totaal { get; set; } 
    }
}
