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
        public void Append(int data)
        {
            Add(data);
        }
        public void InsertBetweenNodes(int insertAfter, int data, int insertBefore)       //InsertBetweenNodes() UC4.
        {
            Node newNode = new Node(data);
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == insertAfter && temp.next.data == insertBefore)
                    {
                        //Console.WriteLine($"{temp.data} node is present");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        Console.WriteLine($"{newNode.data} insertion done between {temp.data} and {newNode.next.data}.");
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (!isFound)
                Console.WriteLine($"{data} node is not present.");
        }
        public void RemoveFirst()      //AddFirst UC5 
        {
            int deletedNode = head.data;
            head = head.next;
            Console.WriteLine($"First node {deletedNode} has been removed.");
        }
        public void RemoveLast()        //RemoveLast UC6
        {
            Node temp = head;
            if (head == null)
                Console.WriteLine("LinkedList is emty");
            else if (temp.next == null)
            {
                int data = temp.data;
                head = null;
                Console.WriteLine($"{data} is deleted");
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                int lastDeletedNode = temp.next.data;
                temp.next = null;
                Console.WriteLine($"{lastDeletedNode} node is deleted");
            }
        }
        public void SearchNode(int data)        //Searching any given Node .UC7.
        {
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine($"{temp.data} node is present");
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (!isFound)
                Console.WriteLine($"{data} node is not present.");
        }
        public void InsertAfter(int insertAfter, int data)       //Insert After any Node UC8.
        {
            Node newNode = new Node(data);
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == insertAfter)
                    {
                        //Console.WriteLine($"{temp.data} node is present");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        Console.WriteLine($"{newNode.data} insertion done after {temp.data}.");
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (!isFound)
                Console.WriteLine($"{data} node is not present.");
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

