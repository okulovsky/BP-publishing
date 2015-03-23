using System;
using System.Collections;
using System.Collections.Generic;

namespace Slide06
{
    public class Program
    {
        static void MainX()
        {
            var myIntQueue = new Slide05.Queue<int>();
            myIntQueue.Enqueue(10);
            myIntQueue.Enqueue(20);
            myIntQueue.Enqueue(30);

            //myIntQueue.Enqueue("Surprise"); // - здесь будет ошибка компиляции

            //И это универсальное решение проблемы даункастов
            var arrayList = new ArrayList(); //лист чего угодно, устаревший
            arrayList.Add(10); arrayList.Add(20);
            
            int sum = 0;
            foreach (object obj in arrayList)
                sum += (int)obj; //Даункаст
            
            foreach (int number in arrayList) //Даункаст переехал в эту строчку
                sum += number;

            var list = new List<int>();
            list.Add(10); list.Add(20);

            foreach (int number in list) // Даункаста нет
                sum += number;

            foreach (var number in list) // Можно писать так
                sum += number;


        }
    }
}