using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Check Balanced Parenthesis");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BalancedParenthesis balanced= new BalancedParenthesis();
                    balanced.CheckExpressionBalancedOrNot();
                    break;
                case 2:
                    break;
            }
        }
    }
}
