using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_app_console_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input the year of  his born

            Console.Write(" Inter your year of born : ");
            string stringage = Console.ReadLine();
            Console.WriteLine();

            // Convert this value to number ! 

            double age = 0;
            
            try
            {
                age = Convert.ToDouble(stringage);
                


            }
            catch
            {

                Console.WriteLine(" WARNING : Plase Input a Numerical Value ");
                Console.WriteLine();
                Console.WriteLine(" Press any key to exit ....");
                Console.ReadKey();
                return;
            }

            // Displaying a bunch of computations with this value

            if (age <= 0)
            {
                Console.WriteLine(" The Value Can't To Be Zero or Negative");
                Console.WriteLine();
            }

            else if (age == 0.0)
            {
                Console.WriteLine(" The Age Should Be 4 Digits and no Decimal Number ");
                Console.WriteLine();


            }


            else if (age >= 1900)
            {
                DateTime now = DateTime.Now;

                double result1 = now.Year - age;                                               //in years
                double result2 = result1 * 365;                                                // in days
                double result3 = result2 * 24;                                                 // in Hours


                Console.WriteLine(" You Have : " + result1 + " Years Old,");
                Console.WriteLine(" You Lived : " + result2 + " Days, and ");
                Console.WriteLine(" Passed on you : " + result3 + " Hours !");
                Console.WriteLine();

            }
            else
            {

            }


            // Stop a program
            
            Console.WriteLine(" Press any key to exit ....");
            Console.ReadKey();

            
        }
    }
}
