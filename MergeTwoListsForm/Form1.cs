using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sort;

namespace MergeTwoListsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> first;
        List<int> second;

        private void generate_first_list_Click(object sender, EventArgs e)
        {
            first = GenerateRandomList();           
            first_list.Clear();
            foreach (int number in first) first_list.AppendText(number + Environment.NewLine);
        }

        private void generate_second_list_Click(object sender, EventArgs e)
        {
            second = GenerateRandomList();
            second_list.Clear();
            foreach (int number in second) second_list.AppendText(number + Environment.NewLine);
        }

        private void merge_Click(object sender, EventArgs e)
        {
            List<int> merged = MergeTwoLists.Merge(first, second);
            List<int> deletedElements = MergeTwoLists.deletedElements;
            result_list.Clear();
            deleted_elements.Clear();
            foreach (int number in merged) result_list.AppendText(number + Environment.NewLine);
            foreach (int number in deletedElements) deleted_elements.AppendText(number + Environment.NewLine);
        }

        public List<int> GenerateRandomList()
        {
            List<int> result = new List<int>();
            Random random = new Random();
            int length = random.Next(1000);     //максимальный размер листов
            result.Add(random.Next(-1000, 10000));  
            for (int i = 0; i < length; i++)
            {
                result.Add(random.Next(result[result.Count - 1] - 1000, result[result.Count - 1] + 1));
            }
            return result;
        }

        
    }
}
