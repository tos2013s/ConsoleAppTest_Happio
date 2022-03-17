using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest_Happio
{
    class Calculator
    {
        public static void Q1_input4()
        {
            // Ask the user to type the first number.
            Console.Write("Type a number, and then press Enter: ");
            //double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.
            int a ;
            int.TryParse(Console.ReadLine(), out a);
            for (int i = 1; i <= a - 1; i++)
            {
                for (int j = 1; j <= (a - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Q2_input()
        {
            int thb;
            Console.WriteLine("Q2: \r");
            Console.Write("Input THB currency : ");
            int.TryParse(Console.ReadLine(), out thb);
            double won = 33.72;
            double usd = 0.028;
            double yen = 3.4;

            double currency_won = (double)thb * won;
            double currency_usd = (double)thb * usd;
            double currency_yen = (double)thb * yen;
            Console.WriteLine("------------------------\r");
            Console.WriteLine("Output is : {0} WON",currency_won.ToString("0.00"));
            Console.WriteLine("Output is : {0} USD", currency_usd.ToString("0.00"));
            Console.WriteLine("Output is : {0} YES", currency_yen.ToString("0.00"));
            Console.WriteLine("------------------------\n");

        }
        public static void Q3_input()
        {
            int gas_liter;
            float km = 0.00001f;
            Console.WriteLine("Q3: \r");
            Console.Write("Inout Gas Liter :");
            int.TryParse(Console.ReadLine(),out gas_liter);

            int cal1 = gas_liter * 13000;
            int cal2 = cal1 * 95 ; // cm
            float cal3 = (float)cal2 * km; // แปลง cm เป็น km

            Console.WriteLine("------------------------\r");
            Console.WriteLine("Distance is : {0} KM", cal3.ToString("0.0"));
            Console.WriteLine("------------------------\n");
        }
    }
}
