using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(); // 1.
            LinkedList<int> list2 = new LinkedList<int>(new int[] { 0, 0, 0 }); // 2.
            LinkedList<int> list3 = new LinkedList<int>(new int[] { 22, 22, 22 }); // 3.
            LinkedList<int> list4 = new LinkedList<int>(new int[] { 2, 2, 0, 5, 2, 0, 0, 4 }); // 4.

            //Print(list4); // 5.

            Console.WriteLine(Max(list4)); // 6.
            Console.WriteLine(Sum(list4)); // 7.
            Console.WriteLine(Entrance(list4, 9)); // 8.
            AddLastAndPrint(list4, 9); // 9.

            LinkedList<int> sorted = OrderByDesc(list4);

            Print(sorted);

            Insert(list4, 2, 9);

            Console.WriteLine();

            Print(list4);
        }

        static void Insert(LinkedList<int> list, int position, int val)
        {
            LinkedListNode<int> node = list.First;
            for (int i = 0; i < position - 1; i++)
            {
                node = node.Next;
            }

            list.AddBefore(node, val);
        }

        static LinkedList<int> OrderByDesc(LinkedList<int> list)
        {
            return new LinkedList<int>(list.OrderByDescending(x => x));
        }

        static LinkedList<int> OrderByAsc(LinkedList<int> list)
        {
            return new LinkedList<int>(list.OrderBy(x => x));
        }

        static void AddLastAndPrint(LinkedList<int> list, int val)
        {
            list.AddLast(val);

            Print(list);
        }

        static int Entrance(LinkedList<int> list, int val)
        {
            int counter = 0;

            foreach (int item in list)
            {
                if (item == val)
                {
                    counter++;
                }
            }

            return counter;
        }

        static int Sum(LinkedList<int> list)
        {
            int sum = 0;

            LinkedListNode<int> node = list.First;

            while (node is not null)
            {
                sum += node.Value;
                node = node.Next;
            }

            return sum;
        }

        static void Print(LinkedList<int> list)
        {
            LinkedListNode<int> node = list.First;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        static int Max(LinkedList<int> list)
        {
            int max = list.First.Value;

            foreach (int item in list)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            //LinkedListNode<int> node = list.First;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (max < node.Value)
            //    {
            //        max = node.Value;
            //    }
            //    node = node.Next;
            //}

            return max;
        }
    }
}
