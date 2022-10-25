using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algo
{
    public class BubbleSort
    {
        public string Run()
        {
            int[] arr = new int[8] { 70, 20, 50, 30, 90, 5, 15, -1 };
            int[] result = BubbleSortAlgo(arr);

            return String.Join(",", result);
        }

        public int[] BubbleSortAlgo(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (var j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }

            return arr;
        }
    }
}
