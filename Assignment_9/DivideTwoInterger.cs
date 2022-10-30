using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_9
{
    //https://leetcode.com/problems/divide-two-ints/
    /// <summary>
    /// Given two ints, dividend and divisor, divide the two ints 
    /// without using multiplication, division, and mod operator.

    /// </summary>
    public class DivideTwoInterger
    {
        public void Run()
        {
            //Diver Code
            int dividend = 125;
            int divisor = 5;

            var result = Find(dividend, divisor);
            Console.WriteLine($"Division of {dividend} by {divisor} is: " + result);
        }

        public int Find(int dividend, int divisor)
        {
            int sign = divisor > 0 == dividend > 0 ? 1 : -1;

            //Converting the negative number to positive
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);
            int quotient = 0, subQuot = 0;


            //Logic
            while (dividend - divisor >= 0)
            {
                for (subQuot = 0; dividend - (divisor << subQuot << 1) >= 0; subQuot++) ;

                //Adding to the quotient
                quotient += 1 << subQuot;

                //Substract from dividend to start over with the remaining
                dividend -= divisor << subQuot;
            }

            return quotient * sign;
        }

    }
}
