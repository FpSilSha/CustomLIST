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
      
        private T[] items = new T[4];
        private int nextIndex = 0;
        private int count = 0;
        public int Count { get { return count; } }
        public void Add(T item)
        
        {
            items[nextIndex] = item;
            nextIndex++;
            count++;
        }

        public T this[int index]
        {
            
            get { return items[index]; }

        }


      

    }
}
