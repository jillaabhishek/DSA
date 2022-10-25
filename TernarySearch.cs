using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class TernarySearch
    {
        public int Run()
        {
            int[] arr = new int[9] { 20, 25, 47, 56, 59, 63, 65, 79, 82 };
            int i = 0;
            int j = arr.Length - 1;
            int key = 59;

            return TernarySearchAlgo(arr, i, j, key);
        }

        public int TernarySearchAlgo(int[] arr, int i, int j, int key)
        {
            while (i <= j)
            {
                int mid1 = i + (j - i) / 3;
                int mid2 = j - (j - 1) / 3;

                if (arr[mid1] == key)
                    return mid1;
                else if (arr[mid2] == key)
                    return mid2;
                else if (arr[mid1] > key)
                {
                    return TernarySearchAlgo(arr, i, mid1 - 1, key);
                }
                else if (arr[mid2] < key)
                {
                    return TernarySearchAlgo(arr, mid2 - 1, j, key);
                }
                else
                {
                    return TernarySearchAlgo(arr, mid1 + 1, mid2 - 1, key);
                }
            }
            return -1;
        }

    }
}
