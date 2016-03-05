using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class MergeTwoLists
    {

        public static List<int> deletedElements { get; set; }


        public static List<int> Merge(List<int> first, List<int> second)
        {
            deletedElements = new List<int>();
            List<int> result = new List<int>();
            int firstListNumber = first[0];
            int secondListNumber = second[0];
            int counterFirst = 0;
            int counterSecond = 0;
            while (counterFirst < first.Count && counterSecond < second.Count)
            {
                if (firstListNumber >= secondListNumber)
                {
                    result.Add(firstListNumber);
                    if (++counterFirst < first.Count)
                    firstListNumber = first[counterFirst];
                } else
                {
                    result.Add(secondListNumber);
                    if (++counterSecond < second.Count)
                    secondListNumber = second[counterSecond];
                }
            }
            if (counterFirst == first.Count)
            {
                for (int i = counterSecond; i < second.Count; i++) result.Add(second[i]);
            } else if (counterSecond == second.Count)
            {
                for (int i = counterFirst; i < first.Count; i++) result.Add(first[i]);
            }
            DeleteDuplicates(result);
            return result;
        }

        public static void DeleteDuplicates(List<int> input)
        {
            deletedElements.Clear();
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i-1])
                {
                    deletedElements.Add(input[i]);
                    input.RemoveAt(i);
                }
            }
        }
    }
}
