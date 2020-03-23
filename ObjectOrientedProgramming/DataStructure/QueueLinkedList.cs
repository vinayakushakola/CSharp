using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.DataStructure
{
    public class QueueNode
    {
        public string data;
        public QueueNode next;
    }
    class QueueLinkedList
    {
        QueueNode front, rear;
        public void Enqueue(string data)
        {
            QueueNode queueNode = new QueueNode();

            if (rear == null)
            {
                queueNode.data = data;
                queueNode.next = null;
                front = queueNode;
                rear = queueNode;
            }
            else
            {
                queueNode.data = data;
                queueNode.next = null;
                rear.next = queueNode;
                rear = queueNode;
            }
        }
        public void Dequeue()
        {
            if (front == null && rear == null)
                Console.WriteLine("Empty");
            else
            {
                Console.Write(front.data + "\t");
                front = front.next;
            }
        }
        public string Search(int position)
        {

            if (rear != null)
            {
                int count = 1;
                for (QueueNode queueNode = front; queueNode != null; queueNode = queueNode.next)
                {
                    if (count == position)
                        return queueNode.data;
                    count++;
                }
            }

            return "No Data";
        }
        public Boolean IsEmpty()
        {
            if (front == null && rear == null)
                return true;
            else
                return false;
        }
        public int Size()
        {
            int count = 0;

            if (front == null && rear == null)
                return count;

            for (QueueNode p = front; p != null; p = p.next)
                count++;

            return count;

        }
    }
}
