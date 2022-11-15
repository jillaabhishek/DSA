using DSA.Hashing_Data_Type;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_12
{
    public class HashTableDoubleHashingCollision
    {
        static int size = 10;
        ArrayList arr = new ArrayList(size);
        const int C = 1;

        public void Run()
        {
            Console.WriteLine("DoubleHashing Probing Hashtable");
            for (int i = 0; i < size; i++)
            {
                arr.Add(null);
            }

            AddItem(new KeyValue("50", 1));
            AddItem(new KeyValue("75", 2));
            AddItem(new KeyValue("99", 3));
            AddItem(new KeyValue("20", 4));
            AddItem(new KeyValue("35", 5));
            AddItem(new KeyValue("88", 6));
            AddItem(new KeyValue("45", 7));
            AddItem(new KeyValue("23", 8));
            AddItem(new KeyValue("55", 9));
            AddItem(new KeyValue("67", 10));


            Console.WriteLine("Array After Insert");
            Print();

            Console.WriteLine();
            RemoveItem("45");
            Console.WriteLine("Array After Removing 45");
            Print();

            Console.WriteLine();
            Console.WriteLine($"Get Value for 23: {GetItem("23")}");
        }


        /// <summary>
        /// Time Complexity
        /// Worst/Average Case: O(n)
        /// Best Case: O(1)
        /// </summary>
        public void AddItem(KeyValue keyValue)
        {
            var hashKey = DoubleHashingProbingHashFunction(keyValue.Key);

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
        public int HashFunction1(string key)
        {
            int summation = 0;
            // ## size of the hashtable
            foreach (var asci in Encoding.ASCII.GetBytes(key))
            {
                summation += asci;
            }

            return summation % size;
        }

        public int HashFunction2(string key)
        {
            int summation = 0;
            // ## size of the hashtable
            foreach (var asci in Encoding.ASCII.GetBytes(key))
            {
                summation += asci;
            }

            return 1 + summation % (size - 2);
        }

        public int DoubleHashingProbingHashFunction(string key)
        {
            for (int i = 0; i < size; i++)
            {
                var hashKey = (HashFunction1(key) + i * HashFunction2(key)) % size;

                if (arr[hashKey] == null)
                    return hashKey;
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
