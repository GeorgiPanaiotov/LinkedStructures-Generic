using System;

namespace LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> ls = new LinkedStack<int>();

            ls.Push(5);
            ls.Push(2);
            ls.Push(1);
            ls.Push(6);
            ls.Push(4);
            Console.WriteLine(ls.Count);
            Console.WriteLine(ls.Peek());

            int[] array = ls.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            while (ls.Count > 0)
            {
                Console.WriteLine(ls.Pop());
            }
        }
    }
}
