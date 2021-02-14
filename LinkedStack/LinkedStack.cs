using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedStack
{
    class LinkedStack<T> : IEnumerable<T>
    {
        public int Count { get; set; }
        public Node<T> Top { get; set; }


        public void Push(T input)
        {
            if(Count == 0)
            {
                this.Top = new Node<T>(input, null);
            }
            else
            {
                this.Top = new Node<T>(input, this.Top);
            }
            Count++;
        }

        public T Pop()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }

            T result = this.Top.Value;
            this.Top = this.Top.Next;
            Count--;

            return result;
        }

        public T Peek()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }

            return Top.Value;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            Node<T> current = this.Top;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }

            return array;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = this.Top;

            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
