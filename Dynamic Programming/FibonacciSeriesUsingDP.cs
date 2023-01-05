using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Dynamic_Programming
{
    public class FibonacciSeriesUsingDP
    {
        public void Run()
        {
            int number = 1200;

            //Console.WriteLine(FindFibonacciValue(number));

            #region secondApproach

            ArrayList store = new ArrayList();

            for (int i = 0; i < number + 1; i++)
            {
                store.Add(null);
            }

            //Console.WriteLine(FindFibonacciUsingMemoization(number, store));

            #endregion


            #region ThirdApproach

            // Extra Space
            Console.WriteLine(FindFibonacciUsingTabulation(number));

            //Without extra space
            Console.WriteLine(FindFibonacciUsingTabulationWIthoutExtraSpace(number));

            #endregion
        }

        //First Approach using Recursion

        //This approach will fail for higher value
        public int FindFibonacciValue(int n)
        {
            if (n == 0 || n == 1) return n;

            else
            {
                return FindFibonacciValue(n - 1) + FindFibonacciValue(n - 2);
            }
        }



        //Seond Approach using DP Memoization (Top Down Approach)
        // This approach we store the function call result into data structure (Array)
        // 

        public double FindFibonacciUsingMemoization(int n, ArrayList store)
        {
            if (store[n] != null) return (double)store[n];

            if (n == 0 || n == 1) return n;

            else
            {
                double result = FindFibonacciUsingMemoization(n - 1, store) + FindFibonacciUsingMemoization(n - 2, store);

                store[n] = result;
                return result;
            }
        }

        //Thrid Approach using DP Tabulation (Bottom Up Approach)
        //This approach doesn't using Recursion 

        public double FindFibonacciUsingTabulation(int n)
        {
            ArrayList store = new ArrayList();

            for (int i = 0; i < n + 1; i++)
            {
                store.Add(null);
            }

            store[0] = 0d;
            store[1] = 1d;


            for (int i = 2; i < n + 1; i++)
            {
                store[i] = GetArrayValue(i - 1, store) + GetArrayValue(i - 2, store);
            }

            return (double)store[n];
        }

        private double GetArrayValue(int n, ArrayList store)
        {
            if (store[n] == null)
                return 0;

            return (double)store[n];
        }


        // Third Approach using DP Tabulation (Bottom Up Approach) but without using extra space

        public double FindFibonacciUsingTabulationWIthoutExtraSpace(int n)
        {
            double first =0d, second=1d, next=0d;

            for (int i = 2; i < n + 1; i++)
            {
                 next = first + second;
                (first, second) = (second, next);                
            }

            return next;
        }

    }
}
