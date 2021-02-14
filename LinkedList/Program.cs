using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);
            list.AddLast(10);
            list.RemoveFirst();
            list.RemoveFirst();
            list.RemoveLast();
            list.RemoveLast();

            Console.WriteLine(list.Count);
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
