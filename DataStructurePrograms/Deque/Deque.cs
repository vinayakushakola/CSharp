using System;
using System.Collections.Generic;
using System.Text;

namespace Deque
{
    class Deque
    {
        char[] deque = new char[50];
        int front = 0, rear = 0;

        public void AddFront(char character)
        {
            if (front == 0)
            {
                front++;
                deque[front] = character;
                rear++;
            }
            else
            {
                rear++;
                for (int i = rear; i >= 1; i--)
                {
                    deque[i] = deque[i - 1];
                }
                deque[front] = character;
            }
        }

        public void AddRear(char character)
        {
            if (rear == 0)
            {
                rear++;
                deque[rear] = character;
                front++;
            }
            else
            {
                rear++;
                deque[rear] = character;
            }
        }
        public char RemoveFront()
        {
            if (front == 0)
                return '0';
            else
            {
                char temp = deque[front];
                for (int i = 0; i < rear; i++)
                    deque[i] = deque[i + 1];
                rear--;
                return temp;
            }
        }
        public char RemoveRear()
        {
            if (rear == 0)
                return '0';
            else
            {
                char temp = deque[rear];
                deque[rear] = ' ';
                rear--;
                return temp;
            }
        }

        public bool IsEmpty()
        {
            if (front == 0 && rear == 0 || front == rear)
                return true;
            else
                return false;
        }

        public int Size()
        {
            if (front == 0 && rear == 0)
                return 0;
            else
                return rear;
        }
    }
}
