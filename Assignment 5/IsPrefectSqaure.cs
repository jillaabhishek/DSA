using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_5
{
    /// <summary>
    /// Given a positive integer num, write a program that returns True if num is a perfect 
    /// square else return False.Do not use built-in functions like sqrt.Also, talk about the time
    /// complexity of your code.
    /// </summary>
    public class IsPrefectSqaure
    {
        /// <summary>
        /// Test Cases:
        /// Input: 16
        /// Output: True
        /// 
        /// Input: 14
        /// Output: False
        /// </summary>
        public bool FindSqaureRootFirstApproach(int number)
        {
            int min = 0;
            int max = number;
            int res = 0;
            while (max - min > 0)
            {
                res = min + (max - min) / 2;
                int numSqrt = res * res;

                if (numSqrt == number)
                    return true;
                else if (Math.Abs(max - min) == 1 && (min * min) < number && (max * max) > number)                
                    return false;                
                else if (numSqrt > number)                
                    max = res;                
                else                
                    min = res;                
            }

            return false;
        }
    }
}
