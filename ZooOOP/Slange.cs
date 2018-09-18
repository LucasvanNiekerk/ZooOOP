using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZooOOP
{
    class Slange: Dyr
    {
        private bool farlig = true;

        public Slange()
        {
            if (farlig == true)
            {
                Console.WriteLine("Åhhh nej en farlig slange!");
                Console.WriteLine("Ahh den bed mig - Jeg døøøør!!");
            }
            else
            {
                Console.WriteLine("Ej en sød og dejlig slange");
            }
        }
        public void SlangeSig()
        {
            Console.WriteLine("Slangen snor sig rundt omkring");
        }
    }
}
