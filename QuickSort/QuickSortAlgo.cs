using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.QuickSort
{
    /// <summary>
    /// Recurrence Relation
    /// Best care/Average = T(n) = T(n/2) + t(n/2) + n 
    /// T(n) = 2T(n/2) + n
    /// T(n) = O(nlogn)
    /// 
    /// Worst Case 
    /// T(n) = t(n-1) + n
    /// T(n) = O(n^2)
    /// 
    /// </summary>
    public class QuickSortAlgo
    {
        public void Run()
        {
            int[] arr = new int[13] { 50, 40, 70, 10, 30, 90, 45, 67, 79, 2, 100, 110, -10 };
            int p = 0;
            int q = arr.Length - 1;

            Console.WriteLine("Quick Sort Started: " + DateTime.Now);
            var result = QuickSort(arr, p, q);
            Console.WriteLine(String.Join(",", result));
            Console.WriteLine("Quick Sort Ended: " + DateTime.Now);
        }

        //Time Complexity:T(m-p) + t(q-m) + n
        public int[] QuickSort(int[] arr, int p, int q)
        {
            if (p < q)
            {
                int mid = Partition(arr, p, q);

                QuickSort(arr, p, mid - 1);
                QuickSort(arr, mid + 1, q);
            }

            return arr;
        }

        //Time Complexity O(m)
        public int Partition(int[] arr, int p, int q)
        {
            int pivot = arr[p];
            int i = p;

            for (int j = i + 1; j <= q; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i], arr[p]) = (arr[p], arr[i]);

            return i;
        }
    }
}

        

