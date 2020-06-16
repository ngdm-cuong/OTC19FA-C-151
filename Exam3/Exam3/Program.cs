using System;
using static System.Console;

namespace Exam3
{
    class Program
    {
        /// <summary>1
        ///     Main program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Declare Variable 
            Player[] ArrayPlayer; // Array is declared 
            ArrayPlayer = new Player[5];
            string name;
            int strengths;
            string ans;
            int counter = 0;
            DisplayIntstruction();
            int count = 0;
            int max = 0, min = 50, total = 0;
            string strongest = "", weakest = "";
            double avg;

            Player player1 = new Player();
            #endregion
            #region Creating an array of Object
            do
            {
                name = InputName();
                strengths = InputStrengths(name);
                // create an instance
                Player NewPlayer = new Player();
                NewPlayer.Name = name;
                NewPlayer.Strengths = strengths;
                ArrayPlayer[counter] = NewPlayer;// assign object to ArrayPlayer array
                WriteLine("Do you want to continue?");
                WriteLine("'Y' = Yes");
                ans = ReadLine();
                counter++;
            }
            while (ans == "y" || ans == "Y");
            #endregion
            #region Max, Min, Total
            for (int i = 0; i < counter; i++)
            {
                string name1 = ArrayPlayer[i].Name;
                int strength = ArrayPlayer[i].Strengths;


                if (strength > max)
                {
                    max = strength;
                    strongest = name1;

                }
                if (strength < min)
                {
                    min = strength;
                    weakest = name1;
                }
                total += strength;

            }// OUT of foreach loops
            #endregion
            WriteLine($"total : {total}........ counter: {counter}"); // For Testing
            avg = total / (double)counter;
            Clear();
            DisplayOutput(avg, max, min, strongest, weakest, ArrayPlayer);

            ReadKey();
        }// END of main

        static void DisplayIntstruction()
        {
            WriteLine("You will be prompt to enter the number of players and their score + their strength");
        }
        /// <summary>
        /// Purpose: Get user'sname
        /// </summary>
        /// <returns></returns>
        static string InputName()
        {
            Write("Enter the name: ");
            return ReadLine();
        }// END of Input Name

        /// <summary>
        /// Get player strength and validate
        /// </summary>
        /// <param name="playersname"></param>
        /// <returns></returns>
        static int InputStrengths(string playersname)
        {
            string tempStr;
            int tempInt = 0, test = 0;
            Write($"Enter {playersname}'s strengths score ( Score must be in the range of 0 and 50): ");
            tempStr = ReadLine();
            test = 0;
            while (test == 0)
            {
                if (!int.TryParse(tempStr, out tempInt))
                {
                    Write("\nInvalid input.");
                    Write($"\nRe-Enter {playersname}'s strengths score: ");
                    test = 0;
                    tempStr = ReadLine();

                }
                else
                {

                    if (tempInt < 0 || tempInt > 50)
                    {
                        WriteLine($"You just entered {tempInt}, which is out of range ");
                        Write($"Enter {playersname}'s strengths score ( Score must be in between 0 and 50): ");
                        test = 0;
                        tempStr = ReadLine();
                    }
                    else
                    {
                        test = 1;
                    }
                }
            }
            return (tempInt);
        }// End of Inputstrength
        /// <summary>
        ///     Purpose: Display Output
        /// </summary>
        /// <param name="avg"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="strongest"></param>
        /// <param name="weakest"></param>
        /// <param name="ArrayPlayer"></param>
        static void DisplayOutput(double avg, int max, int min, string strongest, string weakest, Player[] ArrayPlayer)
        {
            WriteLine("----- Player List ----");
            foreach (var item in ArrayPlayer)
            {
                Write(item);
            }
            WriteLine($"Average strength: {avg:f1}\nStrongest: {strongest} at {max}\nWeakest: {weakest} at {min}");
        }
    }//End of program class.
}
