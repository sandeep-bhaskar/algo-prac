using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting.Sorting
{
    public class SelectionSort : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 5, 6, 4, 6, 8, 5 };
            PrintSortedList(list);
        }

        public void PrintSortedList(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[min_index])
                        min_index = j;
                }

                int temp = list[min_index];
                list[min_index] = list[i];
                list[i] = temp;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
