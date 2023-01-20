using shiish;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Linear linear = new Linear(0,0);
            linear.A = Convert.ToDouble(Console.ReadLine());
            linear.B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x = "+linear.x);


        }
    }
}