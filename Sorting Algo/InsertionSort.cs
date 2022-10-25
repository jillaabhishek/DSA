using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algo
{
    public class InsertionSort
    {
        public string Run()
        {
            int[] arr = new int[7] { 75, 90, 100, 85, 80, 10, 79 };

            int[] result = InsertionSortAlgo(arr);

            return String.Join(",", result);
        }

        public int[] InsertionSortAlgo(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                int keyVal = arr[i];

                while (j >= 0 && keyVal < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = keyVal;
            }

            return arr;

        }
    }
}
