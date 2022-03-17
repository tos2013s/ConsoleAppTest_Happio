using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest_Happio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r");
            Console.WriteLine("\tHappio: Console Calculator in C#\n");
            Console.WriteLine("------------------------------------------------------\n");
            initialStart();
            bool endApp = false;
            // Display title as the C# console calculator app.

            while (!endApp)
            {
                // Declare variables and set to empty.
                // Ask the user to type the second number.
                Console.Write("Your option? press Enter: ");
                string op = Console.ReadLine();
                // Declare variables and set to empty.
                try
                {
                    if (op == "Q1")
                    {                       
                        Calculator.Q1_input4();
                    }
                    if (op == "Q2")
                    {
                        Calculator.Q2_input();
                    }
                    if (op == "Q3")
                    {
                        Calculator.Q3_input();
                    }
                    Console.WriteLine("\n");
                    initialStart();
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
                // Ask the user to type the first number.
                //Console.WriteLine("Q1 : input 4 in C#\r");
                //Console.WriteLine("**********************\r");
                //Console.Write("Type a number, and then press Enter: ");

                //Q1_input4 = Console.ReadLine();
                //Console.WriteLine("------------------------\n");

                //Console.WriteLine("Q1 : input 5 r in C#\r");
                //Console.WriteLine("**********************\r");
                //Console.Write("Type a number, and then press Enter: ");
                //Q1_input5 = Console.ReadLine();
                //Console.WriteLine("------------------------\n");

                //Console.WriteLine("**********************\r");
                //Console.WriteLine("Q1 : input 6  in C#\r");
                //Console.WriteLine("------------------------\r");
                //Console.Write("Press Enter to continue... ");
                //Q1_input6 = Console.ReadLine();
                //Console.WriteLine("------------------------\n");

                //Console.WriteLine("**********************\r");
                //Console.WriteLine("Q3 : Enter  in C#\r");
                //Console.WriteLine("------------------------\r");
                //Console.Write("Press Enter to continue...");
                //Q3_input = Console.ReadLine();
                //Console.WriteLine("------------------------\n");

                //Console.Write("Press Enter to exit...[y/n] : ");
                //var line = "";
                //line = Console.ReadLine();
                //if (line == "y")
                //{
                //    Environment.Exit(0);
                //}
            }
            return;
        }
        public static void initialStart()
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\r");
            Console.WriteLine("\tEnter : Q1 = Input number 4,5,6");
            Console.WriteLine("\tEnter : Q2 = Input THB currency");
            Console.WriteLine("\tEnter : Q3 = Inout Gas Liter ");
            Console.WriteLine("\n");
        }
    }
}
