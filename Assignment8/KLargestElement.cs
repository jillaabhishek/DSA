using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_8
{
    //https://leetcode.com/problems/kth-largest-element-in-an-array/
    /// <summary>
    /// Question 3
    /// 3.	Kth Largest Element in an numsay [Facebook]
    /// Given an integer numsay nums and an integer k, return the kth largest element present in an numsay.
    /// For example:
    /// nums = [40, 25, 68, 79, 52, 66, 89, 97]
    /// k = 2
    /// result = 89

    /// </summary>
    public class KLargestElement
    {
        Random random = new Random();

        public int Run()
        {
            int[] nums = new int[8] { 40, 25, 68, 79, 52, 66, 89, 97 };
            //int[] nums = new int[2] { 2, 1 };
            //int[] nums = new int[6] { 3, 2, 1, 5, 6, 4 };
            int k = 2;

            int p = 0;
            int q = nums.Length - 1;

            if (nums.Length == 1)
                return nums[0];

            int result = SelectionProcedureQS(nums, p, q, k);
            Console.WriteLine($"The {k}th Largest number Index: {result}");

            return result;
        }

        public int SelectionProcedureQS(int[] nums, int p, int q, int k)
        {
            int mid = PartitionWithRandomPivot(nums, p, q);

            if (k == mid)
                return nums[mid - 1];
            else if (k < mid)
                return SelectionProcedureQS(nums, p, mid - 2, k);
            else
                return SelectionProcedureQS(nums, mid, q, k);
        }

        public int PartitionWithRandomPivot(int[] nums, int p, int q)
        {
            if (p <= q)
            {
                int pivotIndex = random.Next(p, q);
                (nums[p], nums[pivotIndex]) = (nums[pivotIndex], nums[p]);
            }

            return PartitionQS(nums, p, q);
        }

        public int PartitionQS(int[] nums, int p, int q)
        {
            int pivot = nums[p];
            int i = p;

            for (int j = i + 1; j <= q; j++)
            {
                if (-nums[j] <= -pivot)
                {
                    i++;
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }

            (nums[i], nums[p]) = (nums[p], nums[i]);

            return i + 1;
        }
    }
}
