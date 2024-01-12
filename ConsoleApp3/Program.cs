using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, v, k;
            int a;
            Console.WriteLine("Zadajte vysku stromu: ");
            double.TryParse(Console.ReadLine(), out v);
            Console.WriteLine("Zadajte priemer ");
            double.TryParse(Console.ReadLine(), out r);

            /*double V = (1.0 / 3.0 * Math.PI * (r * r) * v);
            Console.WriteLine("Objem stromu: " + V);

            Console.WriteLine("Zadajte pocet konarov: ");
            double.TryParse(Console.ReadLine(), out k);

            for (int i = 0; i < k; i++)
            {
                
            }*/
            Console.WriteLine("Aky strom chcete ratat? \nIhlicnaty - 1 \nBaoba - 2 \nListnaty - 3");
            int.TryParse(Console.ReadLine(), out a);


            if (a == 1)
            {
                Strom strom_ihlicnan = new Strom();
                strom_ihlicnan.vyska = v;
                strom_ihlicnan.priemer = r;
                Console.WriteLine(strom_ihlicnan.Vypocet);

                strom_ihlicnan.Rastie();
                Console.ReadLine();
            }
            else if (a == 2)
            {

                Baobab strom_baoba = new Baobab();
                strom_baoba.vyska = v;
                strom_baoba.priemer = r;
                Console.WriteLine(strom_baoba.Vypocet);

                strom_baoba.Rastie();
                Console.ReadLine();
            }
            else if (a == 3)
            {

                ListnatyStrom listnaty_strom = new ListnatyStrom();
                listnaty_strom.vyska = v;
                listnaty_strom.priemer = r;
                Console.WriteLine(listnaty_strom.Vypocet);

                listnaty_strom.Rastie();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Chybny parameter.");
            }


            Console.ReadKey();

        }
    }
}