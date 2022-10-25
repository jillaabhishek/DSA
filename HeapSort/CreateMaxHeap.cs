using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HeapSort
{
    public class CreateMaxHeap
    {
        int[] arr = new int[11] { 10, 3, 7, 9, 12, 15, 8, 16, 18, 22, 27 };
        public string Run()
        {
            var result = buildHeap(arr);
            return String.Join(",", result);
        }

        public string DisplayArray()
        {
            return String.Join(",", arr);
        }

        public int[] buildHeap(int[] arr)
        {
            int arrLength = arr.Length;
            int startIndex = arrLength / 2 - 1;

            for (int i = startIndex; i >= 0; i--)
            {
                Heapify(arrLength, i);
            }

            return arr;
        }

        private bool isLeafNode(int i, int arrLength)
        {
            return i >= (arrLength / 2) && i <= arrLength;
        }

        private int GetLeftNodeIndex(int elementIndex)
        {
            return 2 * elementIndex + 1;
        }

        private int GetRightNodeIndex(int elementIndex)
        {
            return 2 * elementIndex + 2;
        }

        private int GetIndexValue(int index)
        {
            return arr[index];
        }

        private void Swap(int firstIndex, int secondIndex)
        {
            (arr[firstIndex], arr[secondIndex]) = (arr[secondIndex], arr[firstIndex]);
        }

        private void Heapify(int n, int i)
        {
            if (isLeafNode(i, n))
                return;

            int leftNode = GetLeftNodeIndex(i);
            int rightNode = GetRightNodeIndex(i);
            int currentIndex = i;

            if (leftNode >= n || rightNode >= n)
                return;

            var leftNodeValue = GetIndexValue(leftNode);
            var rightNodevalue = GetIndexValue(rightNode);
            var currentNodeValue = GetIndexValue(currentIndex);

            if (leftNodeValue > currentNodeValue || rightNodevalue > currentNodeValue)
            {
                if (leftNodeValue > rightNodevalue)
                {
                    Swap(leftNode, currentIndex);
                    currentIndex = leftNode;
                    Heapify(n, currentIndex);
                }
                else
                {
                    Swap(rightNode, currentIndex);
                    currentIndex = rightNode;
                    Heapify(n, currentIndex);
                }
            }
        }

        public int Pop()
        {
            if (arr.Length <= 0)
                return -1;

            int minElement = arr[0];
            arr[0] = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);

            buildHeap(arr);

            return minElement;
        }

        public int Peek()
        {
            if (arr.Length == 0)
                return -1;

            return arr[0];
        }

        public void Insert(int element)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = element;

            buildHeap(arr);
        }
    }
}
