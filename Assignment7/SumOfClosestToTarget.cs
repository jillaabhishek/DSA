using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_7
{
    public class SumOfClosestToTarget
    {
        //Question
        /// <summary>
        /// 1. Given an integer array nums of length n and an integer target, find three integers in nums
        ///    such that the sum is closest to the target.[Amazon]
        ///    You need to return the sum of three integers.

        /// </summary>
        public void Run()
        {
            //Driver Code
            int[] arr = new int[6] { -1,2, 1, -4, 1, 2 };//{ 22, 11, 44, 11, 22 };
            //{ 2, 1, -4, 1, 2 };
            int target = 1;

            //Expected Output: [-1+2+1] = 2 (The sum that is closest to the target is 2)

            var result = GetClosestSumOfInteger(arr, target);
            var result2 = GetClosestSumOfInteger_2(arr, target);

            Console.WriteLine(result);
            Console.WriteLine(result2);
        }



        // three pointer Approach
        //Brute Force Approach

        //Complexity Analysis
        //There are three loops  2 for & 1 while. 
        //Total O(n) =  O(n^3) + C

        public object GetClosestSumOfInteger(int[] arr, int target)
        {
            object output = new object();
            int prevDiff = int.MaxValue;
            int arrLen = arr.Length - 1;
            bool isTargetNegative = target < 0;

            for (int i = 0; i < arrLen; i++)        // It will run (N) number of times   
            {
                for (int j = i + 1; j < arrLen; j++) // it will run N number of times 
                {
                    int k = arrLen;

                    while (k > j)
                    {
                        var sumOfInterger = arr[i] + arr[j] + arr[k];
                        int currentDiff = isTargetNegative ? (sumOfInterger - target) : Math.Abs(sumOfInterger - target);

                        if (sumOfInterger == target)
                        {
                            output = ("[" + arr[i] + "+" + arr[j] + "+" + arr[k] + "] = " + sumOfInterger, "The sum that is closest to the target is " + sumOfInterger);
                            return output;
                        }
                        else if (prevDiff > currentDiff)
                        {
                            prevDiff = currentDiff;
                            output = ("[" + arr[i] + "+" + arr[j] + "+" + arr[k] + "] = " + sumOfInterger, "The sum that is closest to the target is " + sumOfInterger);
                        }

                        k--;
                    }
                }
            }

            return output;
        }




        //Two Pointer Approach

        //Complexity Analysis
        //Bubble sort will take O(N^2)
        //There are two loops  for & while. It will also run for N times 
        // O(N^2)
        //Total O(n) =  O(n^2) + O(n^2)
        // = O(n^2)

        /// <summary>
        /// First sort the array and then loop through it
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public object GetClosestSumOfInteger_2(int[] arr, int target)
        {
            arr = BubbleSortArray(arr); // O(N^2)

            object output = new object();
            int arrLen = arr.Length - 1;
            int prevDiff = int.MaxValue;
            bool isTargetNegative = target < 0;

            for (int i = 0; i < arr.Length - 1; i++)       // it will run for N - 2 times.
            {
                int j = i + 1;
                int k = arrLen;

                while (k > j)
                {
                    var sumOfInterger = arr[i] + arr[j] + arr[k];
                    int currentDiff = isTargetNegative ? (target - sumOfInterger) : Math.Abs(target - sumOfInterger);

                    if (sumOfInterger == target)
                    {
                        output = ("[" + arr[i] + "+" + arr[j] + "+" + arr[k] + "] = " + sumOfInterger, "The sum that is closest to the target is " + sumOfInterger);
                        return output;
                    }
                    else if (prevDiff > currentDiff)
                    {
                        prevDiff = currentDiff;
                        output = ("[" + arr[i] + "+" + arr[j] + "+" + arr[k] + "] = " + sumOfInterger, "The sum that is closest to the target is " + sumOfInterger);
                    }

                    // If sum is greater than x then decrement
                    // the second pointer to get a smaller sum
                    if (sumOfInterger > target)
                    {
                        k--;
                    }
                    // Else increment the first pointer
                    // to get a larger sum
                    else
                    {
                        j++;
                    }

                }
            }

            return output;
        }

        public int[] BubbleSortArray(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (var j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }

            return arr;
        }
    }
}
