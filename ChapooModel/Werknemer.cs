using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Werknemer
    {
        public int ID { get; set; }
        public int Type { get; set; } // 1=  bediener 2= barman  3= kok  4= eigenaar
        public string Naam { get; set; }
        public int PIN { get; set; }
    }
}
