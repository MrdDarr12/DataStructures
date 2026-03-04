using System;

namespace DataStructures
{
    public class MyLinkedList<T>
    {
        private MyLinkedListNode<T> head;
        private MyLinkedListNode<T> tail;
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            var node = new MyLinkedListNode<T>(value);

            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            var node = new MyLinkedListNode<T>(value);

            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");

            head = head.Next;

            if (head == null)
                tail = null;

            Count--;
        }

        public void RemoveLast()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                var current = head;
                while (current.Next != tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                tail = current;
            }

            Count--;
        }

        public void Clear()
        {
            head = tail = null;
            Count = 0;
        }

        public bool Contains(T value)
        {
            var current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public bool Equals(MyLinkedList<T> other)
        {
            if (other == null || Count != other.Count)
                return false;

            var current1 = head;
            var current2 = other.head;

            while (current1 != null)
            {
                if (!current1.Value.Equals(current2.Value))
                    return false;

                current1 = current1.Next;
                current2 = current2.Next;
            }

            return true;
        }
    }
}