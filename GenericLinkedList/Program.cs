using System;
using System.Collections.Generic;

namespace MergeTwoSortedLists
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class LinkedList
        {
            int count;
            ListNode head;

            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int data)
            {
                ListNode node = new ListNode(data);
                node.next = head;
                head = node;
                count++;
            }

            public void PrintList()
            {
                ListNode runner = head;

                do
                {
                    Console.WriteLine(runner.val);
                    runner = runner.next;
                }
                while (runner != null);

            }
        }

        static void Main(string[] args)
        {
            LinkedList linkedlist1 = new LinkedList();

            linkedlist1.AddNodeToFront(5);
            linkedlist1.AddNodeToFront(3);
            linkedlist1.AddNodeToFront(6);
            linkedlist1.PrintList();

        }
    }
}
