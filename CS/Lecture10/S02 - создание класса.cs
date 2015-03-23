using System;

namespace Slide02
{
    //Класс - это совокупность полей и методов (с методами разберемся далее)
    public class Student
    {
        //Так объявляется поле класса.
        //Оно не статическое, т.е. не является глобальной переменной. Разницу между статическими и динамическими полями
        //мы разберем позже.
        //С ключевым словом public мы также разберемся позже
        public string FirstName;
        public string LastName;
        public int Age;
    }

    public class Program
    {
        //мы можем создать массив из Student, потому что Student теперь - это такой же тип, как string или int
        static Student[] students;

        //этот тип можно использовать в аргументах метода. Теперь мы не сможем перепутать их местами.
        //кроме того, если мы захотим добавить новое поле в Student, не придется переписывать заголовок метода
        static void PrintStudent(Student student)
        {
            Console.WriteLine("{0,-15}{1}", student.FirstName, student.LastName);   
        }

        static void MainX()
        {
            students = new Student[2];
         
            //Классы - это ссылочные типы, поэтому их нужно инициализировать.
            //Можно сделать собственный тип-значение, но это мы рассмотрим позже.
            students[0] = new Student();
            students[0].FirstName = "John";
            students[0].LastName = "Jones";
            students[0].Age = 19;
            students[1] = new Student();
            students[1].FirstName = "William";
            students[1].LastName = "Williams";
            students[1].Age = 18;
            
            //Можно делать это с помощью сокращенной инициализации - это то же самое
            students = new[]
            {
                new Student { LastName="Jones", FirstName="John" },
                new Student { LastName="Williams", FirstName="William" }
            };

        }
    }
}