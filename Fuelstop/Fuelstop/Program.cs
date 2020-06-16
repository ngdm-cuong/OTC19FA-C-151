using System;

namespace Fuelstop
{
    class Program
    {
        static void Main(string[] args)
        {
            string gprice, lprice;
            double dgprice, dlprice, canprice;


            Console.WriteLine("Which gas station should be used?");
            Console.WriteLine("");
            Console.WriteLine("The first value entered is price per liter at the Canadian station.");

            Console.WriteLine("The second value entered is the price per gallon at the American station.");
            Console.WriteLine("");

            Console.WriteLine("A decision is made as to which station offers the most economical fuel price.");

            lprice = Console.ReadLine();
            //dlprice = Convert.ToDouble(lprice);

            gprice = Console.ReadLine();
            //dgprice = Convert.ToDouble(gprice);

            



            
                if (!Double.TryParse(gprice ,out dgprice) || !Double.TryParse(lprice, out dlprice))
                {
                    if (!Double.TryParse(gprice, out dgprice))
                        dgprice = 0;
                    if (!Double.TryParse(lprice, out dlprice))
                        dlprice = 0;


                    Console.WriteLine("Please enter the price per Canadian liter: Please enter the price per American gallon: Invalid data entered - 0 recorded for price");
                    Console.WriteLine();
                    Console.WriteLine("	Which station has the best fuel prices?");
                    Console.WriteLine("");
                    Console.WriteLine("American Station - Price per gallon: {0:C}", dgprice);
                    Console.WriteLine("Canadian Station - Price per liter: {0:C}", dlprice);
                    canprice = dlprice * 3.785;
                    Console.WriteLine("Canadian liter converted to price per gallon: {0:C}", canprice);
                    Console.WriteLine("");
                    Console.WriteLine("");


                    Console.WriteLine("Zero price cannot be used for comparison");
            }
                    
                    
                else
                {
                    dlprice = Convert.ToDouble(lprice);
                    dgprice = Convert.ToDouble(gprice);


                    Console.WriteLine("Please enter the price per Canadian liter: Please enter the price per American gallon: ");
                    Console.WriteLine("	Which station has the best fuel prices?");
                    Console.WriteLine("");
                    Console.WriteLine("American Station - Price per gallon: {0:C}", dgprice);
                    Console.WriteLine("Canadian Station - Price per liter: {0:C}", dlprice);
                    canprice = dlprice * 3.785;
                    Console.WriteLine("Canadian liter converted to price per gallon: {0:C}",canprice );
                    Console.WriteLine("");
                    Console.WriteLine("");
            
                    if (dgprice < canprice)
                        Console.WriteLine("Buy from the American station!");
                    else 
                         Console.WriteLine("Buy from the Canadian station!");
                 }
                    

            Console.ReadLine();

            

        }
    }
}
