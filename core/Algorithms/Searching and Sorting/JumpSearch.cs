using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting
{
    public class JumpSearch : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Search(list, 9, 0, list.Count));
        }

        private bool Search(List<int> list, int v1, int v2, int count)
        {
            throw new NotImplementedException();
        }
    }
}
