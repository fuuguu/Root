using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shiish
{
    class Square : Root
    {
        public Square(double a, double b, double c) : base(a, b)
        {
            c = c;
        }
        public double x;
        public double y;
        public double c;
        public double C
        {
            get { return c; }
            set { c = value; }
        }




        public override void Reshenie()
        {
            double d;
            d = Math.Pow(B, 2) - 4 * A * C;
            if (d < 0) Console.WriteLine("нет решения");
            else if (d == 0) x = (-B + Math.Sqrt(d));
            else if (d > 0) x = (-B - Math.Sqrt(d)) / 2 * A;
            else if (d > 0) y = (-B + Math.Sqrt(d)) / 2 * A;
        }
        public override void Print()
        {
            Console.WriteLine("x=" + x + " " + "y=" + y);
        }
    }
}
