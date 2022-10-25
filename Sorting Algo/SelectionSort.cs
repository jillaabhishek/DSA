using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algo
{
    public class SelectionSort
    {
        public string Run()
        {
            int[] arr = new int[8] { 70, 20, 50, 30, 90, 5, 15, -1 };
            int[] result = SelectionSortAlgo(arr);

            return String.Join(",", result);
        }

        public int[] SelectionSortAlgo(int[] arr)
        {
            int n = arr.Length;
            
            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i; j < n; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                (arr[i], arr[min]) = (arr[min], arr[i]);
            }

            return arr;
        }

        //Javascript 

        //function selectionSort(arr=[])
        //{
        //    for (let i = 0; i < arr.length - 1; i++)
        //    {
        //        let minIndex = i;
        //        for (let j = i + 1; j < arr.length - 1; j++)
        //        {
        //            if (arr[j] < arr[minIndex])
        //            {
        //                minIndex = j
        //            }
        //        }
        //        [arr[i], arr[minIndex]] = [arr[minIndex], arr[i]]
        //    }
        //    return arr;
        //}
    }
}
