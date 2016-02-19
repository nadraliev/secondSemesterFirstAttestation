﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class StackNode
    {
        public int inf { get; set; }
        public StackNode next { get; set; }

        public StackNode(int inf)
        {
            this.inf = inf;
        }
    }
}
