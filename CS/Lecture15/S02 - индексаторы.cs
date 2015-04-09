using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    partial class MyList<T>
    {
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                return collection[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                collection[index] = value;
            }
        }
    }

    public class Program2
    {
        public static void MainX()
        {
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list[1]);
        }
    }
   
}
