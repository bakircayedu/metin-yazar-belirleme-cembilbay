using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları_ödev2
{
   public class Hash_tablo
    {
        int TABLE_SIZE = 10;
        HashNode[] table;
        public Hash_tablo()
        {
            table = new HashNode[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
            {
                table[i] = null;
            }
        }
        public Kelime GetKelime(int key)
        {
            int hash = (key % TABLE_SIZE);
            while (table[hash] != null && table[hash].Key != key)
            {
                hash = (hash + 1) % TABLE_SIZE;
            }
            if (table[hash] == null)
                return null;
            else
                return (Kelime)table[hash].Value;
        }
        public void AddKelime(int key, object value)
        {
            int hash = (key % TABLE_SIZE);
            while (table[hash] != null && table[hash].Key != key)
                hash = (hash + 1) % TABLE_SIZE;
            table[hash] = new HashNode(key, value);
        }
    }
}
