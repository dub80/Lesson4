using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_HashTable_Remove
{
    class Program
    {
        static void Main (string[] args)
        {
            HashTable<String, String> table = new HashTable<string, string>(10);

            table.Add("Name", "Ivan");
            table.Add("Surname", "Petrov");
            table.Add("Phone Number", "1234567890");

            table.Remove("Surname");
        }
    }
}
