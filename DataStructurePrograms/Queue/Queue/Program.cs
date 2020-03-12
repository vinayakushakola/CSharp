using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Bank counter");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Banking bankcash = new Banking();
                    bankcash.CashCounter();
                    break;
                case 2:
                    break;
            }
            
        }
    }
}



