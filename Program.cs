namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linkedlist Program");
            Console.WriteLine("Enter the Options given below \n 1.Create a LinkedList \n 2.Exit");
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
                    default:
                    Console.WriteLine("Enter the valid option");
                    break;
            }
            
        }
    }
}