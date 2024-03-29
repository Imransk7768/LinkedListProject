﻿using System;
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
            Console.WriteLine("1. Display \n2. Add Data\n3. Add in Reverse\n4. Insert it Particular Position\n" +
                "5. Delete First Element\n6. Delete last Element\n7. Search \n8. Insert at Particular Position\n9. Delete at Particular Position \n");
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
                        /*list.Add(56);
                        list.Add(70);
                        int a = list.Search(56);
                        list.InsertAtParticularPosition(a + 1, 30);
                        list.Display();*/
                        break;
                    case 5:
                        list.DeleteFirstNode();
                        break;
                    case 6:
                        list.DeleteLastNode();
                        break;
                    case 7:
                        Console.WriteLine("Search Element in Node ");
                        int ele = list.Search(30);
                        Console.WriteLine("Elements Present : " + ele);
                        list.Display();
                        break;
                    case 8:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        int addNew = list.Search(30);
                        list.InsertAtParticularPosition(addNew + 1, 40);
                        list.Display();
                        break;
                    case 9:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        int node = list.Search(30);
                        list.InsertAtParticularPosition(node + 1, 40);
                        list.Display();
                        list.DeleteNodeAtParticularPosition(node + 1);
                        Console.WriteLine("\nElement Deleted.");
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