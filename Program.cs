using System.Collections.Generic;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linkedlist Program");
            Console.WriteLine("Enter the Options given below \n 1.Create a LinkedList \n 2.Adding Elements \n 3. Append Elements " +
                "\n 4 Inserting Elements \n 5.Delete Element \n 6.Delete LastElement \n 7.Searching Node \n 8.Insert Element after given node" +
                "\n 9.Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                 LinkedList linkedList = new LinkedList();
                 linkedList.Add(56);
                 linkedList.Add(30);
                 linkedList.Add(70);
                 linkedList.Add(80);
                 linkedList.Display();
                    break;
                case 2:
                    LinkedList linkedlist = new LinkedList();
                    linkedlist.AddFirst(70);
                    linkedlist.AddFirst(30);
                    linkedlist.AddFirst(56);
                    linkedlist.Display();
                    break;
                case 3:
                    LinkedList list = new LinkedList();                                 //Append() UC3
                    list.Append(70);
                    list.Append(30);
                    list.Append(50);
                    break;
                case 4:
                    LinkedList customLinkedList2 = new LinkedList();
                    customLinkedList2.Append(56);                                   
                    customLinkedList2.Append(30);
                    customLinkedList2.Append(70);
                    customLinkedList2.Display();
                    break;
                case 5:
                    LinkedList customLinkedList4 = new LinkedList();
                    customLinkedList4.AddFirst(56);
                    customLinkedList4.Add(30);
                    customLinkedList4.Add(70);
                    customLinkedList4.Display();
                    customLinkedList4.RemoveFirst();            //Deleting First Node UC5.
                    customLinkedList4.Display();
                    break;
                case 6:
                    LinkedList customLinkedList5 = new LinkedList();
                    customLinkedList5.AddFirst(56);
                    customLinkedList5.Add(30);
                    customLinkedList5.Add(70);
                    customLinkedList5.Display();
                    customLinkedList5.RemoveLast();             //Deleteing Last Node UC6.
                    customLinkedList5.Display();
                    break;
                 case 7:
                    LinkedList customLinkedList6 = new LinkedList();
                    customLinkedList6.AddFirst(56);
                    customLinkedList6.Add(30);
                    customLinkedList6.Add(70);
                    customLinkedList6.SearchNode(30);       //Searching any given Node .UC7.
                    break;
                 case 8:
                    LinkedList customLinkedList7 = new LinkedList();
                    customLinkedList7.AddFirst(56);
                    customLinkedList7.Add(30);
                    customLinkedList7.Add(70);
                    customLinkedList7.Display();
                    customLinkedList7.InsertAfter(30, 40);      //Insert After Node UC8.
                    customLinkedList7.Display();
                    break;

                default:
                    Console.WriteLine("Enter the valid option");
                    break;
            }
            
        }
    }
}