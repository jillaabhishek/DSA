using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_8
{
    //https://leetcode.com/problems/sort-colors/
    /// <summary>
    /// Given array nums with n objects colored red, white, or blue, sort them in place so that the objects of the same color are adjacent, with the colors in the order red, white, and blue. We will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
    /// Solve this question without using the library sort function. For example:
    /// Nums = [2,0,2,1,1,0]
    /// Result = [0,0,1,1,2,2]
    /// 
    /// </summary>
    public class SortColor
    {
        Random random = new Random();
        public void Run()
        {
            //int[] nums = new int[6] { 2, 0, 2, 1, 1, 0 };
            int[] nums = new int[3] { 2, 0, 1 };
            int p = 0;
            int q = nums.Length - 1;

            SortColorArrayUsingQS(nums, p, q);
            Console.WriteLine("Sort Color: " + String.Join(",", nums));
        }

        public int[] SortColorArrayUsingQS(int[] nums, int p, int q)
        {
            if (p < q)
            {
                int mid = RandomizeParitionQS(nums, p, q);

                SortColorArrayUsingQS(nums, p, mid - 1);
                SortColorArrayUsingQS(nums, mid + 1, q);

            }
            return nums;
        }

        public int RandomizeParitionQS(int[] nums, int p, int q)
        {
            if (p <= q)
            {
                var pivotElement = random.Next(p, q);
                (nums[p], nums[pivotElement]) = (nums[pivotElement], nums[p]);
            }

            return PartitionQS(nums, p, q);
        }

        public int PartitionQS(int[] nums, int p, int q)
        {
            int pivot = nums[p];
            int i = p;

            for (int j = i + 1; j <= q; j++)
            {
                if (nums[j] <= pivot)
                {
                    i++;
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }
            (nums[i], nums[p]) = (nums[p], nums[i]);
            return i;
        }
    }
}
