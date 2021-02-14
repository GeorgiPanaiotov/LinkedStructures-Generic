using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedQueue
{
    class Node<T>
    {
        public Node(T input)
        {
            this.Value = input;
        }
        public T Value { get; set; }
        public Node<T> Previous { get; set; }
    }
}
