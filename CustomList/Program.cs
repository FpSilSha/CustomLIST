using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            List<string> list2 = new List<string>();

            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(24);
            list.Add(13);
            Console.WriteLine(list[6]);
            list.Add(15);
            list.Count();
            list.Remove(15);
            list.Remove(15);
            Console.WriteLine(list[4]);
            Console.WriteLine(list2);
            Console.WriteLine(list);
            SilvsList<int> myList = new SilvsList<int>();
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            SilvsList<int> myList2 = myList;

            Console.WriteLine(myList2);
            Console.ReadKey();
        }
    }
}
