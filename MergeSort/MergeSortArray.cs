using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.MergeSort
{
    public class MergeSortArray
    {
        public void Run()
        {
            int[] arr = new int[10] { 50, 20, 40, 70, 10, 60, 39, 64, 1, -1 };
            // starting index
            int i = 0;
            // ending index
            int j = arr.Length - 1;
            // function calling
            MergeSort(arr, i, j);

            Console.WriteLine(string.Join(",", arr));
        }


        /// <summary>
        /// function definition of merge sort
        /// Approach -> Divide and Conquer
        /// Recurrence Relation -> 2T(N/2) + N
        /// Time complexity -> O(NlogN)
        /// </summary>
        public int[] MergeSort(int[] arr, int i, int j)
        {
            if (i < j)
            {
                //Divide
                int mid = i + (j - i) / 2;

                // Conquer
                // recursive call -> left subtree
                MergeSort(arr, i, mid);
                // recursive call -> right subtree
                MergeSort(arr, mid + 1, j);
                //Combine -> mergeProcedure(function calling)
                MergeProcedure(arr, i, mid, j);
            }

            return arr;

        }


        /// <summary>
        ///  Implementation of Merge Sort
        ///  function definition of merge Procedure
        ///  n1+n2 = N 
        ///  MergeProcedure time complexity = O(N)
        /// </summary>
        public void MergeProcedure(int[] arr, int i, int mid, int j)
        {
            //Find number of element present in first subtree (mid - i + 1)
            int n1 = mid - i + 1;

            //Find number of element present in second subtree (j - (mid + 1) + 1) == (j - mid)
            int n2 = j - mid;

            //intialization of left and right subarray
            int[] leftSubTree = new int[n1];
            int[] rightSubTree = new int[n2];

            // copy the elements from an array to the subarrays
            for (int m = 0; m < n1; m++)
                leftSubTree[m] = arr[i + m];

            // copy the elements from an array to the subarrays
            for (int n = 0; n < n2; n++)
                rightSubTree[n] = arr[mid + 1 + n];

            int p = 0;
            int q = 0;
            int k = i;

            while (p < n1 && q < n2)
            {
                if (leftSubTree[p] <= rightSubTree[q])
                {
                    arr[k] = leftSubTree[p];
                    p++;
                }
                else
                {
                    arr[k] = rightSubTree[q];
                    q++;
                }

                k++;
            }

            while (p < n1)
            {
                arr[k] = leftSubTree[p];
                k++;
                p++;
            }

            while (q < n2)
            {
                arr[k] = rightSubTree[q];
                k++;
                q++;
            }
        }
    }
}
