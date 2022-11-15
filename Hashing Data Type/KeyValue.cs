using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Hashing_Data_Type
{
    public class KeyValue
    {
        public KeyValue()
        {

        }
        public KeyValue(string key, int value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public int Value { get; set; }
    }
}
