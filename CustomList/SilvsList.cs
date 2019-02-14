using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class SilvsList<T>:IEnumerable
    {

        private T[] items = new T[4];
        private int nextIndex = 0;
        private int count = 0;
        private int capacity = 4;
        public int Count { get { return count; } }
        public int Length { get { return capacity; } }
        public void Add(T item)

        {
            if (Length == Count)
            {
                CapacityExtender();
            }
            items[nextIndex] = item;
            nextIndex++;
            count++;

        }

        public T this[int index]
        {
           
            get { return items[index]; }
            set
            {
                items[index] = value;
            }
        }
        private void CapacityExtender()
        {
            capacity *= 2;
            T[] tempArray = new T[capacity];
           for(int i = 0; i < count; i++)
            {
                tempArray[i] = items[i];
            }
            items = tempArray;

        }
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < Count; index++)
            {
                yield return items[index];
            }

               
        }


    }
}
