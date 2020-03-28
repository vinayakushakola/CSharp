using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.FactoryPattern
{
    class FactoryProgram
    {
        public static void FactoryRun()
        {
            try
            {
                Console.WriteLine("Output: ");
                string choice;
                Console.Write("Enter what you want PC, Laptop or Server: ");
                choice = Console.ReadLine();

                ComputerFactory factory = new ComputerFactory();
                Computer computer = factory.GetComputer(choice);

                Console.WriteLine("\n");
                Console.WriteLine(choice.ToUpper() + " Details \nCPU: {0}\nRam: {1}\nHDD: {2}\nSDD: {3} ", computer.GetCPU(),
                    computer.GetRAM(), computer.GetHDD(), computer.GetSDD());


            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
