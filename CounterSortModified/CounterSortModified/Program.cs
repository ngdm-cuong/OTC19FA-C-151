using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterSortModified
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int k =0; k< 1000; k++)
            {
                int[] sortedArray = new int [100000];
                int[] RandomArray = new int [100000];
                for (int i = 0; i < RandomArray.Length; i++)
                    RandomArray[i] = randNum.Next(0, 10);
                sortedArray = CounterSort(RandomArray);
                Console.WriteLine();
                #region CHECKING IF ARRAY IS SORTED
                bool sortedStatus = false;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    if (i + 1 < sortedArray.Length)
                    {
                        if (sortedArray[i + 1] >= sortedArray[i])
                            sortedStatus = true;
                        else
                        {
                            sortedStatus = false;
                            break;
                        }
                    }

                }// END CHECKING
                #endregion
                if (sortedStatus == true)
                    Console.WriteLine("Array is successfully sorted");
                else
                    Console.WriteLine("Array is NOT successfully sorted");
            }



            Console.ReadKey();
        }// End of MAIN Method
        private static Random randNum = new Random();
        static int[] CounterSort(int[] UnsortedArray)
        {
            int[] sortedArray = new int[UnsortedArray.Length];
                Console.WriteLine("Sorting...");
                int[] counterArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                for (int i = 0; i < UnsortedArray.Length; i++)
                {
                    for (int j = 0; j < counterArray.Length; j++)
                    {
                        if (UnsortedArray[i] == j)
                        {
                            counterArray[j]++;
                            break;
                        }
                    }
                }

                // Print out sorted Array

                for (int i = 0; i < counterArray.Length; i++)
                {
                    for (int k = 0; k < counterArray[i]; k++)
                    {
                        Console.Write(i);
                    }
                }
            // End of Sorting
            Console.WriteLine();
            return sortedArray;
        } // END of sorting method


    }// END of class
}// End of namespace
