using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture17
{
	class S095___Больше_лямбд
	{
		static Random rnd = new Random();
				static void MainЧ()
		{

			Func<int, int> f = x => x + 1;

			Console.WriteLine(f(1));

			Func<int> generator = () => rnd.Next();

			Console.WriteLine(generator());

			Func<double, double, double> h = (a, b) =>
				{
					b = a % b;
					return b % a;
				};

			Action<int> print = x => Console.WriteLine(x);

			print(generator());

			Action printRandomNumber = () => Console.WriteLine(rnd.Next());

				}
	}
}
