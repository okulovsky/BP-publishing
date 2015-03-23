using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    partial class MyList<T>
    {
        public bool WrongContains(T value)
        {
            for (int i = 0; i < count; i++)
                //if (collection[i] == value) return true; // == не определено для всех типов данных
                if ((object)collection[i] == (object)value) return true;// - не имеет смысла, потому что будут сравниваться ссылки на объекты
            return false;
        }
    }

    class Program3
    {
        public static void MainX()
        {
            var intList = new MyList<int>();
            intList.Add(1);
            Console.WriteLine(intList.WrongContains(1));

            var stringList = new MyList<string>();
            string str = "abc";
            stringList.Add(str);
            Console.WriteLine(stringList.WrongContains(str));
        }

    }
}
