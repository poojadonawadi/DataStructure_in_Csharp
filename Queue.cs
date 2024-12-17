using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Queue
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        Node front;
        Node rear;
        public void Enqueue(int data)
        {
            Node n = new Node(data);
            if(front == null)
            {
                front = rear = n;
            }
            else
            {
                rear.next = n;
                rear = n;
            }
        }
        public int Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }
            int data = front.data;
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }
        public string PrintQueue()
        {
            string myQueue = "[";
            Node temp = front;
            while (temp != null)
            {
                myQueue = myQueue + temp.data;
                if (temp.next != null)
                {
                    myQueue = myQueue + ",";
                }
                temp = temp.next;
            }
            return myQueue + "]";
        }
    }
}
