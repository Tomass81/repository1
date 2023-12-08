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
            

            Console.WriteLine("Zadaj radius: ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj vysku: ");
            v = double.Parse(Console.ReadLine());

            V = ((Math.PI / 3) * (r * r) * v);
            Console.WriteLine("Objem je: " + V);

            Console.ReadKey();  
        }
    }
}
