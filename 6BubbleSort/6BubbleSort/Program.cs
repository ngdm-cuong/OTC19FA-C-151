using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theData = Sorter.LoadArray(20);
            Sorter.PrintArray(theData);

            theData = Sorter.BubbleSort(theData);
            Sorter.PrintArray(theData);

            Console.ReadKey();
        }
    }
}
