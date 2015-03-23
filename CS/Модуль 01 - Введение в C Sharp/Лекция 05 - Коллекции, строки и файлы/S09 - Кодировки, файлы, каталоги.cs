﻿using System;
using System.IO;
using System.Text;

namespace Slide09
{
    public class Program
    {
        //Когда мы говорим о записи текста в файл, возникают кодировки
        //Кодировка - это то, что превращает символ (абстрактную сущность) в байты (конкретные числа от 0 до 255)
        //Вне кодировки, никакой связи между символами и байтами нет!
        static void WriteAndRead(string text, Encoding encoding)
        {
            Console.WriteLine("{0}, encoding {1}", text, encoding.EncodingName);
            //Так можно записать в файл некий текст
            //Альтернативы - WriteAllLines (записывает массив строк) или WriteAllBytes (массив байт)
            File.WriteAllText("temp.txt", text, encoding);

            //Так можно прочитать массив байт
            //Альтернативы интуитивно понятны
            var bytes = File.ReadAllBytes("temp.txt");
            foreach (var e in bytes)
                Console.Write("  {0} ", (char)e);
            Console.WriteLine();
            foreach (var e in bytes)
                Console.Write("{0:D3} ", e);


            Console.WriteLine("\n");
            //В С# есть "костыли", позволяющие конвертировать byte в char. 
            //Это - наследие прежних эпох, когда кодировка была только одна".
            //Тем не менее, злоупотреблять этим не стоит

        }


        public static void MainX()
        {
            //Английский язык и базовые символы одинаковы во всех кодировках
            //Однако, при сохранении текста в кодировке UTF добавляется специальный маркер файла,
            //по которому текстовые редакторы определяют кодировку текста
            WriteAndRead("Hello!", Encoding.ASCII);
            WriteAndRead("Hello!", Encoding.UTF8);


            //Русские буквы нельзя сохранять в ASCII
            WriteAndRead("Привет!", Encoding.ASCII);

            //Можно попробовать в кодировке локали, но этого лучше не делать:
            //В этом случае файл не самодостаточен, для его прочтения нужно знать
            //какая кодировка у вас в локали
            WriteAndRead("Привет!", Encoding.Default);

            //UTF-8 - лучшее решение!
            //Русские буквы кодируются в ней двумя байтами
            WriteAndRead("Привет!", Encoding.UTF8);

            //А китайские иероглифы - уже тремя
            WriteAndRead("你好!", Encoding.UTF8);


            //Класс Directory - простейший способ получить доступ к структуре каталогов
            //Исследуйте его методы самостоятельно с помощью Intellisense
            foreach (var e in Directory.GetFiles("."))
            {
                Console.WriteLine(e);
            }
        }
    }
}