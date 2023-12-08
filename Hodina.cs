using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            double v;
            double V;
            double celkovy = 0;


           /* Console.WriteLine("Zadaj radius: ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj vysku: ");
            v = double.Parse(Console.ReadLine());

           for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Zadaj radius: ");
                r = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadaj vysku: ");
                v = double.Parse(Console.ReadLine());
                V = ((Math.PI / 3) * (r * r) * v);
                celkovy = V + celkovy;
                Console.WriteLine("Objem je: " + V);
            }
            Console.WriteLine("Celkovy objem: " + celkovy);

            V = ((Math.PI / 3) * (r * r) * v);
            Console.WriteLine("Objem je: " + V); */

            Strom strom1 = new Strom();
            strom1.r = 5;
            strom1.v = 6;
            Console.WriteLine("Volume: " + strom1.Volume);

            

            Console.ReadKey();  
        }
    }
}
