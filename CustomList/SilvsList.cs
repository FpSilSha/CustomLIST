using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class SilvsList<T>
    {
        private int nextIndex = 0;
        private T[] items = new T[4];
        public int Count { get; }
        public void Add(T item)
        
        {
            items[nextIndex] = item;
            nextIndex++;
        }


      
 
    }
}
