using DSA.Testing;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.Assignment_7
{
    public class TrackPurchasesQuestion3
    {
        /// <summary>
        /// An e-commerce site tracks the purchases made each day. The product that is purchased 
        /// the most one day is the featured product for the following day.If there is a tie for the product 
        /// purchased most frequently, those product names are ordered alphabetically ascending and 
        /// the last name in the list is chosen.[Amazon]
        /// ['yellowShirt', 'redHat', 'blackShirt', 'bluePants', 'redHat', 'pinkHat', 'blackShirt', 'yellowShirt', 'greenPants', 'greenPants', 'greenPants']

        /// 'yellowShirt' - 2
        /// 'redHat' - 2
        /// 'blackShirt' - 2
        /// 'bluePants' - 1
        /// 'greenPants' - 3
        /// 'pinkHat' - 1
        //Output - greenPants


        // Time Complexity Analysis

        // First case, only one record with number of orders
        // O(N) = O(NLogN) (Add item to PriorityQueue) + C (Get highest order item)
        // O(N) = O(NLogN)

        // Second case, more then one record with number of ordder
        // O(N) = O(NLogN) (Add item to PriorityQueue) + O(N^2) (Sort the ordername) + C (Get highest order item)
        // O(N)
        /// </summary>
        public string Run()
        {
            //Driver Code
            //string[] orders = new string[10] { "pinkHat", "redHat", "blackShirt", "bluePants", "redHat", "blackShirt", "yellowShirt", "yellowShirt", "greenPants", "greenPants" };
            string[] orders = new string[11] { "yellowShirt", "redHat", "blackShirt", "bluePants", "redHat", "pinkHat", "blackShirt", "yellowShirt", "greenPants", "greenPants", "greenPants" };

            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>(new IntMaxCompare());

            foreach (var order in orders)  // O(NlogN)
            {
                priorityQueue.Enqueue(order, orders.Count(x => x == order)); // O(LogN)
            }

            ////peekElement to check if array contains other element with same # order
            var peekElement = priorityQueue.TryPeek(out string? peekOrderName, out int peekNoOfOrders); // Constant O(1)

            string[] itemsWithSameOrder = priorityQueue.UnorderedItems.Where(x => x.Priority == peekNoOfOrders).Select(x => x.Element).ToArray(); // Assuming Constant O(1)

            //If there are multiple record with same order numbers then
            if (itemsWithSameOrder.Count() > 1)
            {
                /// <summary>
                /// This method uses the Array.Sort method which applies the introspective sort as follows:
                /// If the partition size is fewer than 16 elements, it uses an insertion sort algorithm.
                /// If the number of partitions exceeds 2 * LogN, where N is the range of the input array, it uses a Heapsort algorithm.
                /// Otherwise, it uses a Quicksort algorithm.
                /// </summary>
                /// in worst case
                                
                /// Time Complexity will O(N^2)
                Array.Sort(itemsWithSameOrder);
                var orderName = itemsWithSameOrder[itemsWithSameOrder.Length - 1];
                Console.WriteLine(orderName + " " + peekNoOfOrders);

                return $"OrderName: {orderName} and No of orders: {peekNoOfOrders}";
            }
            else
            {
                Console.WriteLine(peekOrderName + " " + peekNoOfOrders);
                return $"OrderName: {peekOrderName} and No of orders: {peekNoOfOrders}";
            }            
        }

    }

    public class IntMaxCompare : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
