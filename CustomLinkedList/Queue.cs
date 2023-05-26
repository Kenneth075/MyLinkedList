using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Queue<T>
    {
        Node<T> front, back;
        public Queue()
        {
            this.front = this.back = null;
        }

        //This method allows you to add a key to the queue.
        public void Enqueue(T Key)
        {
            //Creating a new node.

            Node<T> temp = new Node<T>(Key);

            //If queue is empty,then new node is in front and back.

            if (this.back == null)
            {
                this.front = this.back = temp;
                return;
            }
            this.back.next = temp;  //Add the new node at the end of the quene and change back
            this.back = temp;
        }
        //This method remove any key from the queue.
        public void Dequeue()
        {
            if (this.front == null)
            {
                return;
            }
            Node<T> temp = this.front;      //Store previous front and move front one node ahead
            this.front = this.back.next;
            if (this.front == null)
            {
                this.back = null;
            }

        }
        public bool IsEmpty()
        {
            return this.front == null;
        }
        public int Size()
        {
            Node<T> current = front;
            if (current == null)
            {
                return 0;
            }
            int counter = 0;
            while (current.next != null)
            {
                current = current.next;
                counter++;
            }
            return counter;
        }
        public void PrintNode()
        {
            Node<T> current = front;
            while (current != null)
            {
                Console.WriteLine("Value of Node is {0}", current.data);
                current = current.next;
            }
        }
    }





}

