using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Stack
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
        Node top;
        public void Push(int data)
        {
            Node n = new Node(data);
            n.next = top;
            top = n;
        }
        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("The Stackis Empty");
                return 0;
            }
            int data = top.data;
            top = top.next;
            return data;
        }
        public string PrintStack()
        {
            string myStack = "[";
            Node temp = top;
            while (temp != null)
            {
                myStack = myStack + temp.data;
                if (temp.next != null)
                {
                    myStack = myStack + ",";
                    temp = temp.next;
                }
            }
            return myStack + "]";
        }
    }
}
