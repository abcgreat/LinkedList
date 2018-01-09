using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.AddFirst("Seattle");
            myList1.printAllNodes();

            Console.WriteLine();

            myList1.Reverse();

            Console.WriteLine("Reversed First:");
            myList1.printAllNodes();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            myList2.AddLast("Tacoma");
            myList2.printAllNodes();

            myList2.Reverse();
            Console.WriteLine("Reversed Last:");

            myList2.printAllNodes();

            Console.ReadLine();
        }
    }

    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        public void Reverse()
        {
            if (head == null) return;

            Node prev = null, current = head, next = null;

            while (current.next != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            current.next = prev;
            head = current;
        }


        //public void Reverse(ref Node head)
        //{
        //    if (head == null) return;

        //    Node prev = null, current = head, next = null;

        //    while (current.next != null)
        //    {
        //        next = current.next;
        //        current.next = prev;
        //        prev = current;
        //        current = next;
        //    }

        //    current.next = prev;
        //    head = current;
        //}

    }
}
