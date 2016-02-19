using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class MyStack
    {
        StackNode head;

        public int count {
            get
            {
                int result = 0;
                if (this.isEmpty) return 0;
                MyStack temp = new MyStack();
                while (!this.isEmpty)
                {
                    temp.push(this.pop());
                    result++;
                }
                temp.reverse();
                head = temp.head;
                return result;
            }
        }

        public bool isEmpty {
            get
            {
                return head == null;
            }
        }

        public MyStack()
        {

        }

        public void push(int inf)
        {
            StackNode newNode = new StackNode(inf);
            if (head != null) newNode.next = head;
            head = newNode;
        }

        public int pop()
        {
            int result = head.inf;
            head = head.next;
            return result;
        }

        public void reverse()
        {
            MyStack temp = new MyStack();
            while (!this.isEmpty) temp.push(this.pop());
            if (!temp.isEmpty) head = temp.head;
        }

    }
}
