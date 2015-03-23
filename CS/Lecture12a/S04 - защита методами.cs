using System;
using System.Collections.Generic;

namespace Slide04
{
    public class Transaction
    {
        public int DepartmentId;
        public double Profit;
    }


    public class ReportData
    {
        private int departmentsCount;

        public int GetDepartmentsCount() { return departmentsCount; }
        public void SetDepartmentsCount(int value)
        {
            if (value < 0) throw new ArgumentException();
            departmentsCount = value;
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
                // departmentCount=2, -- так писать нельзя, ведь поле приватное
                Transactions = {
                    new Transaction { DepartmentId=0, Profit=10000 },
                    new Transaction { DepartmentId=1, Profit=20000 },
                    new Transaction { DepartmentId=1, Profit=10000 }
                }
            };
            report.SetDepartmentsCount(2); //поэтому придется так.
            report.PrintProfits();

            //но что, если кто-то напишет так?
            //report.departmentsCount = -1; - так теперь написать нельзя
            report.SetDepartmentsCount(-1); //так написать можно, но ошибка возникнет сразу же.
            
            // [....]
            // Учтите, что в реальной разработке в этом месте может пройти несколько часов действий пользователя
            report.PrintProfits(); // и ошибка произойдет теперь не в самом конце, а в момент ее совершения.

            // Все прекрасно, но как написать report.departmentsCount++? Вот так:
            report.SetDepartmentsCount(report.GetDepartmentsCount() + 1);
            // Слегка неизящно.

            // То, что защита целостности выглядит извне сложно и неизящно 
            // мешает программисту ее использовать, и программы получаются плохими.
        }

    }
}