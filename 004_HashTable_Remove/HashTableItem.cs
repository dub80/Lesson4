using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_HashTable_Remove
{
    public class HashTableItem<T, V>
    {
        public T Key { get; private set; }
        public V Value { get; private set; }

        public HashTableItem (T key, V val)
        {
            Key = key;
            Value = val;
        }
    }
}
