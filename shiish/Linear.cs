using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shiish
{
    class Linear : Root
    {
        public Linear(double a, double b) : base(a, b)
        {
        }
        public double x;
        


        public override void Reshenie()
        {
            x = -B / A;
        }
        public override void Print()
        {
            Console.WriteLine(x);
        }
    }
}
