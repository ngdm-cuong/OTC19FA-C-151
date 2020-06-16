using System;
using static System.Console;

public class UI
{
    // instance variables (class fields)
    public static int[] myInts;
    // instance properties (getter/setter)
    public static int[] MyInts { get { return myInts; } }

    public static void InputNumEntries()
    {
        int noEntries;
        Write("How many entries would you like: ");
        while (int.TryParse(ReadLine(), out noEntries) == false)
        {
            Write("\nInvalid input...");
            Write("\nHow many entries would you like: ");
        }  // end of while
        myInts = new int[noEntries];
    }  // end of method


    public static void GatherInput()
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

    public static void WriteOutput()
    {
        for (int n = 0; n < myInts.Length; n++)
        {
            WriteLine("Value {0} is {1}", n + 1, myInts[n]);
        }  // end of for
    }  // end of method

}  // end of class