using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterSort
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ARRAY OF 0
            int[] array0 = new int[50];
            for (int i = 0; i < array0.Length; i++)
                array0[i] = 0;
            #endregion
            #region REVERSED ARRAY
            int[] ReverseSorted = new int[] { 9, 9, 9, 9, 9, 9, 8, 8, 8, 8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 6, 6, 6, 6, 6, 5, 4, 4, 4, 4, 4, 4, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            #endregion
            #region RANDOM ARRAY
            int[] RandomArray = new int[50];
            for (int i=0; i < RandomArray.Length; i++)
                RandomArray[i] =randNum.Next(0, 10);
            #endregion
            #region SORTED ARRAY
            int[] SortedArray = new int[]   { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9};
            #endregion


            CounterSort(array0);
            Console.WriteLine();

            CounterSort(ReverseSorted);
            Console.WriteLine();

            CounterSort(RandomArray);
            Console.WriteLine();

            CounterSort(SortedArray);
            Console.WriteLine();

            Console.ReadKey();

        }// End of MAIN Method

        private static Random randNum = new Random();
        static void CounterSort (int[] UnsortedArray)
        {
            #region CHECKING IF ARRAY IS SORTED
            bool sortedStatus = true;
            for (int i = 0; i < UnsortedArray.Length; i++)
            {
                if (i + 1 < UnsortedArray.Length)
                {
                    if (UnsortedArray[i + 1] >= UnsortedArray[i])
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
            {

                Console.WriteLine("Data is already sorted.");
                for (int i = 0; i < UnsortedArray.Length; i++)
                {
                        Console.Write(UnsortedArray[i]);
                }
            }
            else
            {
                Console.WriteLine("Data is not sorted.");
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
            }// End of Sorting
            Console.WriteLine();
        } // END of sorting method
      
        
    }//END OF CLASS
}// END OF NAMESPACE
