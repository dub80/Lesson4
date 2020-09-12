using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HashTable
{
    class HashTable<TKey, TValue>
    {
        private LinkedList<HashTableItem<TKey, TValue>>[] _array;
        private int _capacity;
        private int _size;

        public HashTable (int size)
        {
            _size = size;
            _array = new LinkedList<HashTableItem<TKey, TValue>>[size];
        }
    }
}
