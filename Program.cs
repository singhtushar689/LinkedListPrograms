using System.Collections.Generic;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linkedlist Program");
            Console.WriteLine("Enter the Options given below \n 1.Create a LinkedList \n 2.Adding Elements \n 3. Append Elements \n4Exit");
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
                    LinkedList list = new LinkedList();
                    list.Append(70);
                    list.Append(30);
                    list.Append(50);
                    break;
                default:
                    Console.WriteLine("Enter the valid option");
                    break;
            }
            
        }
    }
}