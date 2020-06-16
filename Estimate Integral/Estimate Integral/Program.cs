using System;
using static System.Console;

namespace Estimating_Integral
{
    class Program
    {
        static void Main(string[] args)
        {
            double deltax;
            double a, b;
            int n;
            string astr, bstr, nstr;
            double trpzd, midpt, simps;
            
            WriteLine("Enter Equation: ");
            

            Write("Lower bound a: ");
            astr = ReadLine();
            a = Convert.ToDouble(astr);

            Write("Upper bound b: ");
            bstr = ReadLine();
            b = Convert.ToDouble(bstr);

            

            Write("Enter n: ");
            nstr = ReadLine();
            n = Convert.ToInt16(nstr);

            deltax = (Math.Abs(a-b)) / n;
            WriteLine("Delta X: " + deltax);

            // Simpson's rule section
             simps = Fx(a) + Fx(b);  // sim = first and last value

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                    simps = simps + 2 * Fx(a + i * deltax);
                else
                    simps = simps + 4 * Fx(a + i * deltax);
            }
            simps = simps * deltax / 3;

            WriteLine("Simpson's Rule: {0}", simps);
            // End Simpson's rule
          
            //Trapezoid section
            trpzd = Fx(a) + Fx(b); // trapezoid = first and last value
            for (int i = 1; i < n; i++)
            {
                trpzd = trpzd + 2 * Fx(a + i * deltax);
            }
            trpzd = trpzd * deltax / 2;

            WriteLine("Trapezoid: {0}", trpzd);

            //END Trapezoid

            // Midpoint section
            midpt = Fx(a + (deltax / 2));
            for (int i = 1; i < n; i++)
            {
                midpt = midpt + Fx(a+(deltax / 2) + deltax * i);
            }

            midpt = midpt * deltax;

            WriteLine("Midpoint: {0}", midpt);

            ReadLine();
        }

        public static double Fx(double x)
        {

            double myfx = 0;
            // myfx = Math.Sqrt(Math.Pow(x, 3) - 8);

            myfx = (Math.Pow(Math.E,x) )/ (8 + Math.Pow(x,2));

            
    
            return (myfx);

        }
    }
}
