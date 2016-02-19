using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lists;

namespace CountingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputNumberN_ValueChanged(object sender, EventArgs e)
        {
            inputNumberK.Maximum = inputNumberN.Value;
        }

        private void calculateNumberOfLast_Click(object sender, EventArgs e)
        {
            int numberN = (int)inputNumberN.Value;
            int numberK = (int)inputNumberK.Value;
            MyQueue queue = new MyQueue();
            for (int i = 1; i <= numberN; i++) queue.Enqueue(i);
            outputNumberOfLast.ResetText();
            queue.findLastGame(numberK);
            outputNumberOfLast.Text = queue.Dequeue().ToString();
        }
    }
}
