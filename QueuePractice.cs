using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class Queue<T>
    {
        class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T data)
            {
                this.data = data;
            }
        }

        private Node<T> first;
        private Node<T> last;

        public void add(T item)
        {
            Node<T> t = new Node<T>(item);

            if (last != null)
            {
                last.next = t;
            }
            last = t;

            if (first == null)
            {
                first = last;
            }
        }

        public T remove()
        {
            if (first == null)
            {
                throw new Exception();
            }

            T data = first.data;
            first = first.next;

            if (first == null)
            {
                last = null;
            }
            return data;
        }

        public T peek()
        {
            if (first == null)
            {
                throw new Exception();
            }
            return first.data;
        }

        public Boolean isEmpty()
        {
            return first == null;
        }
    }
}
