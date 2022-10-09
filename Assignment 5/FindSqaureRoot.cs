using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    /// <summary>
    /// Compute and return the square root of x, where x is guaranteed to be a non-negative 
    /// integer.And since the return type is an integer, the decimal digits are truncated and only 
    /// the integer part of the result is returned.Also, talk about the time complexity of your code.
    /// </summary>
    public class FindSqaureRoot
    {
        /// <summary>
        /// Example
        /// Test Cases:
        /// Input: 4 
        /// Output: 2
        /// 
        /// Input: 8
        /// Output: 2
        /// Explanation: The square root of 8 is 2.8284…., the decimal part is truncated and 2 is returned.
        /// 
        /// </summary>

        //Time Complexity: O(n) = Ol(logn)
        public int FindSqaureRootFirstApproach(int number)
        {
            int min = 0;
            int max = number;
            int res = 0;
            while (max - min > 0)
            {
                res = min + (max - min) / 2;
                int numSqrt = res * res;

                if (numSqrt == number)
                    return min;
                else if (Math.Abs(max - min) == 1 && (min * min) < number && (max * max) > number)
                {
                    return res;
                }
                else if (numSqrt > number)
                {
                    max = res;
                }
                else
                {
                    min = res;
                }
            }

            return res;
        }
    }
}
