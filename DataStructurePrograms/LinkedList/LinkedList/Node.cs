using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node<E>
    {
        public E data;
        public int size = 0;
        public Node<E> next;

        public Node(E data)
        {
            this.data = data;
            next = null;
        }

        public void SetData(E data)
        {
            this.data = data;
        }

        public E GetData()
        {
            return data;
        }
    }
}
