using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları_ödev2
{
   public class HashNode
    {
        public int Key { get; set; }
        public object Value { get; set; }
        public HashNode(int key, object value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
