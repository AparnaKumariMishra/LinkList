using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UserCase3AddAtEnd
{
    internal class UC3AddAtEnd
    {
        internal Node head; //new 
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
        }
        public void AddAtEnd(int data)
        //public  void Node AddAtEnd(int data)
       
        {
            // var newNode = new Node();
            var newNode = new Node(data);
             newNode.data = data;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
        }
        internal void AddAll(params int[] arr)
        {
            foreach (var item in arr)
            {
                Add(item);
            }
        }
    }

}
