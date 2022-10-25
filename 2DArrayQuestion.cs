using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class _2DArrayQuestion
    {
        public bool Run()
        {

            var array2D = new int[3, 4] { { 1, 3, 5, 7 }, {  10, 11, 16, 20 }, { 23, 30, 34, 60 } };

            int noOfRows = 3;
            int noOfCols = 4;
            int res = 60;

            return SolvedUsingBinarySearch(array2D, noOfRows, noOfCols, res);
        }

        public bool SolvedUsingBinarySearch(int[,] array2D, int m, int n, int res)
        {

            int i = 0;
            int j = (m * n) - 1;

            while (i <= j)
            {
                var mid = i + (j - i) / 2;

                var rowNo = mid / n; // we use result
                var colNo = mid % n; // we use remainder

                if (array2D[rowNo, colNo] == res)
                    return true;
                else if (array2D[rowNo, colNo] < res)
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid - 1;
                }
            }

            return false;
        }
    }
}
