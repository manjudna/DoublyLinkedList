using System;

namespace DoublyLinkedList
{
    internal class DoubleLinkedList
    {
        internal DNode head;

        internal void InsertLast(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(doubleLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        internal DNode GetLastNode(DoubleLinkedList doublyLinkedList)
        {
            DNode temp = doublyLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void DeleteNodebyKey(DoubleLinkedList doubleLinkedList, int key)
        {
            DNode temp = doubleLinkedList.head;
            if (temp != null && temp.data == key)
            {
                doubleLinkedList.head = temp.next;
                doubleLinkedList.head.prev = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

        public void PrintList(DoubleLinkedList doubleLinkedList)
        {
            DNode n = doubleLinkedList.head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

    }


}
