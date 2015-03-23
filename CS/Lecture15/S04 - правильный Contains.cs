using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    partial class MyList<T>
    {
        public bool Contains(T value)
        {
            for (int i = 0; i < count; i++)
                if (collection[i].Equals(value)) return true;
            return false;
        }
    }

    class Program4
    {
        public static void MainX()
        {
            var intList = new MyList<int>();
            intList.Add(1);
            Console.WriteLine(intList.Contains(1));

            var stringList = new MyList<string>();
            string str = "abc";
            stringList.Add(str);
            Console.WriteLine(stringList.Contains(str));
        }

    }
}
