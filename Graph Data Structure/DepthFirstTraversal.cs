using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph_Data_Structure
{
    public class DepthFirstTraversal
    {
        List<int> result = new List<int>();
        public void Run()
        {

            int[][] edges = new int[7][];
            // A  B  C  D  E  F  G
            edges[0] = new int[] { 0, 1, 1, 1, 0, 0, 0 }; //A
            edges[1] = new int[] { 1, 0, 0, 0, 1, 0, 0 }; //B
            edges[2] = new int[] { 1, 0, 0, 0, 1, 1, 0 }; //C
            edges[3] = new int[] { 1, 0, 0, 0, 0, 1, 0 }; //D
            edges[4] = new int[] { 0, 1, 1, 0, 0, 0, 1 }; //E
            edges[5] = new int[] { 0, 0, 1, 1, 0, 0, 1 }; //F
            edges[6] = new int[] { 0, 0, 0, 0, 1, 1, 0 }; //G

            List<int> visited = new List<int>();

            DFT(edges, visited, 0);
            string path = string.Empty;
            foreach (var item in result)
            {
                path += item.ToString();
            }
            Console.WriteLine(path);
        }
        public void DFT(int[][] edges, List<int> visited, int nodeindex)
        {
            if (!Visited(visited, nodeindex))
            {
                visited.Add(nodeindex);

                int[] adjNodes = edges[nodeindex];

                for (int i = 0; i < adjNodes.Length; i++)
                {
                    DFT(edges, visited, adjNodes[i]);
                }
            }
        }

        public bool Visited(List<int> visited, int index)
        {
            return visited[index] == 1;
        }
    }
}








