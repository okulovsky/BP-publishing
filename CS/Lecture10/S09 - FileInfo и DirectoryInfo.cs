using System;
using System.IO;

namespace Slide09
{
    public class Program
    {
        static void Main()
        {
            foreach (var file in Directory.GetFiles("."))
                Console.WriteLine(file);

            Console.WriteLine(Directory.GetParent("."));

            var directoryInfo = new DirectoryInfo(".");
            foreach (var file in directoryInfo.GetFiles())
                Console.WriteLine(file.Name);
            directoryInfo = directoryInfo.Parent;
            Console.WriteLine(directoryInfo.FullName);

        }
    }
}