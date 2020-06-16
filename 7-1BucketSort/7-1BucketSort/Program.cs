using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] theData = BucketSort.LoadArray(100);
            BucketSort.PrintArray(theData);

            theData = BucketSort.Sort(theData);
            BucketSort.PrintArray(theData);

            Console.ReadKey();
        }
    }
}
