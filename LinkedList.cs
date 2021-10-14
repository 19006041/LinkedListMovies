using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMovies
{
    public class LinkedList<T>
    {
        private cNode<T> head;
        private cNode<T> tail;
        private cNode<T> current;
        private int size;

        private class cNode<R>
        {
            public R data;
            public cNode<R> next;
            public cNode<R> previous;

            public cNode(R data)
            {
                this.data = data;
                this.next = null;
                this.previous = null;
            }
        }
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }


        public T this[int i]
        {
            get
            {
                cNode<T> temp = head;
                if(i > size)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        temp = temp.next;
                    }
                }
                return temp.data;
            }
        }
        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public T getHead()
        {
            return head.data;
        }
        public T getTail()
        {
            return tail.data;
        }

        public T initCurrent()
        {
            current = head;
            return current.data;
        }

        public T getCurrent()
        {
            return current.data;
        }

        public T getNext()
        {
            current = current.next;
            return current.data;
        }

        public T getPrevious()
        {
            current = current.previous;
            return current.data;
        }
        public void Append(T data)
        {
            cNode<T> node = new cNode<T>(data);
            if (IsEmpty())
            {
                head = node;
                tail = node;
                current = node;
            }
            else
            {
                tail.next = node;
                node.previous = tail;
                tail = node;
                tail.next = head;
                head.previous = tail;
            }
            size++;
        }


        public void Prepend(T data)
        {
            cNode<T> node = new cNode<T>(data);
            if (IsEmpty())
            {
                head = node;
                tail = node;
                current = node;
            }
            else
            {
                node.next = head;
                head.previous = node;
                head = node;
                head.previous = tail;
            }
            size++;
        }

        public override string ToString()
        {
            string output = "";
            cNode<T> current = head;
            while (current != null)
            {
                output += current.data.ToString() + Environment.NewLine;
                current = current.next;
            }
            return output;
        }

    }
}
