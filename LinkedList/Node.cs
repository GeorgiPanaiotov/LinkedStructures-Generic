using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T input)
        {
            this.value = input;
        }

        public T Value 
        {
            get 
            {
                return this.value; 
            }
            set 
            {
                this.value = value; 
            }
        }
        public Node<T> Next 
        {
            get 
            {
                return this.next;
            }
            set 
            {
                this.next = value;
            } 
        }
    }
}
