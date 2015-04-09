using System;
using System.Collections.Generic;

namespace Slide03
{
    public class Transaction
    {
        public int DepartmentId;
        public double Profit;
    }


    public class ReportData
    {
        public int DepartmentsCount;
        public List<Transaction> Transactions = new List<Transaction>();
        public void PrintProfits()
        {
            var profits = new double[DepartmentsCount];
            foreach (var e in Transactions)
                profits[e.DepartmentId] += e.Profit;
            for (int i = 0; i < DepartmentsCount; i++)
                Console.WriteLine("{0,-10}{1}", i, profits[i]);
        }
    }

    public class Program
    {
        public static void MainX()
        {
            var report = new ReportData
            {
                DepartmentsCount = 2,
                Transactions = {
                    new Transaction { DepartmentId=0, Profit=10000 },
                    new Transaction { DepartmentId=1, Profit=20000 },
                    new Transaction { DepartmentId=1, Profit=10000 }
                }
            };
            report.PrintProfits();

            //но что, если кто-то напишет так?
            report.DepartmentsCount = -1;
            report.PrintProfits();

        }

    }
}