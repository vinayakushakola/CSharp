using System;

namespace Stack
{
    public class BalancedParenthesis
    {
        public void CheckExpressionBalancedOrNot()
        {
            try
            {
                Console.WriteLine("Enter Arithmatic Expression for checked");
                string expression = Console.ReadLine();
                char[] expressioncharArray = expression.ToCharArray();
                int size = expressioncharArray.Length;
                CheckedBalanceParenthesis(expressioncharArray);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
                Console.WriteLine(exception.Message);
            }


        }
        public bool CheckedBalanceParenthesis(char[] expressioncharArray)
        {
            Stack stack = new Stack(expressioncharArray.Length);
            for (int i = 0; i < expressioncharArray.Length; i++)
            {

                if (expressioncharArray[i] == '(' || expressioncharArray[i] == '{' || expressioncharArray[i] == '[')
                {
                    stack.Push(expressioncharArray[i]);
                }

                if (expressioncharArray[i] == ')' || expressioncharArray[i] == '}' || expressioncharArray[i] == ']')
                {


                    if (stack.IsEmpty())
                    {

                        return false;
                    }

                    int top = stack.Pop();
                    stack.Pop();

                    if ((top == '(' && expressioncharArray[i] != ')') ||
                        (top == '{' && expressioncharArray[i] != '}') ||
                        (top == '[' && expressioncharArray[i] != ']'))
                    {

                        return false;
                    }

                }
            }
            if (stack.IsEmpty())
            {
                Console.WriteLine("Expression is Balanced");
            }
            else
            {
                Console.WriteLine("Expression is not Balanced");
            }

            return true;
        }
    }
}
