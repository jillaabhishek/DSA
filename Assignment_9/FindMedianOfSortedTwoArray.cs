using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_9
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// 2. Given two sorted arrays num1 and num2 of size m and n respectively, return the median
    /// of the two sorted arrays.
    /// </summary>
    public class FindMedianOfSortedTwoArray
    {
        public double Run()
        {
            int[] nums1 = new int[4] { 1, 3, 4, 5 };
            int[] nums2 = new int[4] { 2, 7, 9, 10 };

            double medianValue = FindMedian(nums1, nums2);

            //var mergedArray = MergeTwoSortedArray(nums1, nums2);


            //var halfLength = mergedArray.Length / 2;
            //if (mergedArray.Length % 2 != 0)
            //{
            //    medianValue = mergedArray[halfLength];
            //}
            //else
            //{
            //    medianValue = ((double)mergedArray[halfLength] + (double)mergedArray[halfLength - 1]) / 2;
            //}

            Console.WriteLine($"Median: {medianValue}");
            return medianValue;
        }


        public double FindMedian(int[] nums1, int[] nums2)
        {
            // Check if num1 is smaller than num2
            // If not, then we will swap num1 with num2
            if (nums1.Length > nums2.Length)
                return FindMedian(nums2, nums1);

            // Lengths of two arrays
            int m = nums1.Length;
            int n = nums2.Length;

            //pointer for binarySearch
            int start = 0;
            int end = m;

            while (start <= end)
            {
                //partition 
                int partitionNums1 = (start + end) / 2;
                int partitionNums2 = (n + m + 1) / 2 - partitionNums1;

                // Edge cases

                // If there are no elements left on the left side after partition
                int maxLeftNums1 = partitionNums1 == 0 ? int.MinValue : nums1[partitionNums1 - 1];
                // If there are no elements left on the right side after partition
                int minRightNums1 = partitionNums1 == m ? int.MaxValue : nums1[partitionNums1];

                // If there are no elements left on the left side after partition
                int maxLeftNums2 = partitionNums2 == 0 ? int.MinValue : nums2[partitionNums2 - 1];
                // If there are no elements left on the right side after partition
                int minRightNums2 = partitionNums2 == n ? int.MaxValue : nums2[partitionNums2];

                // Check if we have found the match
                if (maxLeftNums1 <= minRightNums2 && maxLeftNums2 <= minRightNums1)
                {
                    // Check if the combined array is of even/odd length
                    if ((m + n) % 2 == 0)
                    {
                        return (Math.Max(maxLeftNums1, maxLeftNums2) + Math.Min(minRightNums1, minRightNums2)) / 2.0;
                    }
                    else
                    {
                        return Math.Max(maxLeftNums1, maxLeftNums2);
                    }
                }
                // If we are too far on the right, we need to go to left side
                else if (maxLeftNums1 > minRightNums2)
                {
                    end = partitionNums1 - 1;
                }
                // If we are too far on the left, we need to go to right side
                else
                {
                    start = partitionNums1 + 1;
                }
            }

            return -1;

        }


        //Time Complexity: O(m+n)
        public int[] MergeTwoSortedArray(int[] firstArr, int[] secondArr)
        {
            int p = 0;
            int q = 0;
            int k = 0;

            int n1 = firstArr.Length;
            int n2 = secondArr.Length;
            int[] arr = new int[n1 + n2];

            while (p < n1 && q < n2)
            {
                if (firstArr[p] <= secondArr[q])
                {
                    arr[k] = firstArr[p];
                    p++;
                }
                else
                {
                    arr[k] = secondArr[q];
                    q++;
                }

                k++;
            }

            while (p < n1)
            {
                arr[k] = firstArr[p];
                k++;
                p++;
            }

            while (q < n2)
            {
                arr[k] = secondArr[q];
                k++;
                q++;
            }

            return arr;
        }


        /// Approach 2
        /// https://leetcode.com/problems/median-of-two-sorted-arrays/discuss/2677478/Detailed-explanation-O(log(n%2Bm)-python3-binary-search-O(1)-slicing 
        /// <summary>
        /// 
        /// Here capital N = n + m;
        /// 
        /// Time Complexity in Odd Scenario:
        ///     T(N) = T(N/2)
        ///          = O(logN)
        ///          
        /// Time Complexity in Even Scenario:
        ///     T(N) = 2T(N/2)
        ///          = O(N)
        /// 
        /// </summary>
        public void Approach_2()
        {
            int[] nums1 = new int[1] { 3 };
            int[] nums2 = new int[3] { 1, 2, 4 };

            int mergedLength = nums1.Length + nums2.Length;

            double medianValue;
            if (mergedLength % 2 != 0)
            {
                medianValue = FindMedianElement(nums1, nums2, mergedLength / 2);
            }
            else
            {
                double first = (double)FindMedianElement(nums1, nums2, mergedLength / 2);
                double second = (double)FindMedianElement(nums1, nums2, mergedLength / 2 - 1);

                medianValue = (first + second) / 2;
            }

            Console.WriteLine($"The Median Value: {medianValue}");
        }

        public int FindMedianElement(int[] nums1, int[] nums2, int k)
        {
            int n1 = nums1.Length;
            int n2 = nums2.Length;

            int i1 = n1 / 2;
            int i2 = n2 / 2;

            if (n1 == 0)
                return nums2[k];
            if (n2 == 0)
                return nums1[k];

            int med1 = nums1[i1];
            int med2 = nums2[i2];


            if (i1 + i2 < k)
            {
                if (med1 < med2)
                {
                    var nums1Index = i1 + 1;

                    //we discard the first half of nums1
                    return FindMedianElement(nums1[nums1Index..], nums2, k - i1 - 1);
                }
                else
                {
                    var nums2Index = i2 + 1;
                    //otherwise we discard the first half of nums2
                    return FindMedianElement(nums1, nums2[nums2Index..], k - i2 - 1);
                }

            }
            else if (i1 + i2 >= k)
            {
                if (med1 > med2)
                {
                    //we discard the right half of nums1
                    return FindMedianElement(nums1[..i1], nums2, k);
                }
                else
                {
                    //otherwise we discard the right half of nums2.
                    return FindMedianElement(nums1, nums2[..i2], k);
                }
            }

            return -1;
        }

    }
}
