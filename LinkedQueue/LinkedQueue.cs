using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedQueue
{
    class LinkedQueue<T> : IEnumerable<T>
    {
        public int Count { get; set; }
        public Node<T> Tail { get; set; }
        public Node<T> Head { get; set; }


        public void Enqueue(T input)
        {
            if (Count == 0)
            {
                this.Head = new Node<T>(input);
                this.Tail = this.Head;
            }
            else
            {
                Node<T> oldHead = this.Head;
                this.Head = new Node<T>(input);
                this.Head.Previous = oldHead;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            if(Count == 1)
            {
                this.Tail = this.Head;
            }
            Node<T> current = this.Head;
            while(current.Previous != this.Tail)
            {
                current = current.Previous;
            }
            this.Tail = current;
            Count--;
            return current.Previous.Value;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            Node<T> current = this.Head;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = current.Value;
                current = current.Previous;
            }
            return array;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = this.Tail;

            while (current != null)
            {
                yield return current.Value;
                current = current.Previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
