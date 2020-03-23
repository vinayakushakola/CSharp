using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.DataStructure
{
    class StackLinkedList
    {
        public class StackNode
        {
            public string data;
            public StackNode next;
        }

        StackNode top, bottom;

        public void Push(string data)
        {
            StackNode stackNode = new StackNode();

            if (top == null)
            {
                stackNode.data = data;
                stackNode.next = null;
                top = stackNode;
                bottom = stackNode;
            }
            else
            {
                stackNode.data = data;
                stackNode.next = null;
                bottom.next = stackNode;
                bottom = stackNode;
            }
        }

        public void Pop()
        {
            if (top == null)
                Console.WriteLine("No Element Present in the stack.");
            else if (bottom == top)
                bottom = top = null;
            else
            {
                for (StackNode p = top; p != null; p = p.next)
                {
                    if (p.next.next == null)
                    {
                        Console.WriteLine("The Pop Element is: {0}", p.next.data);
                        p.next = null;
                        bottom = p;
                    }
                }
            }
        }

        public void Peek()
        {
            if (top == null)
                Console.WriteLine("No Element Present in the stack.");
            else
                Console.WriteLine("The Peek Element is: {0}", bottom.data);
        }

        public Boolean IsEmpty()
        {
            if (top == null && bottom == null)
                return true;
            else
                return false;
        }

        public int Size()
        {
            int count = 0;

            if (top == null && bottom == null)
                return count;
            else
            {
                for (StackNode p = top; p != null; p = p.next)
                    count++;

                return count;
            }
        }


        public void Display()
        {
            if (top == null)
                Console.WriteLine("No Data Present");
            else
            {
                for (StackNode p = top; p != null; p = p.next)
                    Console.WriteLine(p.data);
            }
        }
    }
}
