using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.FactoryPattern
{
    class ComputerFactory
    {
        public Computer GetComputer(string type)
        {
            Computer computer = null;

            string ram, sdd, hdd, cpu;
            
            Console.Write("Enter the CPU: ");
            cpu = Console.ReadLine();
            Console.Write("Enter the Ram: ");
            ram = Console.ReadLine();
            Console.Write("Enter the SDD: ");
            sdd = Console.ReadLine();
            Console.Write("Enter the HDD: ");
            hdd = Console.ReadLine();
            
            
            if (type.ToLower().Equals("pc"))
            {
                computer = new PC(cpu, ram, hdd, sdd);
            }
            else if (type.ToLower().Equals("laptop"))
            {
                computer = new Laptop(cpu, ram, hdd, sdd);
            }
            else if (type.ToLower().Equals("server"))
            {
                computer = new Server(cpu, ram, hdd, sdd);
            }
            else
            {
                Console.WriteLine("Invalid input!!");
            }

            return computer;
        }
    }
}
