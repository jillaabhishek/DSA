using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.Assignment_8
{
    //https://leetcode.com/problems/majority-element/
    /// <summary>
    /// 
    /// Given array nums of size n, return the majority element present in the array.
    /// Assume that the majority element always exists in an array.
    /// For example: Nums = [2, 2, 1, 1, 1, 2, 2]
    ///     Output: 2
    /// </summary>
    /// Time Complexity: O(n)
    public class FindMajorityElement
    {
        public int Run()
        {
            int[] nums = new int[10] { 2, 3, 3, 1, 1, 3, 2, 3, 2, 3 };

            if (nums.Length == 1)
                return nums[0];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            int majorityElementCount = int.MinValue;
            int majorityElement = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (majorityElementCount > nums.Length / 2)
                    return majorityElement;

                if (!dic.ContainsKey(nums[i])) {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]] += 1;
                    if (dic[nums[i]] > majorityElementCount)
                    {
                        majorityElementCount = dic[nums[i]];
                        majorityElement = nums[i];
                    }
                }                
            }

            Console.WriteLine("Majority Element:" + majorityElement);
            return majorityElement;


            //Time Complexity will be O(nlogn)
            #region SolutionUsingHeapSort

            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(new IntMaxCompare());


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.TryGetValue(nums[i], out int value))
            //    {
            //        dic[nums[i]] = value + 1;
            //    }
            //    else
            //    {
            //        dic.Add(nums[i], 1);
            //    }
            //}

            //foreach (var item in dic)
            //{
            //    priorityQueue.Enqueue(item.Key, item.Value);
            //}

            //var majorityElement = priorityQueue.Dequeue();

            //Console.WriteLine($"Majority Element: {majorityElement}");

            //return majorityElement;

            #endregion
        }
    }

    public class IntMaxCompare : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
