using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_9
{
    //https://leetcode.com/problems/powx-n/
    /// <summary>
    /// Implement pow(x,n) which calculates x raised to the power n (i.e. x^n)
    /// For example: x = 2.00000, n = -2
    /// Output: 0.25000
    /// Explanation: 2^-2 =½^2 = ¼ = 0.25
    /// </summary>
    public class FindPowerOfElement
    {
        public void Run()
        {
            double element = 2.10;
            int power = 3;

            if (power < 0)
                element = 1 / element;

            double output = FindPower(element, power);

            Console.WriteLine($"{element} power of {power} is: " + output);
        }


        /// <summary>
        /// T(n) = T(n/2)
        /// T(n) = O(Logn)
        /// </summary>
        public double FindPower(double element, int power)
        {
            if (power == 0) return 1;

            if (power == 1) return element;

            //We are dividing the power into two parts
            int mid = power / 2;

            //We are going to find power of leftside. Because result of left and right will be same.
            //In the next statement we will multiply the leftside result into itself. 
            //By doing that, we will get the power of element at that stage
            var leftSideOutput = FindPower(element, mid);

            //Multiply itself to get the total value at that level. 
            var result = leftSideOutput * leftSideOutput;

            // Now checking if power is even or odd
            //If even, we will simply return the result
            if (power % 2 == 0)
                return result;
            else // In Odd case, we have again, multiple the result with element. 
                return result * element;
        }
    }
}
