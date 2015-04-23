using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class S01
{
	static void MakeWork(int number)
	{
		double a = 1;
		while (true)
		{
			for (int i = 0; i < 1000000; i++)
				a /= 1.01;
			Console.WriteLine(number);
		}
	}

	static void MainX()
	{
		var thread = new Thread(new ThreadStart(() => MakeWork(1)));
		thread.Start();
		thread = new Thread(new ThreadStart(() => MakeWork(2)));
		thread.Start();
		Thread.Sleep(Timeout.Infinite);
	}

}