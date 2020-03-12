using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Functional Programs");
                Console.WriteLine("1.Two Dimensional Array");
                Console.WriteLine("2.Triplets Add To Zero");
                Console.WriteLine("3.Distance");
                Console.WriteLine("4.Quadratic");
                Console.WriteLine("5.WindChill");
                Console.WriteLine("6.Exit");
                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TwoDArray.input();
                        break;
                    case 2:
                        TripletsAddZero.ArrayInput();
                        break;
                    case 3:
                        Distance.Input();
                        break;
                    case 4:
                        QuadraticEquation.Input();
                        break;
                    case 5:
                        WindChill.Input();
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nEnter valid choice\n");
                        break;
                }
            }
        }
    }
}
