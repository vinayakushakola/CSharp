/*
 * Purpose: Created all the Functions of LinkedList
 * @author  Vinayak Ushakola
 * @version 1.0
 * @since   05-04-2020
 */

using System;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class LinkedList<AnyData>
    {
        private Node<AnyData> head;
        private int size;
        private int index = 0;

        public LinkedList()
        {
            this.head = null;
        }

        /// <summary>
        /// This Method is used to Display the Data
        /// </summary>
        public void Display()
        {
            Node<AnyData> curNode;
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty!");
                return;
            }

            curNode = head;
            while ( curNode != null )
            {
                Console.Write(curNode.data + " ");
                curNode = curNode.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This Method is used to Show the size of the Linked List
        /// </summary>
        /// <returns>Integer</returns>
        public int Size()
        {
            if (head == null)
            {
                return 0;
            }
            Node<AnyData> curNode = head;
            while (curNode != null)
            {
                size++;
                curNode = curNode.next;
            }
            return size;
        }

        /// <summary>
        /// This Method is used to Delete Node by Position
        /// </summary>
        /// <param name="position">Enter Position</param>
        public void DeleteNodeAt(int position)
        {
            Node<AnyData> curNode = head;
            Node<AnyData> prvNode = null;

            if (index == position)
            {
                head = curNode.next;
                curNode = null;
                return;
            }

            while (curNode.next != null && index != position)
            {
                prvNode = curNode;
                curNode = curNode.next;
                if (curNode == null)
                {
                    Console.WriteLine("Your Entered Position is not in the List!");
                    return;
                }
                index++;
            }
            prvNode.next = curNode.next;
            curNode = null;
        }

        /// <summary>
        /// This Method is used to Delete Node by Data
        /// </summary>
        /// <param name="key">Enter Old Data</param>
        public void DeleteNode(AnyData key)
        {
            Node<AnyData> curNode = head;
            Node<AnyData> prevNode = null;

            if (curNode.data.Equals(key))
            {
                head = curNode.next;
                return;
            }

            while (curNode.next != null && !curNode.data.Equals(key))
            {
                prevNode = curNode;
                curNode = curNode.next;
                if (curNode == null)
                {
                    Console.WriteLine("Your Entered Data is not in the List!");
                    return;
                }
            }
            prevNode.next = curNode.next;
        }

        /// <summary>
        /// This Method is used to Add Data At Start Position.
        /// </summary>
        /// <param name="data">It Takes Any type of data</param>
        public void AddFirst(AnyData data)
        {
            Node<AnyData> newNode = new Node<AnyData>(data);
            Node<AnyData> curNode = head;
            if ( head == null)
            {
                newNode = new Node<AnyData>(data);
                head = newNode;
                return;
            }

            head = newNode;
            newNode.next = curNode;
        }

        /// <summary>
        /// This Method is used to Add Data at the End Position.
        /// </summary>
        /// <param name="data">It Takes Any type of data</param>
        public void AddLast(AnyData data)
        {
            Node<AnyData> newNode;
            Node<AnyData> curNode;
            if ( head == null )
            {
                newNode = new Node<AnyData>(data);
                head = newNode;
                return;
            }

            curNode = head;
            while ( curNode.next != null )
            {
                curNode = curNode.next;
            }
            newNode = new Node<AnyData>(data);
            curNode.next = newNode;
        }

        /// <summary>
        /// This Method is used to Insert New Data After Mentioned Old Data
        /// </summary>
        /// <param name="key">Enter Old Data</param>
        /// <param name="data">Enter New Data</param>
        public void InsertAfter(AnyData key, AnyData data)
        {
            Node<AnyData> newNode = new Node<AnyData>(data);
            Node<AnyData> curNode = head;
            Node<AnyData> nextNode = null;

            while (curNode.next != null && !curNode.data.Equals(key))
            {
                curNode = curNode.next;
                if (curNode == null)
                {
                    Console.WriteLine("Your Entered Data is not in the List!");
                    return;
                }
            }
            nextNode = curNode.next;
            curNode.next = newNode;
            newNode.next = nextNode;
        }

        /// <summary>
        /// This Method is used to Insert New Data Before, Mentioned Old Data
        /// </summary>
        /// <param name="key">Enter Old Data</param>
        /// <param name="data">Enter New Data</param>
        public void InsertBefore(AnyData key, AnyData data)
        {
            Node<AnyData> newNode = new Node<AnyData>(data);
            Node<AnyData> curNode = head;
            Node<AnyData> prevNode = null;

            if (curNode.data.Equals(key))
            {
                head = newNode;
                newNode.next = curNode;
                return;
            }

            while (curNode.next != null && !curNode.data.Equals(key))
            {
                prevNode = curNode;
                curNode = curNode.next;
                if (curNode == null)
                {
                    Console.WriteLine("Your Entered Data is not in the List!");
                    return;
                }
            }
            prevNode.next = newNode;
            newNode.next = curNode;
        }

        /// <summary>
        /// This Method is used to Add Data by Position
        /// </summary>
        /// <param name="position">Enter Position</param>
        /// <param name="data">Enter Data</param>
        public void AddAt(int position, AnyData data)
        {
            Node<AnyData> newNode = new Node<AnyData>(data);
            Node<AnyData> curNode = head;
            Node<AnyData> prvNode = null;
            
            if ( index == position)
            {
                head = newNode;
                newNode.next = curNode;
                return;
            }

            while ( curNode.next != null && index != position)
            {
                prvNode = curNode;
                curNode = curNode.next;
                if (curNode == null)
                {
                    Console.WriteLine("Your Entered Position is not in the List!");
                    return;
                }
                index++;
            }
            prvNode.next = newNode;
            newNode.next = curNode;
        }

    }
}
