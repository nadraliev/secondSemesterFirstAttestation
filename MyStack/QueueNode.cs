using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class QueueNode<T>
    {

        public T inf { get; set; }
        public QueueNode<T> next { get; set; }

        public QueueNode(T inf)
        {
            this.inf = inf;
        }

    }
}
