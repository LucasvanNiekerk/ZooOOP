using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooOOP;

namespace zooOOP
{
    class Hest: Dyr
    {
        //maxhastighed måles i km/t
        public double maxHastighed;


        public Hest()
        {
            Console.WriteLine("Indtast venligst hestenavn:");
            navn = Console.ReadLine();
            Console.WriteLine("Hestens fødselsår?");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor hurtig er hesten?");
            maxHastighed = Convert.ToDouble(Console.ReadLine());

        }

        private void Eat()
        {
            Console.WriteLine("Gnaske gnaske... Hva glor du på jeg spiser!");
        }

        public void Run()
        {
            if (year >= 1)
            {
                 Console.Write("Weeeeee");
            }

            if (year < 1)
            {
                Console.WriteLine("Wrinske wrinske");
            }
           
            Console.WriteLine(" - med " + maxHastighed + " km/t");
            Console.WriteLine("Hesten hedder " + navn + ".");
            Console.WriteLine("Hesten er " + (2018 - year) + "år gammel");
            Eat();
            Console.WriteLine("");
        }
    }
}