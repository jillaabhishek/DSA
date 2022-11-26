using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_15
{
    /// <summary>
    /// https://leetcode.com/problems/find-if-path-exists-in-graph/
    /// </summary>
    public class FindPathExistInGraph
    {
        public Dictionary<int, HashSet<int>> AdjacencyList = new Dictionary<int, HashSet<int>>();
        List<int> path = new List<int>();
        HashSet<int> visited = new HashSet<int>();

        public void Run()
        {
            int n = 10;
            int[][] edges = new int[n][];

            edges[0] = new int[] { 4, 3 };
            edges[1] = new int[] { 1, 4 };
            edges[2] = new int[] { 4, 8 };
            edges[3] = new int[] { 1, 7 };
            edges[4] = new int[] { 6, 4 };
            edges[5] = new int[] { 4, 2 };
            edges[6] = new int[] { 7, 4 };
            edges[7] = new int[] { 4, 0 };
            edges[8] = new int[] { 0, 9 };
            edges[9] = new int[] { 5, 4 };

            //[[4,3],[1,4],[4,8],[1,7],[6,4],[4,2],[7,4],[4,0],[0,9],[5,4]]
            int source = 5, destination = 9;

            //ValidPath(n, edges, source, destination);
            //Console.WriteLine(ValidPath_Approach2(n, edges, source, destination));

            Console.WriteLine(ValidPath_Approach2UsingRecursion(n, edges, source, destination));
        }

        // Approach 2
        public bool ValidPath_Approach2(int n, int[][] edges, int source, int destination)
        {
            if (source == destination) return true;

            AddVertex(n);
            AddEdges(edges);

            FindPath_Approach2(source);


            return path.Contains(source) && path.Contains(destination);
        }

        public HashSet<int> FindPath_Approach2(int source)
        {
            var visited = new HashSet<int>();

            if (!AdjacencyList.ContainsKey(source))
                return visited;

            var stack = new Stack<int>();
            stack.Push(source);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                if (path != null)
                    path.Add(vertex);

                visited.Add(vertex);

                foreach (var neighbor in AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
                }
            }

            return visited;
        }

        // Approach 2 with Recursion
        public bool ValidPath_Approach2UsingRecursion(int n, int[][] edges, int source, int destination)
        {
            if (source == destination) return true;

            AddVertex(n);
            AddEdges(edges);

            FindPath_Approach2UsingRecursion(source);


            return path.Contains(source) && path.Contains(destination);
        }

        public void FindPath_Approach2UsingRecursion(int vertex)
        {
            if (visited.Contains(vertex))
                return;
            else
            {
                path.Add(vertex);
                visited.Add(vertex);

                foreach (var neighbor in AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor))
                        FindPath_Approach2UsingRecursion(neighbor);
                }
            }
        }

        public void AddVertex(int n)
        {
            for (int i = 0; i < n; i++)
            {
                AdjacencyList[i] = new HashSet<int>();
            }
        }

        public void AddEdges(int[][] edges)
        {
            for (int i = 0; i < edges.Length; i++)
            {
                if (edges[i] != null && AdjacencyList.ContainsKey(edges[i][0]) && AdjacencyList.ContainsKey(edges[i][1]))
                {
                    AdjacencyList[edges[i][0]].Add(edges[i][1]);
                    AdjacencyList[edges[i][1]].Add(edges[i][0]);
                }
            }
        }


        
        // Approach 1
        // But doesn't pass all test cases in LeetCode.
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            bool sourceMatch = true;
            bool destinationMatch = true;

            for (int i = 0; i < edges.Length; i++)
            {
                sourceMatch = false;
                destinationMatch = false;

                for (int j = 0; j < edges[i].Length; j++)
                {
                    if (edges[i][j] == source)
                        sourceMatch = true;

                    if (edges[i][j] == destination)
                        destinationMatch = true;
                }

                if (sourceMatch && destinationMatch)
                    return true;
            }

            return false;
        }

    }
}
