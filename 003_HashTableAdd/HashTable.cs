using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HashTableAdd
{
    class HashTable<TKey, TValue>
    {
        private LinkedList<HashTableItem<TKey, TValue>>[] _array;
        private int _capacity;
        private int _size;

        public HashTable (int size)
        {
            _capacity = size;
            _array = new LinkedList<HashTableItem<TKey, TValue>>[_capacity];
        }

        private int hash (TKey key)
        {
            return Math.Abs(key.GetHashCode()) % _capacity;

            //  или использовать любой другой подход
            // return ((Math.Abs(key.GetHashCode()) << 5) + 13) % _size;
            // return (int)Math.Floor(((Math.Abs(key.GetHashCode()) * 0.13) % 1) * _size);
        }

        public void Add (TKey key, TValue val)
        {
            // в будущем нужна будет проверка на заполненость
            int index = hash(key);

            if (_array[index] == null)
            {
                _array[index] = new LinkedList<HashTableItem<TKey, TValue>>();
            }

            var hashTableItem = new HashTableItem<TKey, TValue>(key, val);

            var listNode = new LinkedListNode<HashTableItem<TKey, TValue>>(hashTableItem);

            _array[index].AddFirst(listNode);

            _size++;
        }
    }
}
