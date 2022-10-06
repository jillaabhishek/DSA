using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HeapSort
{
    public class KClosestPointToOrigin
    {
        /// <summary>
        /// 3.	Find the k closest points to the origin.
        ///     Points = [[1, 3], [-2, 2], [5, -1]]
        ///     K = 1
        ///     Output = [-2,2]

        /// </summary>
        public string Run()
        {
            int[,] points = new int[5, 2] { { 5, -1 }, { 1, 3 }, { 1, 1 }, { -2, 2 }, { 4, 5 } };
            int k = 2;

            ArrayList arrayList = new ArrayList();
            string result = string.Empty;

            var colLength = points.GetLength(0);
            // Time Complexity O(column Length) // In this scenario it will be O(5)
            for (int i = 0; i < colLength; i++)
            {
                int x = points[i, 0];
                int y = points[i, 1];
                arrayList.Add((GetDistance(x, y), new[] { x, y }));
            }

            // We know to build Min/Max heap time complexity will be O(n)
            ArrayList maxHeapArrayList = buildHeap(arrayList);

            // Again we Iterate over array to get number of K element 
            // Time Complexity : O(K) // O(2)
            for (int i = 0; i < k; i++)
            {
                var minElement = Pop(maxHeapArrayList);
                result += "[" + String.Join(",", minElement) + "],";
            }

            return result;
        }

        private double GetDistance(int x, int y)
        {
            return Math.Sqrt(x * x + y * y);
        }


        #region MinHeapCode

        public ArrayList buildHeap(ArrayList arr)
        {
            int arrLength = arr.Count;
            int startIndex = arrLength / 2 - 1;

            for (int i = startIndex; i >= 0; i--)
            {
                Heapify(arr, arrLength, i);
            }

            return arr;
        }

        private bool isLeafNode(int i, int arrLength)
        {
            return i * 2 > arrLength;
        }

        private int GetLeftNodeIndex(int elementIndex)
        {
            return 2 * elementIndex + 1;
        }

        private int GetRightNodeIndex(int elementIndex)
        {
            return 2 * elementIndex + 2;
        }

        private double GetIndexValue(ArrayList arr, int index)
        {
            var obj = (ValueTuple<Double, int[]>)arr[index];
            return obj.Item1;
        }

        private int[] GetIndexItem2(ArrayList arr, int index)
        {
            var obj = (ValueTuple<Double, int[]>)arr[index];
            return obj.Item2;
        }


        private void Swap(ArrayList arr, int firstIndex, int secondIndex)
        {
            (arr[firstIndex], arr[secondIndex]) = (arr[secondIndex], arr[firstIndex]);
        }

        private void Heapify(ArrayList arr, int n, int i)
        {
            if (isLeafNode(i, n))
                return;

            int leftNode = GetLeftNodeIndex(i);
            int rightNode = GetRightNodeIndex(i);
            int currentIndex = i;

            if (leftNode >= n || rightNode >= n)
                return;

            var leftNodeValue = GetIndexValue(arr, leftNode);
            var rightNodevalue = GetIndexValue(arr, rightNode);
            var currentNodeValue = GetIndexValue(arr, currentIndex);

            if (leftNodeValue < currentNodeValue || rightNodevalue < currentNodeValue)
            {
                if (leftNodeValue < rightNodevalue)
                {
                    Swap(arr, leftNode, currentIndex);
                    currentIndex = leftNode;
                    Heapify(arr, n, currentIndex);
                }
                else
                {
                    Swap(arr, rightNode, currentIndex);
                    currentIndex = rightNode;
                    Heapify(arr, n, currentIndex);
                }
            }
        }

        public int[] Pop(ArrayList arr)
        {
            if (arr.Count <= 0)
                return null;

            int[] minElement = GetIndexItem2(arr, 0);
            arr.RemoveAt(0);

            buildHeap(arr);

            return minElement;
        }

        #endregion
    }
}
