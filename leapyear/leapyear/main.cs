using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace leapyear
{
    class main
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int year;
            bool d4, d100, d400;
            year = DisplayInstruction();
            while (year != -1)
            {
                WriteLine($"Year entered: {year}");
                d4 = Divisableby4(year);
                d100 = Divisableby100(year);
                d400 = Divisableby400(year);
                evaluating(d4, d100, d400);
                year = DisplayInstruction();
            }
            

            
        }// End Main
        /// <summary>
        /// Inform user to input the year or -1 to quit and verify if user input the right format
        /// return turn year as number
        /// </summary>
        /// <returns></returns>
        static int DisplayInstruction()
        {
            int year;
            string strYear;
            WriteLine("Please enter a year (-1 to quit): ");
            strYear = ReadLine();
            while (!int.TryParse(strYear, out year))
            {
                WriteLine("Invalid input. Please enter a year (-1 to quit): ");
                strYear = ReadLine();
            }
            return (year);    
        }//End Display Instruction

        /// <summary>
        ///  check if the year is divisable by 4
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static bool Divisableby4(int year)
        {
            if (year % 4 == 0)
            {
                WriteLine("Divisible by 4: Yes");
                return true;
            }
                
            else
            {
                WriteLine("Divisible by 4: No");
                return false;
            }
                
        } // End 4
        /// <summary>
        ///     check if the year is divisable by 100
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static bool Divisableby100(int year)
        {
            if (year % 100 == 0)
            {
                WriteLine("Divisible by 100: Yes");
                return true;
            }

            else
            {
                WriteLine("Divisible by 100: No");
                return false;
            }
        }// End 100
        /// <summary>
        /// check if the year is divisable by 400
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static bool Divisableby400(int year)
        {
            if (year % 400 == 0)
            {
                WriteLine("Divisible by 400: Yes");
                return true;
            }

            else
            {
                WriteLine("Divisible by 400: No");
                return false;
            }
        }// End 400
        /// <summary>
        /// evaluate and print out if the year inputed is leap year
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void evaluating (bool a, bool b, bool c)
        {
            if (a == true && b == true && c == true)
                WriteLine("Leap year: Yes");
            else if (a == true && b == true && c == false)
                WriteLine("Leap year: No");
            else if (a == true && b == false && c == false)
                WriteLine("Leap year: Yes");
            else if (a == false && b == false && c == false)
                WriteLine("Leap year: No");
            
        }
    } // End Class
}


