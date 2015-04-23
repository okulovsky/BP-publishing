using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class S04
{
	static void MakeWork(int number)
	{
		double a = 1;

		for (int i = 0; i < 1000000; i++)
			for (int j = 0; j < 50; j++)
				a /= 1.01;
		Console.WriteLine(number);
	}

	static void MainX()
	{
		Parallel.For(0, 10, MakeWork);
	}

}