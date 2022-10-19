using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_9
{
    public class CountNumberOfInversion
    {
        public void Run()
        {
            int[] nums = new int[] { 70, 50, 60, 10, 20, 30, 80, 15 };
            int i = 0;
            int j = nums.Length - 1;

            int finalCount = CountInversion(nums, i, j);

            Console.WriteLine($"Total Inversion Count: {finalCount}");
        }

        /// <summary>
        /// Time Complexity: T(n) = 2T(n/2) + n
        /// T(n) = O(nlogn)
        /// </summary>
        public int CountInversion(int[] nums, int i, int j)
        {
            int totalCount = 0;

            if (i < j)
            {
                int mid = i + (j - i) / 2;

                totalCount += CountInversion(nums, i, mid);
                totalCount += CountInversion(nums, mid + 1, j);

                totalCount += MergeProcedure(nums, i, mid, j);
            }


            return totalCount;
        }

        /// <summary>
        ///  Implementated using Merge Procedure
        ///  n1+n2 = N 
        ///  MergeProcedure time complexity = O(N)
        /// </summary>
        public int MergeProcedure(int[] nums, int i, int mid, int j)
        {
            int inversionCount = 0;

            //Find number of element present in first subtree (mid - i + 1)
            int n1 = mid - i + 1;

            //Find number of element present in second subtree (j - (mid + 1) + 1) == (j - mid)
            int n2 = j - mid;

            //If Leftsubtree & rightsubtree only have 1 element and left element is greater than right.
            //We are incrementing the inversionCount;
            if (n1 == 1 && n2 == 1 && nums[i] > nums[j])
            {
                inversionCount++;
            }
            else
            {
                //Storing left index (i) to variable A
                int a = i;
                //Storing mid index (mid) to variable C. Also adding 1 to get start index of rightsubtree
                int c = mid + 1;
                while ((a <= mid) && (c <= j))
                {
                    //At this point we know, both leftsubtree & rightsubtree array are sorted.
                    //If leftsubtree element smaller then increate leftsubtree index with +1;
                    if (nums[a] <= nums[c])
                    {
                        a++;
                    }
                    else
                    {
                        c++;
                        // If nums[a] > nums[c], then nums[c+1], nums[c+2] will also be greater. 
                        // So increamenting inversioncount to mid+1 - a; Getting all rightsubtree remaining element;
                        inversionCount += (mid + 1 - a);
                    }
                }
            }


            int[] leftSubTree = new int[n1];
            int[] rightSubTree = new int[n2];

            for (int m = 0; m < n1; m++)
                leftSubTree[m] = nums[m + i];


            for (int n = 0; n < n2; n++)
                rightSubTree[n] = nums[n + mid + 1];

            int p = 0;
            int q = 0;
            int k = i;

            while (p < n1 && q < n2)
            {
                if (leftSubTree[p] <= rightSubTree[q])
                {
                    nums[k] = leftSubTree[p];
                    p++;
                }
                else
                {
                    nums[k] = rightSubTree[q];
                    q++;
                }

                k++;
            }

            while (p < n1)
            {
                nums[k] = leftSubTree[p];
                k++;
                p++;
            }

            while (q < n2)
            {
                nums[k] = rightSubTree[q];
                k++;
                q++;
            }

            return inversionCount;
        }
    }
}
