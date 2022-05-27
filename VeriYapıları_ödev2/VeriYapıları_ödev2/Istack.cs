using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları_ödev2
{
   public interface Istack
    {
        void Push(object item);
        object Pop();
        object Peek();
        
        
    }
}
