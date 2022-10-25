using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.QuickSort
{
    public class SelectionProcedureQuickSort
    {
        public void Run()
        {
            int[] arr = new int[13] { 50, 40, 70, 10, 30, 90, 45, 67, 79, 12, 100, 110, -10 };
            int p = 0;
            int q = arr.Length - 1;
            int k = 2;

            var result = SelectionProcedureQS(arr, p, q, k);
            Console.WriteLine($"The {k}th smallest number: {result}");
        }

        public int? SelectionProcedureQS(int[] arr, int p, int q, int k)
        {
            int mid = Partitioner(arr, p, q);
            if (mid == k)
                return arr[mid - 1];
            else if (k < mid)
            {
                return SelectionProcedureQS(arr, p, mid - 2, k);
            }
            else
            {
                return SelectionProcedureQS(arr, mid, q, k);
            }
        }

        public int Partitioner(int[] arr, int p, int q)
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

            return i + 1;
        }
    }
}
