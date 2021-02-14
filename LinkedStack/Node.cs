using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedStack
{
    class Node<T>
    {
        public Node(T input, Node<T> node)
        {
            Value = input;
            Next = node;
        }
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
