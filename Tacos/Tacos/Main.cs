using System;

class MainClass
{

    static TacoPrice thisRun;                   // declare an instance of the TacoPrice class
    const string DOLLAR = "Dollar";
    const string LOONIE = "Loonie";

    public static void Main(string[] args)
    {
        double ppDollar, ppLoonie;

        DisplayInstructions();
        ppDollar = GetInput(DOLLAR);
        ppLoonie = GetInput(LOONIE);

        thisRun = new TacoPrice(ppDollar, ppLoonie);    // instantiage the instance of the TacoPrice class
        Console.WriteLine(thisRun);               // use the ToString method of the TacoPrice class to print info
    }  // end of Main

    static decimal GetInput(string whichOne)
    {
        decimal price;
        Console.WriteLine("Please enter the {0} price per taco ", whichOne);
        if (decimal.TryParse(Console.ReadLine(), out price) == false)
            Console.WriteLine("Invalid data entered - 0 recorded for price");
        return price;
    }

    static void DisplayInstructions()
    {
        Console.WriteLine("Make a Run for the Border!");
        Console.WriteLine();
        Console.WriteLine("Which side of the border has the best taco prices?");
        Console.WriteLine("The first value entered is the dollar price of a Taco in America.");
        Console.WriteLine("The second value entered is the loonie price of a Taco in Canada.");
        Console.WriteLine();
        Console.WriteLine("A decision is made as to which side of the border has the most economical tacos.");
    }  // end of DisplayInstructions
} // end of MainClass