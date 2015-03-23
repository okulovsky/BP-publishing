using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide06
{
    class Program
    {
        static int variable=int.Parse(Console.ReadLine());

        static void Main()
        {
            Console.WriteLine(variable);
        }
    }
}

/*
 * В ситуации вложенного исключения нужно обращать внимание на InnerException
 * Конкретно для данной ситуации нужно избегать сложных действий в инициализации.
 */
