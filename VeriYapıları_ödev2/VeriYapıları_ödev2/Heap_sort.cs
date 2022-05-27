using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları_ödev2
{
   public class Heap_sort
    {
        public int[] dizi { get; set; }
        public Heap_sort(int[] dizi)
        {
            this.dizi = dizi;
        }
        public int[] Sort()
        {
            Max_Heap h = new Max_Heap(dizi.Length);
            int[] sorted = new int[dizi.Length];
            foreach (int item in dizi)
            {
                h.Add(item);
            }
            int i = 0;
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax();
            return sorted;
        }
    }
}
