using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shiish
{
    abstract class Root
    {
        private double a;
        private double b;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        protected Root(double a, double b)
        {
            A= a;
            B= b;
        }
        public abstract void Reshenie();
        public abstract void Print();

    }
}
