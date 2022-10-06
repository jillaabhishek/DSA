using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_6
{
    public class BuildMinHeap
    {
        int[] arr = new int[15] { 10, 3, 7, 9, 12, 15, 8, 16, 18, 22, 27, 30, 40, -1, 100 };
        int arrSize = 0;

        /// <summary>
        /// arr = [1, 3, 7, 9, 12, 10, 8, 16, 18, 22, 27]
        /// Create a buildHeap method that returns a minheap.
        
        /// </summary>
        public string Run()
        {
            arrSize = arr.Length - 1;
            int[] result = buildHeapAlgo();

            Console.WriteLine("After Heap Sort");
            Console.WriteLine(String.Join(",", arr));

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Pop();
            }

            Array.Reverse(arr);

            //Console.WriteLine("Min Element: " + Pop());
            Console.WriteLine("Array after reverse");
            Console.WriteLine(String.Join(",", arr));

            //Console.WriteLine("Min Element: " + Pop());
            //Console.WriteLine("Array after removing Min Element");
            //Console.WriteLine(String.Join(",", arr));

            //Insert(1);
            //Console.WriteLine("Array after inserting Element");
            //Console.WriteLine(String.Join(",", arr));

            return String.Empty;
        }

        public int[] buildHeapAlgo()
        {
            int startIndex = arr.Length / 2 - 1;

            for (int i = startIndex; i >= 0; i--)
            {
                Heapify(i);
            }

            return arr;
        }

        public void Heapify(int i)
        {
            if (isLeafNode(i, arrSize))
                return;

            int leftNode = GetLeftNodeIndex(i);
            int rightNode = GetRightNodeIndex(i);
            int currentIndex = i;

            if (leftNode > arrSize || rightNode > arrSize)
                return;

            var leftNodeValue = GetIndexValue(leftNode);
            var rightNodevalue = GetIndexValue(rightNode);
            var currentNodeValue = GetIndexValue(currentIndex);
            int minNodeIndex = currentIndex;

            if (leftNodeValue < currentNodeValue || rightNodevalue < currentNodeValue)
            {
                if (leftNodeValue < rightNodevalue)
                    minNodeIndex = leftNode;
                else
                    minNodeIndex = rightNode;

                if (minNodeIndex != currentIndex)
                {
                    Swap(minNodeIndex, currentIndex);
                    currentIndex = minNodeIndex;

                    Heapify(currentIndex);
                }
            }
        }

        public void MinHeapifyShiftDown(int index)
        {
            if (index > arrSize)
                return;

            if (isLeafNode(index, arrSize))
                return;

            int minIndex = index;
            int minIndexValue = arr[index];

            var leftIndex = GetLeftNodeIndex(index);
            var rightIndex = GetRightNodeIndex(index);

            if (leftIndex >= arrSize || rightIndex >= arrSize)
                return;

            var leftIndexValue = GetIndexValue(leftIndex);
            var rightIndexValue = GetIndexValue(rightIndex);

            if (leftIndexValue < minIndexValue || rightIndexValue < minIndexValue)
            {
                if (leftIndexValue < rightIndexValue)
                    minIndex = leftIndex;
                else
                    minIndex = rightIndex;

                if (index != minIndex)
                {
                    Swap(index, minIndex);
                    MinHeapifyShiftDown(leftIndex);
                }
            }
        }

        public void MinHeapifyShiftUp(int index)
        {
            if (index > arrSize || index == 0)
                return;

            int minIndex = index;

            while (minIndex > 0 && arr[minIndex] < arr[GetParentNode(minIndex)])
            {
                var parentIndex = GetParentNode(minIndex);

                Swap(minIndex, parentIndex);
                minIndex = parentIndex;
            }
        }

        public int Pop()
        {
            if (arrSize <= 0)
                return -1;

            int minElement = arr[0];
            arr[0] = arr[arrSize];
            arr[arrSize] = minElement;
            arrSize--;

            Heapify(0);

            return minElement;
        }

        public void Insert(int element)
        {
            Array.Resize(ref arr, arrSize + 1);
            arr[arrSize] = element;
            arrSize++;

            MinHeapifyShiftUp(arrSize);
        }

        private int GetParentNode(int elementIndex)
        {
            return (elementIndex - 1) / 2;
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

        private bool isLeafNode(int i, int arrLength)
        {
            return i * 2 > arrLength;
        }

    }
}
