using System;

namespace Stack
{
    public class BalancedParenthesis
    {
        public Boolean CheckParenthesis(string Parenthesis)
        {
            Stack stack = new Stack();
            char[] parent = Parenthesis.ToCharArray();

            for (int i = 0; i < Parenthesis.Length; i++)
            {
                if (parent[i] == '(')
                    stack.Push(parent[i]);
                else if (parent[i] == ')')
                    stack.Pop();
            }

            if (stack.IsEmpty())
                return true;
            else
                return false;
        }
        public void IsParenthesisBalanced()
        {
            try
            {
                Console.Write("Enter the Arithmetic Expression: ");
                string str = Console.ReadLine();


                if (CheckParenthesis(str))
                    Console.WriteLine("The Arithmetic Expression are Balanced");
                else
                    Console.WriteLine("The Arithmetic Expression are not Balanced");

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
