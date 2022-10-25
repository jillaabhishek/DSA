using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DivideAndConquer_Algo
{
    /// <summary>
    /// Time Complexity
    /// T(n) = 2T(n/2) + C;
    /// We can solve using Master's Therom
    /// a=2, b=2, k=0, p=0;
    /// log b base a = log 2 base 2  = 1
    /// formula n power log b base a
    /// n power 1
    /// </summary>
    public class FindMinAndMax
    {
        public string Run()
        {
            int[] arr = new int[12] { 70, 0, 20, 50, 30, 90, 5, 15, 5, 10, 15, 100 };
            int arrLen = arr.Length-1;

            var result = DividAndConquerAlgo(arr, 0, arrLen);

            return $"Max Integer: {result.Item1} && Min Integer: {result.Item2}";

        }


        public Tuple<int, int> DividAndConquerAlgo(int[] arr, int i, int j)
        {
            int max;
            int min;

            if (i == j)
            {
                max = arr[i];
                min = arr[i];
                return Tuple.Create(max, min);
            }
            else if (i == j - 1)
            {
                if (arr[i] > arr[j])
                {
                    max = arr[i];
                    min = arr[j];
                }
                else
                {
                    max = arr[j];
                    min = arr[i];
                }
                return Tuple.Create(max, min);
            }
            else
            {
                int mid = i + (j - i) / 2;

                var res1 = DividAndConquerAlgo(arr, i, mid);
                var res2 = DividAndConquerAlgo(arr, mid + 1, j);

                max = res1.Item1 > res2.Item1 ? res1.Item1 : res2.Item1;
                min = res1.Item2 < res2.Item2 ? res1.Item2 : res2.Item2;
                
            }

            return Tuple.Create(max, min);
        }
    }
}
