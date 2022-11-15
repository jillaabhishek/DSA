using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_12
{
    /// <summary>
    /// Build Hashtable using Mid-Sqaure Hashing
    /// </summary>
    public class HashTableUsingMidSqaure
    {
        readonly int size = 10;
        public void Run()
        {
            int[] arr = new int[size];

            AddItem(arr, "March 2020", 234);
            AddItem(arr, "March 2021", 345);
            AddItem(arr, "March 2022", 445);
            AddItem(arr, "March 2023", 553);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public void AddItem(int[] arr, string key, int value)
        {
            var hashKey = MidSqaureHashFunction(key);
            arr[hashKey] = value;
        }

        public int RemoveItem(int[] arr, string key)
        {
            var hashKey = MidSqaureHashFunction(key);
            return arr[hashKey];
        }

        public long MidSqaureHashFunction(string key)
        {
            double summation = 0;

            foreach (var asci in Encoding.ASCII.GetBytes(key))
            {
                summation += asci;
            }

            string summsq = (summation * summation).ToString();

            return GetIndex(summsq);
        }

        private long GetIndex(string summsq)
        {
            int indexLen = CountDigit(size - 1);

            return Convert.ToInt64(summsq.Substring((summsq.Length - 1) / 2, indexLen));
        }

        private int CountDigit(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                ++count;
            }
            return count;
        }
    }
}
