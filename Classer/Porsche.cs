using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classer
{
    class Porsche
    {
        public string dörrar { get; set;}
        public string knappar { get; set;}
        public string fönster { get; set;}
        public string utskrift { get { return " | Dörrar: " + dörrar + " | Knappar: " + knappar + " | Fönster: " + fönster;} }
            
    }
}
