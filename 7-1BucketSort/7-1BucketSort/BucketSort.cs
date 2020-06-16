using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1BucketSort
{
    class BucketSort
    {
        private static Random randomNum = new Random();
       // private static int [] bucket = new int[9];
        private static int cols =12; // WIll also be size of the LoadArray
        private static List<int>[] bucket = new List<int>[10];


        public static int [] Sort( int [] data)
        {
            for (int i = 0; i <10; i++)
            {
                bucket[i] = new List<int>();
            } // Create arrays of lists
            for (int i = 0; i < data.Length; i++)
               
            {
                int lastDigist = data[i] % 10;
                bucket[lastDigist].Add(data[i]);
            }
            // Gathering below

            int k = 0;

                    foreach ( int temp in bucket[k])
                    {
                        for (int i = k; i < data.Length; i++)
                        {
                            data[i] = temp;

                            k = i+1;
                            break;
                            
                        }
                     }


            return data;
            
            
        }// End of SORT

        public static int[] LoadArray(int size)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = randomNum.Next(0, 100);
            }
            return data;
        }// end of LoadArray

        public static void PrintArray(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {

                Console.Write(data[i] + " \t");
            }// end of for
            Console.WriteLine();
            //TwoDArray(rows, cols);
        }// end of method


        public static void TwoDArray(int rows, int cols)
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    //Console.Write("{0}\t", bucket[i, j]);
                }
                Console.WriteLine();
            }
        }

    }// End of class
}//End of NameSpace
