using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    /// <summary>
    /// You are a product manager and currently leading a team to develop a new product.    
    /// Unfortunately, the latest version of your product fails the quality check.Since each
    /// version is developed based on the previous version, all the versions after a bad version
    /// are also bad. Suppose you have n version and you want to find out the first bad one,
    /// which causes all the following ones to be bad.Also, talk about the time complexity of your code.
    /// </summary>
    public class ArrayProblemWithoutLength
    {
        /// <summary>
        /// Test Cases: 
        /// Input: [0,0,0,1,1,1,1,1,1]
        /// Output: 3
        /// Explanation: 0 indicates a good version and 1 indicates a bad version.
        /// So, the index of the first 1 is at 3. Thus, the output is 3

        /// </summary>
        /// <returns></returns>
        public int Run()
        {
            int[] arr = new int[12] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };
            if (arr[0] == 1)
                return 0;

            int i = 1, j = 2;

            // Time Complexity: O(n) = O(logn)
            return BinarySearchArray(arr, i, j);
        }


        public int BinarySearchArray(int[] arr, int i, int j)
        {
            var mid = i + (j - i) / 2;

            if (arr[mid] == 1 && arr[mid - 1] == 0)
                return mid;
            else if(arr[mid] == 1)
            {
                return BinarySearchArray(arr, i, mid - 1);
            }
            else
            {
                i = mid + 1;
                j = i + i;

                return BinarySearchArray(arr, i, j);
            }
        }
    }
}
