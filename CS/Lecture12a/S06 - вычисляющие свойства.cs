using System;

namespace Slide06
{
    public class Purchase
    {
        public double Price { get; set; }
        public double Count { get; set; }

        //В этом случае никакого поля не создается, и вообще это свойство не связано с хранением данных
        //Это просто удобный синтаксический сахар, можно было бы использовать метод GetSalary() { return Price*Count; }
        //Но в шарпе принято писать так
        public double Summary
        {
            get { return Price * Count; }
        }
    }

    public class Program
    {
        static void MainX()
        {
            var purchase = new Purchase { Price = 1000, Count = 5 };
            // purchase.Summary=100; // так нельзя, поскольку сеттер не определен
            Console.WriteLine(purchase.Summary);

        }
    }
}
