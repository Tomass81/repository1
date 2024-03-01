using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    public abstract class Strom : IOrganizmus
    {
        public double vyska;
        public double priemer;
        public double prirastokVyskyZaRok = 0.02;
        public double prirastokSirkyZaRok = 0.0001;
        List<Vetva> vetvy = new List<Vetva>();
        List<Vetva>();
        Dictionary<Coordinate, Vetva>();


        public Strom() { }

        public virtual double Vypocet
        {
            get { return 1.0 * Math.PI * Math.Pow(priemer, 2) * vyska / 3.0; }
        }

        public virtual void Rastie()
        {
            vyska += prirastokVyskyZaRok;
            priemer += prirastokSirkyZaRok;

            Vetva v1 = new Vetva();
            Console.WriteLine("Vyska: {0}\nPriemer: {1}", vyska, priemer);
        }


    }

}