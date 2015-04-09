using System;

namespace Slide05
{
    public class Student
    {
        //Даже в тех случаях, когда поля не требуют процедуры проверки целостности
        //используют свойства.
        public string lastName;
        public string LastName
        {
            get { return lastName; } //часто здесь пишут LastName вместо lastName, получают рекурсию и переполнение стэка. Осторожнее!
            set { lastName = value; }
        }

        //Чтобы упростить эту практику, придумали автосвойства
        //Следующая строка делает то же самое, что и предыдущие 5, автоматически
        public string FirstName { get; set; }

        //Возможен различные модификаторы доступа у свойств
        public string Id { get; private set; }


    }
}