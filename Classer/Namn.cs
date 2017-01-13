using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classer
{
    class Namn
    {
        public string förnamn { get; set; }
        public string efternamn { get; set; }
        public string utskrift { get { return förnamn + " " + efternamn; } }
        public string datum { get; set; }
        public int ÅlderCheck(int född)
        {
            if(2017 - född < 18)
            {

            }
            else
            {
                return 0;
            }
            return 0;
        }
    }
}
