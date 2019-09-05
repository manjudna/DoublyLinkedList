using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList myLinkedList = new DoubleLinkedList();

         
            myLinkedList.InsertLast(myLinkedList, 100);
            myLinkedList.InsertLast(myLinkedList, 200);
            myLinkedList.DeleteNodebyKey(myLinkedList, 3);

            myLinkedList.PrintList(myLinkedList);
            Console.WriteLine();
           
            myLinkedList.PrintList(myLinkedList);
            Console.WriteLine();
        }
    }


}
