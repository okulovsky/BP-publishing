using Slide03;
using System;
using System.Threading;

namespace Slide12
{
    class Program
    {
        static Random rnd=new Random();

        //Разрабатываем метод, который возвращает число,
        //если пользователь успел нажать клавишу,
        //и что-то, если не успел
        public static int GetNumber1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                    return rnd.Next(100);
                Thread.Sleep(100);
            }
            // Так делать очень плохо. Потому что -1 - это такое же число, как и другие
            // и требуется специальная договоренность
            return -1;
        }

        static void Main1()
        {
            var value = GetNumber1();
            if (value == -1)
                Console.WriteLine("Error");
            else
                Console.WriteLine(value);
        }

        public static int GetNumber2()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                    return rnd.Next(100);
                Thread.Sleep(100);
            }
            // Это нормально, если отсутствие ввода - действительно исключительная,
            // ошибочная ситуация. Но иногда это не так. Иногда просто хочется
            // вернуть два значения - флаг ввода и его содержимое
            throw new Exception();
        }

        static void Main2()
        {
            try
            {
                Console.WriteLine(GetNumber2());
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        //Можно так, через ключевое слово ref.
        //Но ref устанавливает двустороннее соединение между методами,
        //чего нужно избегать из архитектурных соображений
        public static bool GetNumber3(ref int value)
        {
            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                {
                    value = rnd.Next(100);
                    return true;
                }
                Thread.Sleep(100);
            }
            return false;
        }

        static void Main3()
        {
            int value = 0;
            if (!GetNumber3(ref value))
                Console.WriteLine("Error");
            else
                Console.WriteLine(value);
        }


        //Лучше использовать out-параметр.
        //Он работает примерно также, как ref, но является односторонним
        public static bool GetNumber4(out int value)
        {
            //Console.WriteLine(value); // value не может быть использовано до присвоения внутри метода
            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                {
                    value = rnd.Next(100);
                    return true;
                }
                Thread.Sleep(100);
            }
            //value обязано быть присвоено до выхода из метода
            value = 0;
            return false;
        }

        static void Main4()
        {
            int value;
            if (!GetNumber4(out value))
                Console.WriteLine("Error");
            else
                Console.WriteLine(value);
        }

        public class IntReply
        {
            public int Number { get; set; }
            public bool Available { get; set; }
        }

        //Но все же out и ref - это не очень удачно.
        //Лучше просто возвращать объект
        public static IntReply GetNumber5()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                    return new IntReply { Available=true, Number=rnd.Next(100) };
                Thread.Sleep(100);
            }
            return new IntReply { Available = false };
        }

        static void Main5()
        {
            var value = GetNumber5();
            if (value.Available)
                Console.WriteLine(value.Number);
            else
                Console.WriteLine("Error");
        }

        //На каждый метод классов не наделаешь. Поэтому можно делать так.
        //Но этим не следует злоупотреблять: если метод возвращает координаты X,Y,
        //то лучше использовать Point, а не Tuple<int,int>
        public static Tuple<bool,int> GetNumber6()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                    return new Tuple<bool,int>(true, rnd.Next(100));
                Thread.Sleep(100);
            }
            return Tuple.Create(false, 0);
        }

        static void Main6()
        {
            var value = GetNumber6();
            if (value.Item1)
                Console.WriteLine(value.Item2);
            else
                Console.WriteLine("Error");
        }

        static int? GetNumber7()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                    return rnd.Next(100);
                Thread.Sleep(100);
            }
            return null;
        }

        static void Main7()
        {
            var value = GetNumber7();
            if (value!=null)
                Console.WriteLine(value);
            else
                Console.WriteLine("Error");
        }
    }



}