using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Dynamic_Programming
{
    public class _01Knapsack
    {
        public void Run()
        {
            int[] val = new int[3] { 60, 100, 120 };
            int[] wt = new int[3] { 10, 20, 30 };
            int capacity = 50;
            int n = val.Length;
            int valLen = val.Length + 1;
            int wtLen = wt.Length + 1;

            Console.WriteLine("Approach 1:" + Knapsack(capacity, wt, val, n));

            // Approach 2 using DP Memoization 
            int[,] store = new int[valLen, capacity + 1];

            for (int x = 0; x < valLen; x++)
            {
                for (int y = 0; y < capacity + 1; y++)
                {
                    store[x, y] = -1;
                }
            }

            //Console.WriteLine("Approach 2:" + KnapsackUsingDPMemoization(capacity, wt, val, n, store));

            //Approach 3 Using DP Tabulation
            Console.WriteLine("Approach 3:" + KnapsackUsingTabulationDP(capacity, wt, val, n, store));
        }

        public int Knapsack(int capacity, int[] wts, int[] profits, int n)
        {
            if (n > 0)
            {
                if (wts[n - 1] > capacity)
                    //If current item weight is greater than capacity we are skip the element
                    return Knapsack(capacity, wts, profits, n - 1);
                else
                    return Math.Max(profits[n - 1] + Knapsack(capacity - wts[n - 1], wts, profits, n - 1),  // adding the profit and call with reduce n and capacity
                                    Knapsack(capacity, wts, profits, n - 1)); //Else case skip the current element

            }

            return 0;
        }

        public int KnapsackUsingDPMemoization(int capacity, int[] wts, int[] profits, int n, int[,] store)
        {
            if (n == 0 || capacity == 0)
                return 0;
            else
            {
                if (store[n, capacity] != -1) return store[n, capacity];

                else if (wts[n - 1] > capacity)
                {
                    //If current item weight is greater than capacity we are skip the element
                    store[n, capacity] = Knapsack(capacity, wts, profits, n - 1);
                }
                else
                {
                    // adding the profit and call with reduce n and capacity
                    store[n, capacity] = Math.Max(profits[n - 1] + Knapsack(capacity - wts[n - 1], wts, profits, n - 1),
                                                Knapsack(capacity, wts, profits, n - 1)); //Else case skip the current element
                }
            }

            return store[n, capacity];
        }

        public int KnapsackUsingTabulationDP(int capacity, int[] wts, int[] profits, int n, int[,] store)
        {
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < capacity + 1; j++)
                {
                    if (i == 0 || j == 0)
                        store[i, j] = 0;

                    // if weight is else then the capacity
                    else if (wts[i - 1] < capacity)
                    {
                        store[i, j] = Math.Max(profits[n - 1] + Knapsack(capacity - wts[n - 1], wts, profits, n - 1),
                                               Knapsack(capacity, wts, profits, n - 1));
                    }
                    else
                    {
                        // wt[i-1] > W
                        // skip the current object
                        // copy the value from the previous row
                        store[i, j] = store[i - 1, j];
                    }

                }
            }

            return store[n, capacity];
        }

    }
}
