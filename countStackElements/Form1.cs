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

namespace countStackElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stack = new MyStack();
        }

        MyStack stack;

        private void addButton_Click(object sender, EventArgs e)
        {
            stack.push((int)inputNumber.Value);
            stackOutput.Text = inputNumber.Value + Environment.NewLine + stackOutput.Text;
            inputNumber.Value = 0;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!stack.isEmpty)
            {
                stack.pop();
                stackOutput.Text = stackOutput.Text.Substring(stackOutput.Text.IndexOf(Environment.NewLine)+1);
            }
        }

        private void countElements_Click(object sender, EventArgs e)
        {
            countElementsOutput.ResetText();
            countElementsOutput.Text = stack.count.ToString();
        }
    }
}
