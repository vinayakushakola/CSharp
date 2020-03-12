using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class Queue
    {
        private Queue front, rear;

        private int data;

        private Queue next;

        public Queue(int d)
        {
            this.data = d;
            this.next = null;
        }

        public void Enqueue(int data)
        {
            Queue temp = new Queue(data);
            if (this.rear == null)
            {
                this.rear = this.front = temp;
            }

            this.rear.next = temp;
            this.rear = temp;
        }

        public Queue Dequeue()
        {
            if (this.front == null)
            {
                return null;
            }
            Queue temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }
            return temp;
        }

        public void QueueDisplay()
        {
            Queue temp;
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty ");
            }
            else
            {
                temp = this.front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }

                Console.WriteLine();
            }
        }

        public bool IsQueueEmpty()
        {
            return this.front == this.rear;
        }
    }
}

