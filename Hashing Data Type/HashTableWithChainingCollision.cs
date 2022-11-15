using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Hashing_Data_Type
{
    public class HashTableWithChainingCollision
    {
        readonly int size = 10;
        public void Run()
        {
            ArrayList arr = new ArrayList(size);

            for (int i = 0; i < size; i++)
            {
                arr.Add(new List<KeyValue>());
            }

            AddItem(arr, new KeyValue("March 6", 234));
            AddItem(arr, new KeyValue("March 17", 345));
            AddItem(arr, new KeyValue("March 2020", 230));
            AddItem(arr, new KeyValue("March 2021", 235));
            AddItem(arr, new KeyValue("March 2022", 445));
            AddItem(arr, new KeyValue("March 2023", 553));

            RemoveItem(arr, "March 17");

            foreach (List<KeyValue> elem in arr)
            {
                Console.WriteLine(string.Join(",", elem.Select(x => x.Value).ToList()));
            }

            Console.WriteLine($" Key: March 2021 and Value: {GetItem(arr, "March 2021")}");
        }

        public void AddItem(ArrayList arr, KeyValue keyValue)
        {
            var hashKey = HashFunction(keyValue.Key);
            bool found = false;

            List<KeyValue> list = (List<KeyValue>)arr[hashKey];

            foreach (KeyValue item in list)
            {
                if (item.Key == keyValue.Key)
                {
                    item.Value = keyValue.Value;
                    found = true;
                }
            }


            if (!found)
            {
                list.Add(keyValue);
                arr[hashKey] = list;
            }
        }

        //public virtual Object this[int index]

        public int GetItem(ArrayList arr, string key)
        {
            var hashKey = HashFunction(key);

            List<KeyValue> list = (List<KeyValue>)arr[hashKey];

            foreach (KeyValue item in list)
            {
                if (item.Key == key)
                {
                    return item.Value;
                }
            }

            return int.MinValue;
        }

        public void RemoveItem(ArrayList arr, string key)
        {
            var hashKey = HashFunction(key);

            List<KeyValue> list = (List<KeyValue>)arr[hashKey];

            foreach (KeyValue item in list)
            {
                if (item.Key == key)
                {
                    list.Remove(item);
                    return;
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

            // division modulo hash function
            return summation % size;
        }

    }
}
