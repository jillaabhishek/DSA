using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HeapSort
{
    public class KMostFrequentWord
    {
        public string Run()
        {
            string[] words = new string[] { "priya", "Jilla", "bhatia", "akshay", "Jilla", "arpit", "priya", "arpit", "Jilla" };
            int K = 3;
            string[] resultArray = new string[K];

            PriorityQueue<string, int> pq = new PriorityQueue<string, int>(new IntMaxCompare());

            foreach (var word in words.Distinct())
            {
                pq.Enqueue(word, words.Count(x => x == word));
            }

            for (int i = 0; i < K; i++)
            {
                resultArray[i] = pq.Dequeue();
            }

            //Sorting the array in lexicographical/alphabetical order
            /// <summary>
            /// This method uses the Array.Sort method which applies the introspective sort as follows:
            /// If the partition size is fewer than 16 elements, it uses an insertion sort algorithm.
            /// If the number of partitions exceeds 2 * LogN, where N is the range of the input array, it uses a Heapsort algorithm.
            /// Otherwise, it uses a Quicksort algorithm.
            /// </summary>
            /// in worst case

            /// Time Complexity will O(N^2)
            Array.Sort(resultArray);

            var result = String.Join(",", resultArray);
            return result;
        }

        public Dictionary<string, int> GetCount(string[] words)
        {
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (dic.ContainsKey(words[i]))
                    dic[words[i]] = dic[words[i]] + 1;
                else
                    dic.Add(words[i], 1);
            }

            return dic;
        }
    }

    public class IntMaxCompare : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
