using System;
using CustomLinkedList;


namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList.LinkedList<int> x = new CustomLinkedList.LinkedList<int>();
            x.AddTail(1);
            x.AddTail(2);
            x.AddTail(3);
            x.AddTail(4);
            x.PrintNode();
            Console.WriteLine(x.ValueCheck(4));
            x.RemoveFirstOccurrance(3);
            x.PrintNode();


            CustomLinkedList.Queue<string> y = new CustomLinkedList.Queue<string>();
            y.Enqueue("Hi");
            y.Enqueue("hello");
            y.Enqueue("kmdjn");
            y.Enqueue("5jdjdj");
            y.PrintNode();
            y.Dequeue();

            Console.WriteLine(y.IsEmpty());
            Console.WriteLine(y.Size());
            Console.WriteLine("----------------");
            y.PrintNode();



           CustomLinkedList.Stack<int> z = new CustomLinkedList.Stack<int>();

            z.Push(1);
            z.Push(2);
            z.Push(3);
            z.Push(4);
            z.PrintNode();
            z.Pop();
            Console.WriteLine(z.Size());
            Console.WriteLine(z.Peek());
            z.PrintNode();














        }
    }
}
