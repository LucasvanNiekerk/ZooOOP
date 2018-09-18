using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooOOP
{
    // Super-klassen alle dyr arver fra.... (public of protected)
    class Dyr
    {
        public String navn;
        public int year;
        protected bool tam;

        public bool Tam
        {
            get { return tam; }
            set
            {
                if (tam == true) tam = true; //hvis tam er true vil den altid fremad være true uanset hvad.
                if (tam == false) tam = value; 
            }
        }
    }
}
