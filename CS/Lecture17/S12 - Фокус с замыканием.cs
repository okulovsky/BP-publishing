using System;
using System.Collections;
using System.Collections.Generic;
namespace Slide102
{

	public class Program
	{
		static void Main()
		{
			var functions = new List<Func<int,int>>();

			for (int i = 0; i < 10; i++)
				functions.Add(x => x + i);
			
			foreach(var e in functions)
				Console.WriteLine(e(0));
		}
	}
}