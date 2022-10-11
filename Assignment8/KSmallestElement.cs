using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.Assignment_8
{
    /// <summary>
    /// Question 1
    /// 1.	Kth smallest element [Amazon]
    /// Given an array of n-elements and an integer k, find the kth smallest element present in an array.
    /// For example:
    /// arr = [40, 25, 68, 79, 52, 66, 89, 97]
    /// k = 2
    /// result = 40
    /// 
    /// </summary>
    public class KSmallestElement
    {
        Random random = new Random();
        public void Run()
        {
            int[] arr = new int[8] { 40, 25, 68, 79, 52, 66, 89, 97 };
            int k = 2;

            int p = 0;
            int q = arr.Length - 1;

            int result = SelectionProcedureQS(arr, p, q, k);
            Console.WriteLine($"The {k}th smallest number: {result}");
        }

        public int SelectionProcedureQS(int[] arr, int p, int q, int k)
        {
            int mid = PartitionWithRandomPivot(arr, p, q);

            if (mid == k)
                return arr[mid - 1];
            else if (k < mid)
                return SelectionProcedureQS(arr, p, mid - 2, k);
            else
                return SelectionProcedureQS(arr, mid, q, k);
        }

        public int PartitionWithRandomPivot(int[] nums, int p, int q)
        {
            if (p >= q)
            {
                int pivotIndex = random.Next(p, q);
                (nums[p], nums[pivotIndex]) = (nums[pivotIndex], nums[p]);
            }

            return QSPartition(nums, p, q);
        }

        public int QSPartition(int[] arr, int p, int q)
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
