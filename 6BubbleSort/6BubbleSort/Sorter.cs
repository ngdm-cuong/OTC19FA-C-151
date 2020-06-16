using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6BubbleSort
{
    class Sorter
    {
        private static Random randomNum = new Random();
        public static int[] BubbleSort(int[] data)
        {
            int next;
            int inner;

            for (next = 0; next < data.Length; next++)
            {
                for (inner = 0; inner < data.Length - next - 1; inner++)
                {
                    if (data[inner] > data[inner + 1])
                    {
                        //swap  variables
                        int temp = data[inner];
                        data[inner] = data[inner + 1];
                        data[inner + 1] = temp;
                    }
                }
                Console.WriteLine($"Printing Pass{next}");
                PrintArray(data);
            }// end of for loop
            return data;
        }
        /// <summary>
        /// satic method requres no instance 
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int[] LoadArray(int size)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = randomNum.Next(0, 100);
            }
            return data;
        }// end of method
        public static void PrintArray(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                } // end of if
                Console.Write(data[i] + " ");
            }// end of for
        }// end of method
    }
}
