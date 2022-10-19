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
            int dividend = 123456;//2147483647; //-2147483648;
            int divisor = -3;

            //var result = CalculateDivision(dividend, divisor);
            var result = Find(dividend, divisor);
            Console.WriteLine($"Division of {dividend} by {divisor} is: " + result);
        }

        public int Find(int dividend, int divisor)
        {
            //if (dividend == int.MinValue && divisor == -1) return int.MaxValue; 
            //Cornor case when -2^31 is divided by -1 will give 2^31 which doesnt exist so overflow 

            //bool negative = dividend < 0 ^ divisor < 0; 
            //Logical XOR will help in deciding if the results is negative only if any one of them is negative

            int sign = divisor > 0 == dividend > 0 ? 1 : -1;

            //Covering the Constraints
            if (dividend > int.MaxValue)
                return sign * int.MaxValue - 1;

            if (dividend < int.MinValue)
                return sign * int.MinValue;

            if (dividend == int.MinValue && (divisor == -1 || divisor == 1))
            {
                if (divisor == -1)
                    return sign * int.MinValue - 1;

                return sign * int.MinValue;
            }

            if (dividend == int.MaxValue && (divisor == -1 || divisor == 1))
                return sign * int.MaxValue;

            if (divisor == 1)
                return dividend;

            if (divisor == -1)
                return -(dividend);

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

        public int CalculateDivision(int dividend, int divisor)
        {
            int sign = divisor > 0 == dividend > 0 ? 1 : -1;

            if (dividend > int.MaxValue)
                return sign * int.MaxValue - 1;

            if (dividend < int.MinValue)
                return sign * int.MinValue;

            if (dividend == int.MinValue && (divisor < 0 || divisor == 1))
            {
                if (divisor == -1)
                    return sign * int.MinValue - 1;

                return sign * int.MinValue;
            }

            if (dividend == int.MaxValue && (divisor < 0 || divisor == 1))
                return sign * int.MaxValue;

            if (divisor == 1)
                return dividend;

            if (divisor == -1)
                return -(dividend);

            int _dividend = Math.Abs(dividend);
            int _divisor = Math.Abs(divisor);

            int quotient = 0;
            double currentDivisor = 0;

            while (currentDivisor <= _dividend)
            {
                currentDivisor += _divisor;

                if (currentDivisor == _dividend)
                {
                    quotient++;
                    return sign * quotient;
                }
                else if (currentDivisor < _dividend)
                {
                    quotient++;
                }
                else if (currentDivisor > _dividend)
                {
                    return sign * quotient;
                }
            }

            return sign * quotient;
        }
    }
}
