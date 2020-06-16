using System;
using static System.Console;

/// put your header comment here

class MainClass
{
    // instance variables (class fields)
    static int[] myInts;                            // declare the array
    public static void Main(string[] args)
    {


        Write("How many entries would you like: ");
        int noEntries = Convert.ToInt32(ReadLine());

        // allocate the array with the requested number of entries
        myInts = new int[noEntries];

        // run the gather input method to gather input
        GatherInput();

        // output the array values
        WriteOutput();
    }  // end of Main

    static void GatherInput()
    {
        int val;
        for (int n = 0; n < myInts.Length; n++)                   // 0 is the beg of array, use length to stop loop
        {
            Write("Please enter value number {0}", n + 1);
            while (int.TryParse(ReadLine(), out val) == false)       // is the readline input a valid integer?
            {
                Write("Please enter a valid integer for value number {0}", n + 1);
            }  // end of while
               // ok, we have valid input, so load it into the array
            myInts[n] = val;
        }  // end of for
    }  // end of method


    static void WriteOutput()
    {
        for (int n = 0; n < myInts.Length; n++)
        {
            WriteLine("Value {0} is {1}", n + 1, myInts[n]);
        }
    }
}  // end of class4