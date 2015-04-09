using System;
using System.Collections.Generic;

namespace Slide08
{
    public class Program
    {
        static void MainX()
        {
            Console.WriteLine(Compute("23+4*"));
        }

        static int Compute(string str)
        {
            var stack=new Stack<int>();
            foreach (var e in str)
            {
                if (e <= '9' && e >= '0')
                {
                    stack.Push(e - '0');
                    continue;
                }
                switch (e)
                {
                    case '+':
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case '-':
                        stack.Push(stack.Pop() - stack.Pop());
                        break;
                    case '*':
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case '/':
                        stack.Push(stack.Pop() / stack.Pop());
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            return stack.Pop();
        }

        //Небольшая затравка на будущее: как убрать DRY в этом случае?
        static int Compute1(string str)
        {
            var operations = new Dictionary<char, Func<int, int, int>>();
            operations.Add('+', (x, y) => x + y);
            operations.Add('-', (x, y) => x - y);
            operations.Add('*', (x, y) => x * y);
            operations.Add('/', (x, y) => x / y);

            var stack = new Stack<int>();
            foreach (var e in str)
            {
                if (e <= '9' && e >= '0')
                    stack.Push(e - '0');
                else if (operations.ContainsKey(e))
                    stack.Push(operations[e](stack.Pop(), stack.Pop()));
                else 
                    throw new ArgumentException();
            }
            return stack.Pop();
        }
    }
}