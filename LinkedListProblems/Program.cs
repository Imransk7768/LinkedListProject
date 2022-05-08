using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>  Welcome to LisnkedList Project  <<<<");
            LinkedList list = new LinkedList();
            bool check = true;
            Console.WriteLine("1. Display \n2. Add Data\n3. Add in Reverse\n4. Insert it Particular Positio \n");
            while (check)
            {
                Console.WriteLine(" >>>>  Choose Option to Execute  <<<< ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Data Present in LinkedList");
                        list.Display();
                        break;
                    case 2:
                        Console.WriteLine("Added 56,30 & 70.");
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        Console.WriteLine("Data Present in LinkedList");
                        list.Display();
                        break;
                    case 3:
                        Console.WriteLine("Add Data In Reverse Order.\n70,30 & 56 in Recerse Order");
                        list.AddInReverseList(70);
                        list.AddInReverseList(30);
                        list.AddInReverseList(56);
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(70);
                        int a = list.Search(56);
                        list.InsertAtParticularPosition(a + 1, 30);
                        list.Display();
                        break;
                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}