using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Strom
    {
        public Strom() { }
        ~Strom() { }
        public double Volume
        {
            get { return V = Math.PI * (r * r) * v;  }
        }

        protected double r;
        protected double v;
        protected double V;
    }
    class Baobab : Strom
    {
        public double Volume
        {
            get { return V = Math.PI * (r * r) * v; }
        }
        protected double r;
        protected double v;
        protected double V;
    }
    class Ihlicnan : Strom 
    {
        public double Volume
        {
            get { return V = Math.PI * (r * r) * v; }
        }
        protected double r;
        protected double v;
        protected double V;
    }
}
