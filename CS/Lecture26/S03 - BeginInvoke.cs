using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class S03
{
	static double MakeWork(int number)
	{
		double a = 1;

		for (int i = 0; i < 1000000; i++)
			for (int j = 0; j < 10; j++)
				a /= 1.01;
		Console.WriteLine(number);
		return a;
	}

	static void Main()
	{
		var func = new Func<int, double>(MakeWork);
		var result = func.BeginInvoke(1, null, null);
		while (!result.IsCompleted)
			Console.Write(".");
		var returnedValue = func.EndInvoke(result);
	}

}
