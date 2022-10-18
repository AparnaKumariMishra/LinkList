using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase4InsertingAtMiddle
{
    internal class UC4InsertingAtMiddle
    {
        internal Node head; //new 
        public void Add(int data)
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

        public void Display()
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
        internal Node InsertAtMiddle(int data)
        {
            // if list is empty
            if (head == null)
                head = new Node(data);
            else
            {
                // get a new node
                Node newNode = new Node(data);

                Node ptr = head;
                int len = 0;
            }
            // 'count' the number of nodes after which
            // the new node is to be inserted
            int count = ((len % 2) == 0);
            ptr = head;
            // the new node is to be inserted
            while (count-- > 1)
                ptr = ptr.next;

            // insert the 'newNode' and adjust
            // the required links
            newNode.next = ptr.next;
            ptr.next = newNode;
        }
    }
}
