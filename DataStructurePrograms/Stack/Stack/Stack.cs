using System;

namespace Stack
{
    public class Stack
    {
        private char[] stack = new char[50];

        public int Count = 0;

        public int Push(char n)
        {
            if (this.Count == this.stack.Length)
            {
                Console.WriteLine("Stack is Overflow");
            }
            else
            {
                this.stack[this.Count++] = n;
            }

            return 0;
        }

        public int Pop()
        {
            int result = -1;
            if (this.Count == 0)
            {
                Count--;
            }
            else
            {
                result = this.stack[--this.Count];
            }

            return result;
        }

        public void PrintStack()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Stack data");
                for (int i = this.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(this.stack[i]);
                }
            }
        }

        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
