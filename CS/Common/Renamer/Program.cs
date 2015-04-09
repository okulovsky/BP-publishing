using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Harmonizer.Renamer.Rename(
                "..\\..\\..\\..\\BasicProgramming.sln",
                new string[] { "Common" },
                new string[] { "Модуль", "Лекция", "Часть" });
        }
    }
}
