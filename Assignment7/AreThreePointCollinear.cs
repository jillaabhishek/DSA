using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_7
{
    /// <summary>
    /// Complexity Analysis:
    /// If Array length is 2 or 3. then time complexity will be constant O(1). We are just calculate formula
    /// If Array length is greater than 3 then time complexity will be O(N)
    /// </summary>
    public class AreThreePointCollinear
    {
        /// <summary>
        /// 2. Given three points, check whether they lie on a straight (collinear) or not. [Google]
        //     For example:
        //        Input- [(1, 1), (1, 6), (0, 9)]
        //        Output- No

        //        Input- [(1, 1), (1, 4), (1, 5)]
        //        Output- Yes

        /// </summary>
        public string Run()
        {
            int[][] points = new int[3][];

            //Input 1 
            // Output False/No
            points[0] = new int[2] { 1, 1 };
            points[1] = new int[2] { 1, 6 };
            points[2] = new int[2] { 0, 9 };

            //input 2
            //Output True/Yes
            //points[0] = new int[2] { 1, 1 };
            //points[1] = new int[2] { 1, 4 };
            //points[2] = new int[2] { 1, 5 };

            //input 3
            //[[1,2],[2,3],[3,5]]
            //Output false
            //points[0] = new int[2] { 1, 2 };
            //points[1] = new int[2] { 2, 3 };
            //points[2] = new int[2] { 3, 5 };

            var resilt = IsAreThreePointCollinear(points, 0);
            Console.WriteLine("Result 1: " + resilt);
            
            
            int[][] points2 = new int[6][];

            //Input 3
            //[[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
            // Output True / Yes
            points2[0] = new int[2] { 1, 2 };
            points2[1] = new int[2] { 2, 3 };
            points2[2] = new int[2] { 3, 4 };
            points2[3] = new int[2] { 4, 5 };
            points2[4] = new int[2] { 5, 6 };
            points2[5] = new int[2] { 6, 7 };


            //Input 4
            //[[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
            //Output False/No
            //points2[0] = new int[2] { 1, 1 };
            //points2[1] = new int[2] { 2, 2 };
            //points2[2] = new int[2] { 3, 4 };
            //points2[3] = new int[2] { 4, 5 };
            //points2[4] = new int[2] { 5, 6 };
            //points2[5] = new int[2] { 7, 7 };

            var result2 = ThreePointCollinerApproachWithLoop(points2);

            Console.WriteLine(result2);

            int[][] points3 = new int[7][];
            //Intut 5
            //[[1,2],[2,3],[3,4],[4,5],[5,6],[6,7],[1,8]]
            points3[0] = new int[2] { 1, 2 };
            points3[1] = new int[2] { 2, 3 };
            points3[2] = new int[2] { 3, 4 };
            points3[3] = new int[2] { 4, 5 };
            points3[4] = new int[2] { 5, 6 };
            points3[5] = new int[2] { 6, 7 };
            points3[6] = new int[2] { 1, 8 };

            //Input 6
            //[[1,2],[1,3],[1,4],[1,5],[1,6],[6,7]]

            var result3 = ThreePointCollinerApproachWithLoop(points3);

            Console.WriteLine(result3);
            return resilt ? "Yes" : "No";

        }

        /// <summary>
        /// Brute Force Approach
        /// 
        /// Complexity Analysis:
        /// There are no loops, it will constant O(1)
        /// </summary>
        public bool IsAreThreePointCollinear(int[][] arr, int i)
        {
            if (arr.Length != 3)
                return false;

            int firstPointX = arr[i][0];
            int firstPointY = arr[i][1];

            int secondPointX = arr[i + 1][0];
            int secondPointY = arr[i + 1][1];

            int thirdPointX = arr[i + 2][0];
            int thirdPointY = arr[i + 2][1];


            //Formula
            //A = 1/2[(x1 (y2 - y3) + x2 (y3 - y1) + x3(y1 - y2))] = 0
            //If the area is equal to 0, then those points will be considered to be collinear.

            var area = 0.5 * (firstPointX * (secondPointY - thirdPointY) +
                              secondPointX * (thirdPointY - firstPointY) +
                              thirdPointX * (firstPointY - secondPointY));

            return area == 0 ? true : false;
        }

        /// <summary>
        /// Approach 2 
        /// </summary>
        public bool ThreePointCollinerApproachWithLoop(int[][] arr)
        {

            // formula
            ////y2 - y1 / x2- x1 = y3 - y1 / x3 - x1
            // (y2 – y1) * (x3 – x2) = (x2 – x1) * (y3 – y2)

            if (arr.Length == 2)
                return true;

            if (arr.Length == 3)
                return IsAreThreePointCollinear(arr, 0); // Constant C

            int x0 = arr[0][0];
            int y0 = arr[0][1];
            int x1 = arr[1][0];
            int y1 = arr[1][1];

            int dx = x1 - x0;
            int dy = y1 - y0;

            for (int i = 2; i < arr.Length - 1; i++)  // This loop will run N - 2. O(N)
            {
                //If dy * (x – x0) is not equal to dx * (y – y0)
                //return false

                if (dy * (arr[i][0] - x0) != dx * (arr[i][1] - y0)) // O(N)
                    return false; // O(1)
            }

            //Time Complexity = O(N) + C
            //= O(N)

            return true; // O(1)
        }
    }
}
