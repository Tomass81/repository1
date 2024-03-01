using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    public abstract class Baobab : ListStrom
    {
        public Baobab() { }
        ~Baobab() { }

        public override double Vypocet
        {
            get { return Math.PI * Math.Pow(priemer, 2) * vyska; }

        }
    }

}
