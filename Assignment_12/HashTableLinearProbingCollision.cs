using DSA.Hashing_Data_Type;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_12
{
    /// <summary>
    /// Open Addressing
    /// Linear Probing
    /// </summary>
    public class HashTableLinearProbingCollision
    {
        static int size = 10;
        ArrayList arr = new ArrayList(size);
        public void Run()
        {
            for (int i = 0; i < size; i++)
            {
                arr.Add(null);
            }

            AddItem(new KeyValue("Jan", 1));
            AddItem(new KeyValue("Feb", 2));
            AddItem(new KeyValue("Mar", 3));
            AddItem(new KeyValue("April", 4));
            AddItem(new KeyValue("May", 5));
            AddItem(new KeyValue("June", 6));
            AddItem(new KeyValue("July", 7));
            AddItem(new KeyValue("Aug", 8));
            AddItem(new KeyValue("Sept", 9));
            AddItem(new KeyValue("Oct", 10));


            Console.WriteLine("Array After Insert");
            Print();

            Console.WriteLine();
            RemoveItem("Aug");
            Console.WriteLine("Array After Removing Aug");
            Print();

            Console.WriteLine();
            Console.WriteLine($"Get Value for Sept: {GetItem("Sept")}");
        }


        /// <summary>
        /// Time Complexity
        /// Worst/Average Case: O(n)
        /// Best Case: O(1)
        /// </summary>
        public void AddItem(KeyValue keyValue)
        {
            var hashKey = LinearProbingHashFunction(keyValue.Key);

            if (hashKey != -1)
                arr[hashKey] = keyValue;
        }

        /// <summary>
        /// Time Complexity
        /// Worst/Average Case: O(n)
        /// Best Case: O(1)
        /// </summary>
        public int GetItem(string key)
        {
            foreach (var item in arr)
            {
                KeyValue elem = (KeyValue)item;

                if (elem != null && elem.Key == key)
                    return elem.Value;
            }

            return -1;
        }

        /// <summary>
        /// Time Complexity
        /// Worst/Average Case: O(n)
        /// Best Case: O(1)
        /// </summary>
        public void RemoveItem(string key)
        {
            for (int i = 0; i < size; i++)
            {
                KeyValue elem = (KeyValue)arr[i];

                if (elem != null && elem.Key == key)
                {
                    arr[i] = null;
                }
            }
        }


        //Division Modulo Hash Function
        public int HashFunction(string key)
        {
            int summation = 0;
            // ## size of the hashtable
            foreach (var asci in Encoding.ASCII.GetBytes(key))
            {
                summation += asci;
            }

            return summation % size;
        }

        public int LinearProbingHashFunction(string key)
        {
            for (int i = 0; i < size; i++)
            {
                int index = HashFunction(key);
                index = (index + i) % size;

                if (arr[index] == null)
                    return index;
            }

            return -1;
        }

        public void Print()
        {
            string result = "[";

            for (int i = 0; i < size; i++)
            {
                var keyValue = GetKeyValue(i);
                if (keyValue != null)
                    result += $"({keyValue.Key}:{keyValue.Value})";
                else
                    result += "None";

                if (i < size - 1)
                    result += ", ";
            }

            result += "]";

            Console.WriteLine(result);
        }


        public KeyValue GetKeyValue(int index)
        {
            var item = arr[index];
            return (KeyValue)item;
        }

    }
}
