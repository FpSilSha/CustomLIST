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
            list.Add(15);
            list.Count();
            list.Remove(15);

            SilvsList<int> myList = new SilvsList<int>();
            myList.Add(2);
            Console.WriteLine(myList);
        }
    }
}
