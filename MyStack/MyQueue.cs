using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class MyQueue
    {
        QueueNode head;
        QueueNode tail;

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
                    QueueNode temp = head;
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

        public MyQueue()
        {

        }

        public void Enqueue(int inf)
        {
            QueueNode newNode = new QueueNode(inf);
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

        public int Dequeue()
        {
            if (!isEmpty)
            {
                int result = head.inf;
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
            else return -1;
        }

        public void Remove(int inf)
        {
            if (head.inf == inf)
            {
                Dequeue();
            } else {
                QueueNode temp = head;
                bool elementFound = false;
                while (!(temp == tail))
                {
                    if (temp.next.inf == inf)
                    {
                        elementFound = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (elementFound)
                {
                    int check = temp.next.inf;
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

        public int[] Print()
        {
            int[] output = new int[count];
            if (!isEmpty)
            {
                QueueNode temp = head;
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
                QueueNode temp = head;
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
