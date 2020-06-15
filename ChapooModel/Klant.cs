using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Klant
    {
        public int ID { get; set; }
        public int tafelID { get; set; }
        public string betaalWijzeType { get; set; } 
        public int reserveringID { get; set; }
        public int RekeningID { get; set; }
    }
}
