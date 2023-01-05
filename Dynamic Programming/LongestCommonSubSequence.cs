using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Dynamic_Programming
{
    public class LongestCommonSubSequence
    {
        string _1;
        string _2;
        public void Run()
        {
            _1 = "abcdefghij";
            _2 = "zyjcdgi";

            //_1 = "KJSH";
            //_2 = "abcd";

            //_1 = "AGGTAB";
            //_2 = "GXTXAYB";
            //output string - "GTAB"

            //Console.WriteLine("Approach 1: " + LCS(0, 0));


            // Approach 2 using extra space
            int[,] store = new int[_1.Length + 1, _2.Length + 1];

            for (int x = 0; x < _1.Length + 1; x++)
            {
                for (int y = 0; y < _2.Length; y++)
                {
                    store[x, y] = -1;
                }
            }

            //LCS_Approach2(0, 0, store);
            //Console.WriteLine("Approach 2: " + store[0, 0]);

            // Approach 2 Without recursion
            Console.WriteLine("Approach 2 Without recursion:" + LCS_Approach2WithoutRecursion(store));
            Console.WriteLine(GetSubSeqeunceString(store));
        }

        public int LCS(int i, int j)
        {
            if (_1.Length <= i || _2.Length <= j) return 0;

            else if (_1[i] == _2[j])
                return 1 + LCS(i + 1, j + 1);
            else
                return Math.Max(LCS(i + 1, j), LCS(i, j + 1));
        }

        public int LCS_Approach2(int i, int j, int[,] store)
        {
            int result;

            var existingValue = store[i, j];
            if (existingValue != -1) return existingValue;

            if (_1.Length <= i || _2.Length <= j) return 0;

            else if (_1[i] == _2[j])
            {
                result = 1 + LCS_Approach2(i + 1, j + 1, store);
            }
            else
            {
                result = Math.Max(LCS_Approach2(i + 1, j, store), LCS_Approach2(i, j + 1, store));
            }

            store[i, j] = result;
            return result;

        }

        public int LCS_Approach2WithoutRecursion(int[,] store)
        {
            for (int i = 0; i < _1.Length + 1; i++)
            {
                for (int j = 0; j < _2.Length + 1; j++)
                {
                    // base condition
                    if (i == 0 || j == 0)
                        store[i, j] = 0;

                    // if there is a match of characters in string1 and string2
                    else if (_1[i - 1] == _2[j - 1])
                        store[i, j] = 1 + store[i - 1, j - 1];

                    else
                        //if there is no match of characters in string1 and string2
                        store[i, j] = Math.Max(store[i - 1, j], store[i, j - 1]);
                }
            }

            return store[_1.Length, _2.Length];
            //GetSubSeqeunceString(store);
        }

        public string GetSubSeqeunceString(int[,] store)
        {
            string result = string.Empty;

            int i = _1.Length;
            int j = _2.Length;

            while (i > 0 && j > 0)
            {
                if (store[i, j] > store[i, j - 1])
                {
                    result = (_1.Length > _2.Length ? _2[j - 1] : _1[i - 1]) + result;
                    i--;
                }

                j--;
            }

            return result;
        }
    }
}
