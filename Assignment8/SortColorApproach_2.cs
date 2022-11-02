using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment8
{
    internal class SortColorApproach_2
    {
        public void Run()
        {
            int[] nums = new int[6] { 2, 0, 2, 1, 1, 0 };
            //int[] nums = new int[3] { 2, 0, 1 };
            int p = 0;
            int q = nums.Length - 1;

            Sort(nums, p, q);

            Console.WriteLine("Sort Color: " + String.Join(",", nums));
        }

        public int[] Sort(int[] nums, int p, int q)
        {
            int curr = 0;
            while (curr <= q)
            {
                if (nums[curr] == 0)
                {
                    (nums[p], nums[curr]) = (nums[curr], nums[p]);
                    p++;
                    curr++;
                }

                else if (nums[curr] == 2)
                {
                    (nums[q], nums[curr]) = (nums[curr], nums[q]);
                    q--;
                }
                else
                    curr += 1;
            }

            return nums;
        }
    }
}
