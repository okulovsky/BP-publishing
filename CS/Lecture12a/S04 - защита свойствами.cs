using System;
using System.Collections.Generic;

namespace Slide05
{
    public class Transaction
    {
        public int DepartmentId;
        public double Profit;
    }


    public class ReportData
    {
        private int departmentsCount;

        public int DepartmentsCount
        {
            get { return departmentsCount; }
            set
            {
                if (value < 0) throw new ArgumentException();
                departmentsCount = value;
            }
        }

        public List<Transaction> Transactions = new List<Transaction>();
        public void PrintProfits()
        {
            var profits = new double[departmentsCount];
            foreach (var e in Transactions)
                profits[e.DepartmentId] += e.Profit;
            for (int i = 0; i < departmentsCount; i++)
                Console.WriteLine("{0,-10}{1}", i, profits[i]);
        }
    }

    public class Program
    {
        public static void MainX()
        {
            var report = new ReportData
            {
                DepartmentsCount=2, //теперь снова можно писать так
                Transactions = {
                    new Transaction { DepartmentId=0, Profit=10000 },
                    new Transaction { DepartmentId=1, Profit=20000 },
                    new Transaction { DepartmentId=1, Profit=10000 }
                }
            };
            // report.SetDepartmentsCount(2); -- так, разумеется, писать нельзя, никаких методов больше нет, есть свойства
            report.PrintProfits();

            report.DepartmentsCount++; //а так писать можно.

            //report.departmentsCount = -1; - так по-прежнему писать нельзя
            report.DepartmentsCount = -1; // Так можно, и мы поймаем исключение
        }

    }
}