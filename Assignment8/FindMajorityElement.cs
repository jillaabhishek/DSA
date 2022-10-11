using System;
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
    /// Time Complexity: O(nlogn)
    public class FindMajorityElement
    {
        public int Run()
        {
            int[] nums = new int[10] { 2, 3, 3, 1, 1, 3, 2, 3, 2, 3};

            var list = new List<(int, int)>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(new IntMaxCompare());

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.TryGetValue(nums[i], out int value))
                {
                    dic[nums[i]] = value + 1;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }

            foreach (var item in dic)
            {
                priorityQueue.Enqueue(item.Key, item.Value);
            }

            var majorityElement = priorityQueue.Dequeue();

            Console.WriteLine($"Majority Element: {majorityElement}");

            return majorityElement;
        }
    }

    public class IntMaxCompare : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
