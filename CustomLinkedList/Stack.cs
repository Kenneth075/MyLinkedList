using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Stack<T>
    {
        Node<T> Top;
        public Stack()
        {
            this.Top = null;
        }
        public void Push(T item)  //At the head linkedlist for stack, you will have the top node and the tails you will have a bottom node.
        {
            //Creating new node temp and allocate memory
            Node<T> temp = new Node<T>(item);

            if (Top == null)
            {
                temp.next = null;
            }
            else
            {
                temp.next = Top;
            }
            Top = temp;
        }
        //Utility function to check if the stack is empty or not.
        public bool IsEmpty()
        {
            return Top == null;
        }
        //Utility function to return top element in a stack
        public T Peek()
        {
            //Check empty stack.
            if (!IsEmpty())
            {
                return Top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return default;
            }
        }
        //Utility function to pop top items from the stack.
        public void Pop()
        {
            //Check for stack underflow
            if (Top == null)
            {
                Console.WriteLine("\n Stack underflow");
                return;
            }
            //Update the top pointer to point to the next node.
            Top = Top.next;
            Console.WriteLine(Top.data);
        }
        public int Size()
        {
            Node<T> current = Top;
            if (current == null)
            {
                return 0;
            }
            int counter = 1;

            while (current.next != null)
            {
                current = current.next;
                counter++;
            }
            return counter;

        }
        public void PrintNode()
        {
            Node<T> current = Top;
            while (current != null)
            {
                Console.WriteLine("Node value is {0}", current.data);
                current = current.next;
            }
        }
    }

}

