using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
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

        static void Main (string[] args)
        {
            var instance1 = new HashTableItem<String, int>("Name", 1);
            var instance2 = new HashTableItem<String, int>("Surname", 2);

            Console.WriteLine(instance1.Key);
            Console.WriteLine(instance2.Value);

            Console.ReadKey();
        }
    }
}
