using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransportLinesLib;

namespace ConsoleApp2_withLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable d'environnement CurrentCulture -> en-US pour que la virgule décimale soit en point lorsqu'on convertit un integer en string (appelle à l'api Métro)
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            TransportLineStop tls = new TransportLineStop();
            tls.searchLineStop(5.70, 45.17, 1000);

            Console.WriteLine("Version avec dll");
            foreach (LineStop lStop in tls.lStops)
            {
                Console.WriteLine("Arret : " +lStop.id + " " + lStop.name + " - lignes : ");
                foreach (TransportLine tl in lStop.tlines)
                {
                    Console.WriteLine("     " + tl.id + " " + tl.longName);
                }

            }

            Console.ReadKey();
        }
    }
}
