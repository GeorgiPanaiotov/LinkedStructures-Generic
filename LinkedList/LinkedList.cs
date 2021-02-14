using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }

        public void AddFirst(T input)
        {
            Node<T> oldHead = this.Head;
            this.Head = new Node<T>(input);
            this.Head.Next = oldHead;

            if(Count == 0)
            {
                this.Tail = this.Head;
            }
            Count++;
        }
        public void AddLast(T input)
        {
            Node<T> oldTail = this.Tail;

            this.Tail = new Node<T>(input);

            if(Count == 0)
            {
                this.Head = this.Tail;
            }
            else
            {
                oldTail.Next = this.Tail;
            }
            Count++;
        }
        public void RemoveFirst()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }

            Node<T> newHead = this.Head.Next;
            this.Head = newHead;
            Count--;
            if(Count == 0)
            {
                this.Tail = null;
            }
        }
        public void RemoveLast()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }
            
            if(Count == 1)
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                Node<T> newTail = GetSecondToLast();
                newTail.Next = null;
                this.Tail = newTail;
            }
            Count--;
            
        }
        public Node<T> GetSecondToLast()
        {
            Node<T> current = this.Head;

            while(current.Next != this.Tail)
            {
                current = current.Next;
            }

            return current;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = this.Head;
            while (current != null)
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
