using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class MyQueue<T>
    {
        QueueNode<T> head;
        QueueNode<T> tail;

        public bool isEmpty {
            get
            {
                return head == null;
            }
        }

        public int count
        {
            get
            {
                if (head == null) return 0;
                else
                {
                    QueueNode<T> temp = head;
                    int result = 0;
                    do
                    {
                        temp = temp.next;
                        result++;
                    } while (temp != head);
                    return result;
                }
            }
        }

        
        public bool isProgression
        {
            get
            {
                switch (count)
                {
                    case 0:
                        return false;
                        break;
                    case 1:
                        return false;
                        break;
                    case 2:
                        return true;
                        break;
                    default:
                        dynamic first = head.inf;
                        dynamic second = head.next.inf;
                        dynamic third = head.next.next.inf;
                        dynamic difference = .0000000000001;
                        return ((second - first) - (third - second) <= difference || (second / first) - (third / second) <= difference) ;
                        break;
                }
            }
        }
        

        public MyQueue()
        {

        }

        public void Enqueue(T inf)
        {
            QueueNode<T> newNode = new QueueNode<T>(inf);
            if (this.isEmpty)
            {
                head = newNode;
                tail = newNode;
                newNode.next = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
                tail.next = head;
            }
        }

        public T Dequeue()
        {
            if (!isEmpty)
            {
                T result = head.inf;
                if (count > 1)
                {
                    tail.next = head.next;
                    head = head.next;
                } else
                {
                    head = null;
                    tail = null;
                }
                return result;
            }
            else return (T)Convert.ChangeType(-1, typeof(T));
        }

        public void Remove(T inf)
        {
            if (head.inf.Equals(inf))
            {
                Dequeue();
            } else {
                QueueNode<T> temp = head;
                bool elementFound = false;
                while (!(temp == tail))
                {
                    if (temp.next.inf.Equals(inf))
                    {
                        elementFound = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (elementFound)
                {
                    T check = temp.next.inf;
                    if (temp.next == tail)
                    {
                        tail = temp;
                        temp.next = temp.next.next;
                    } else
                    {
                        temp.next = temp.next.next;
                    }
                }
            }
        }

        public T[] Print()
        {
            T[] output = new T[count];
            if (!isEmpty)
            {
                QueueNode<T> temp = head;
                output[0] = temp.inf;
                for (int i = 1; i < count; i++)
                {
                    temp = temp.next;
                    output[1] = temp.inf;
                }
            }
            return output;
        }

        public void findLastGame(int k)
        {
            if (!isEmpty)
            {
                int i = 0;
                QueueNode<T> temp = head;
                while (count > 1)
                {
                    i++;
                    if (k == i)
                    {
                        Remove(temp.inf);
                        i = 0;
                    }
                    temp = temp.next;
                }
            }
        }

    }
}
