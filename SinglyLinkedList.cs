using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class SinglyLinkedList
    {
        public class Node
        {
            public int data;
            public Node next = null;
            public Node(int data)
            {
                this.data = data;
            }
        }
        Node head;
        public void AddNode(int data)
        {
            Node n = new Node(data);
            if(head == null)
            {
                head = n;
                return;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = n;
            }
        }
        public void AddFront(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            n.next = head;
            head = n;
        }
        public int DeleteFirst()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            int data = head.data;
            head = head.next;
            return data;
        }
        public int DeleteLast()
        {
            if(head == null)
            {
                Console.WriteLine("The lits is empty");
                return 0;
            }
            Node temp = head;
            Node prev = head;
            while (temp.next != null)
            {
                prev = temp;
                temp = temp.next;
            }
            if (prev == head)
            {
                head = null;
            }
            else
            {
                prev.next = null;
            }
            return temp.data;
        }
        public string PrintList()
        {
            string list = "";
            Node temp = head;
            while(temp != null)
            {
                list = list + temp.data;
                if (temp.next != null)
                {
                    list = list + "->";
                }
                temp = temp.next;
            }
            return list;
        }
    }
}
