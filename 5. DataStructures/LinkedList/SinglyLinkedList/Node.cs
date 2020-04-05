/*
 * Purpose: Node of the Linked List
 * @author  Vinayak Ushakola
 * @version 1.0
 * @since   05-04-2020
 */

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class Node<AnyData>
    {
        public AnyData data { get; set; }

        public Node<AnyData> next { get; set; }

        public Node(AnyData data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
