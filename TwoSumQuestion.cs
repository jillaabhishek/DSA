using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class TwoSumQuestion
    {
        public Tuple<int, int> RunTwoPointer()
        {
            int[] arr = new int[7] { 20, 60, 80, 90, 120, 140, 190 };
            int result = 210;
            int l = 0;
            int r = arr.Length - 1;

            return BinarySearch_2_Solution(arr, l, r, result);
        }

        Tuple<int, int> TwoPointerApproach_3_Solution(int[] arr, int l, int r, int res)
        {
            while (l <= r)
            {
                var arraySum = arr[l] + arr[r];
                if (arraySum == res)
                {
                    return Tuple.Create(l, r);
                }
                else if (arraySum < res)
                    l += 1;
                else
                    r -= 1;

                //else if (arraySum > res)
                //{
                //    r -= 1;
                //}
                //else
                //    l += 1;
            }

            return Tuple.Create(-1, -1);
        }


        Tuple<int, int> BinarySearch_2_Solution(int[] arr, int l, int r, int res)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                l = i + 1;
                r = arr.Length - 1;
                while (l <= r)
                {
                    var midInd = l + (r - l) / 2;

                    var sumofNum = arr[midInd] + arr[i];

                    if (sumofNum == res)
                    {
                        return Tuple.Create(i, midInd); 
                    }
                    else if (sumofNum < res)
                    {
                        l = midInd + 1;
                    }
                    else
                    {
                        r = midInd - 1;
                    }
                }
            }

            return Tuple.Create(-1, -1);
        }
    }
}
