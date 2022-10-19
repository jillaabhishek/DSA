using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_9
{
    public class StrassensMatrixMultiplication
    {
        public void Run()
        {
            int[,] nums1 = new int[2, 2] { { 1, 2 }, { 4, 5 } };
            int[,] nums2 = new int[2, 2] { { 3, 4 }, { 6, 7 } };

            //{ a-1, b-2 }   { e-3, f-4 }
            //{ c-4, d-5 }   { g-6, h-7 }

            //ae + bg, af + bh, ce + dg and cf + dh

            var result = MatrixMultiplication(nums1, nums2);
            Console.WriteLine();

            var result2 = StrassenApproach(nums1, nums2);

        }

        //Divide & Conquer Approach
        public int[,] StrassenApproach(int[,] nums1, int[,] nums2)
        {
            (int a, int b, int c, int d) = split(nums1);
            (int e, int f, int g, int h) = split(nums2);

            // Computing the 7 products, recursively (p1, p2...p7)
            int p1 = Strassen(a, f - h);
            int p2 = Strassen(a + b, h);
            int p3 = Strassen(c + d, e);
            int p4 = Strassen(d, g - e);
            int p5 = Strassen(a + d, e + h);
            int p6 = Strassen(b - d, g + h);
            int p7 = Strassen(a - c, e + f);

            //# Computing the values of the 4 quadrants of the final matrix c
            int c11 = p5 + p4 - p2 + p6;
            int c12 = p1 + p2;
            int c21 = p3 + p4;
            int c22 = p1 + p5 - p3 - p7;

            return new int[2, 2] { { c11, c12 }, { c21, c22 } };
        }

        public int Strassen(int a, int b)
        {
            return a * b;
        }

        public Tuple<int, int, int, int> split(int[,] nums)
        {
            //var colLength = nums.GetLength(0);
            //var rowLength = nums.GetLength(1);
            ////row, col = matrix.shape
            //int row2 = rowLength / 2;
            //int col2 = colLength / 2;

            return Tuple.Create<int, int, int, int>(nums[0, 0], nums[0, 1], nums[1, 0], nums[1, 1]);
        }

        //Brute Force Approach
        public int[,] MatrixMultiplication(int[,] nums1, int[,] nums2)
        {
            int[,] nums3 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    nums3[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        nums3[i, j] += nums1[i, k] * nums2[k, j];
                    }
                }
            }

            return nums3;
        }
    }
}
