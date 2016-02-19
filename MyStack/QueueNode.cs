using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class QueueNode
    {

        public int inf { get; set; }
        public QueueNode next { get; set; }

        public QueueNode(int inf)
        {
            this.inf = inf;
        }

    }
}
