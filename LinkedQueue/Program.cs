﻿using System;

namespace LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            int[] array = queue.ToArray();
        }
    }
}
