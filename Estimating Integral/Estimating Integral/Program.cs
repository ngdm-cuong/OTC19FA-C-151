using System;
using static System.Console;

namespace Estimating_Integral
{
    class Program
    {
        static void Main(string[] args)
        {
            double fx = 0, deltax ;
            int n;
            int a, b;
            WriteLine("Enter Equation: ");
            fx = ;
            Write("Upper bound a: ");
            a = ReadLine();
            Write("Lower bound a: ");
            b = ReadLine();
            Write("Enter n :");
            n = ReadLine();
            deltax = (a - b) / n;
            Write("Delta X:",deltax);

            WriteLine("Trapezoid");
            WriteLine("Midpoint");
            WriteLine("Simpson's");
        }
    }
}
