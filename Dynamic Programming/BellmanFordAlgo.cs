using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Dynamic_Programming
{
    public class BellmanFordAlgo
    {
        public void Run()
        {
            int n = 10;
            int[][] edges = new int[n][];

            edges[0] = new int[] { 1, 2 };
            edges[1] = new int[] { 1, 4 };
            edges[2] = new int[] { 2, 5 };
            edges[3] = new int[] { 5, 7 };
            edges[4] = new int[] { 3, 2 };
            edges[5] = new int[] { 3, 5 };
            edges[6] = new int[] { 4, 6 };
            edges[7] = new int[] { 4, 3 };
            edges[8] = new int[] { 5, 7 };
            edges[9] = new int[] { 6, 7 };

            //int[] val = new int[3] { 60, 100, 120 };
            //int[] wt = new int[3] { 10, 20, 30 };
        }




    }
}
