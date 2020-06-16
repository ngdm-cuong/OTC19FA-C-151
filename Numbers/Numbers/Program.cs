using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2;
            Console.WriteLine("Please enter the first number: ");
            //num1 = Console.ReadLine();
            //Convert.ToInt32(num1);
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            //num2 = Console.ReadLine();
            //Convert.ToInt32(num2);
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The first number was: {0}", num1);
            Console.WriteLine("The second number was: {0}", num2);
            Console.WriteLine("------------------------------");

            //Calculating
            int sum, diff, product, rem;
            float quot, average;

            sum = num1 + num2;
            diff = num1 - num2;
            product = num1 * num2;
            quot = num1 / num2;
            rem = num1 % num2;
            average = (num1 + num2) / 2;

            //Output
            Console.WriteLine("The sum = {0}", sum);
            Console.WriteLine("The difference = {0}", diff);
            Console.WriteLine("The product = {0}", product);
            Console.WriteLine("The quotient = {0}", quot);
            Console.WriteLine("The remainder = {0}", rem);
            Console.WriteLine("The average = {0}", average);
            Console.ReadLine();

            

    
        }
    }
}
