using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        public static void Input()
        {
            Console.Write("Enter Temperature In Fahrenheit: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter Velocity Miles Per Hour: ");
            double velocity = Convert.ToDouble(Console.ReadLine());

            if (temp <= 50 && (velocity < 3 || velocity > 120))
            {
                Utility.WindChill(temp, velocity);
            }
            else
            {
                Console.WriteLine("Enter Valid Inputs");
            }
        }
    }
}
