using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
            public Node head;

            public void Add(int data)
            {
                Node node = new Node(data);
                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} Inserted in linked list ", node);

            }
        public void AddFirst(int data) 
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine($"{newNode.data} is added into the list.");
        }
        public void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Linkedlist Is Empty");
                    return;
                }
                else
                {
                    while (temp != null)
                    {
                        Console.WriteLine(temp.data + " ");
                        temp = temp.next;
                    }
                }
            }
    }
}
