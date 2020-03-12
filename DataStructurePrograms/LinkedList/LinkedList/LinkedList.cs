using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList<E>
    {
        public Node<E> headNode;

        public LinkedList()
        {
            headNode = null;
        }
        public string FileDisplay()
        {
            Node<E> cur_node = headNode;
            string temp = "";
            while (cur_node != null)
            {
                temp = temp + cur_node.data + " ";
                cur_node = cur_node.next;
            }
            return temp;
        }

        public void ShowList()
        {
            Node<E> cur_node;
            if (headNode == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            cur_node = headNode;
            while (cur_node != null)
            {
                Console.Write(cur_node.data + " ");

                cur_node = cur_node.next;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int count = 0;
            Node<E> cur_node = headNode;
            while (cur_node != null)
            {
                count++;
                cur_node = cur_node.next;
            }
            Console.WriteLine("Number of nodes in the list: {0}", count);
        }

        public bool Search(E x)
        {
            int position = 1;
            Node<E> cur_node = headNode;
            while (cur_node != null)
            {
                if (cur_node.data.Equals(x))
                {
                    break;
                }
                position++;
                cur_node = cur_node.next;
            }
            if (cur_node == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddAtStart(E data)
        {
            Node<E> new_node = new Node<E>(data)
            {
                next = headNode
            };
            headNode = new_node;
        }

        public void AddToEnd(E data)
        {
            Node<E> new_node = new Node<E>(data);
            Node<E> cur_node = headNode;
            if (headNode == null)
            {
                headNode = new_node;
                return;
            }

            while (cur_node.next != null)
            {
                cur_node = cur_node.next;
            }
            cur_node.next = new_node;
        }

        public void AddAt(int pos, E data)
        {
            Node<E> new_node = new Node<E>(data);
            Node<E> cur_node = headNode;
            int index = 0;
            if (index == pos)
            {
                headNode = new_node;
                new_node.next = cur_node;
                return;
            }
            Node<E> prev;
            while (cur_node.next != null)
            {
                prev = cur_node;
                cur_node = cur_node.next;
                index += 1;
                if (index == pos)
                {
                    prev.next = new_node;
                    new_node.next = cur_node;
                    return;
                }
            }
            if (cur_node == null)
            {
                return;
            }

        }

        public void DeleteNode(E data)
        {
            Node<E> cur_node = headNode;
            if (cur_node.data.Equals(data))
            {
                headNode = cur_node.next;
                return;
            }
            Node<E> prev = null;
            while (!cur_node.data.Equals(data))
            {
                prev = cur_node;
                cur_node = cur_node.next;
            }
            prev.next = cur_node.next;
        }

        public bool IsEmpty()
        {
            if (headNode == null)
            {
                return true;
            }
            return false;
        }
        public E Pop()
        {
            Node<E> cur_node = headNode;
            Node<E> prev = null;
            while (cur_node.next != null)
            {
                prev = cur_node;
                cur_node = cur_node.next;
            }
            E temp = cur_node.data;
            prev.next = null;
            return temp;
        }
    }
}
