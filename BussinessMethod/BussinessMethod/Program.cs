using System;
using static System.Console;


namespace BussinessMethod
{
    /// <summary>
    /// Name: Cuong Nguyen
    /// Date: 02/24/2019
    /// purpose: 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Purpose: Display instruction
        /// </summary>
        private static void DisplayInstruction() {
            WriteLine("Welcome to the Business List");
            WriteLine("Business List for Springfield");
            WriteLine();
        }
        /// <summary>
        ///     purpose: Display the number of people and ask if user want to continue.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static string DisplayOutput(string a, int b) {
            WriteLine("{0} employs {1:n0} people",a,b);
            Write("Enter another (Y/N?): ");
            string choose;
            choose = ReadLine();
            return (choose);
        }
        /// <summary>
        ///  Purpose: Inform and require users to enter data and then validate them.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static int InputEmployees(string a) {
            WriteLine("How many people does {0} employ? ",a);
            string strEmployees = ReadLine();
            int intEmployees;
            while (!int.TryParse(strEmployees, out intEmployees))
                {
                    WriteLine("Invalid value. Please re-enter.");
                    WriteLine("How many people does {0} employ? ", a);
                    strEmployees = ReadLine();
            }

            return (intEmployees);
        }
        /// <summary>
        /// purpose ask for name of business and then validate it.
        /// </summary>
        /// <returns></returns>
        private static string InputName() {
            WriteLine("What is the business name? ");
            string strInputname = ReadLine();
            int i;
            while (int.TryParse(strInputname, out i))
                {
                WriteLine("Invalid value. Please re-enter.");
                WriteLine("What is the business name? ");
                strInputname = ReadLine();
            }
                
            return (strInputname);
        }
        /// <summary>
        ///     Main function, call the other functions and then keep it looped
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
            DisplayInstruction();
            string name = InputName();
            int employees = InputEmployees(name);
            string choose= DisplayOutput(name, employees);             
            while ( choose == "y")
            {
                DisplayInstruction();
                name = InputName();
                employees = InputEmployees(name);
                choose = DisplayOutput(name, employees);
            }


        }
    }   
}
