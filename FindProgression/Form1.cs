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
using System.IO;

namespace FindProgression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {
            string path = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(path);
                MyQueue<double> myQueue = new MyQueue<double>();
                string[] oneLineSplitted;
                foreach (string oneLine in lines)
                {
                    oneLineSplitted = oneLine.Split(' ');
                    foreach (string number in oneLineSplitted)
                        try
                        {
                            myQueue.Enqueue(Double.Parse(number));
                        }
                        catch (Exception) { }
                }
                result_label.Text = "Эта последовательность ";
                if (myQueue.isArithmeticProgression && myQueue.isGeometricProgression) result_label.Text += "является арифметической и геометрической ";
                else if (myQueue.isArithmeticProgression) result_label.Text += "является арифметической ";
                else if (myQueue.isGeometricProgression) result_label.Text += "является геометрической ";
                else result_label.Text += "не является ";
                result_label.Text += "прогрессией";
            }
        }
    }
}
