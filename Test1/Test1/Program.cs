using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fold1 = 1, fold2 = 1;
            var newFold = fold1 + fold2;
            string strn;
            int n;
            WriteLine("Welcome to the Bunny fold size estimator");
          
            WriteLine("How many generations would you like to estimate? (-1 to quit): ");
            strn = ReadLine();
            bool b = int.TryParse(strn, out n); ;


            while (n != -1)
            {
                if (b)
                {

                    for (int i = 1; i < n; i++)
                    {
                        fold2 = fold1;
                        fold1 = newFold;
                        newFold = fold1 + fold2;



                    }
                    WriteLine("The fold size estimate is {0} after {1} generations", newFold, n);
                    WriteLine("...");
                    WriteLine("How many generations would you like to estimate? (-1 to quit): ");
                    
                    strn = ReadLine();
                    b = int.TryParse(strn, out n); ;


                }


                else
                {
                    WriteLine("Invalid input. Generations set to 0.");
                    WriteLine("The fold size estimate is 0 after 0 generations");
                    WriteLine("...");
                    WriteLine("How many generations would you like to estimate? (-1 to quit): ");
                    WriteLine();
                    strn = ReadLine();
                    b = int.TryParse(strn, out n); ;
                }

            }

            
            ReadLine();
        }   
    }
}
