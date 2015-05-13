using System;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




class Program
{
	static void Example1()
	{
		var x = Expression.Parameter(typeof(int), "x");
		var expression = Expression.Lambda<Func<int, int>>(
			Expression.Add(
				Expression.Multiply(
					Expression.Constant(2),
					x),
				Expression.Constant(5)),
			x);
		var f = expression.Compile();
		Console.WriteLine(f(3));
		
		// Func<int,int> f = x => x * 2 + 5; 
	}

	static void Example2()
	{
		var x = Expression.Parameter(typeof(DateTime), "x");
		var f = Expression.Lambda<Func<DateTime, int>>(
			Expression.MakeMemberAccess(
				x,
				typeof(DateTime).GetProperty("Year")),
			x).Compile();
		Console.WriteLine(f(DateTime.Now));

		//Func<DateTime, int> f = x => x.Year;
	}

	static void Example3()
	{
		var x = Expression.Parameter(typeof(string), "x");
		var n = Expression.Parameter(typeof(int), "n");

		var f = Expression.Lambda<Func<string, int, string>>(
			Expression.Call(
				x,
				typeof(string).GetMethod("Substring", new[] { typeof(int), typeof(int) }),
				Expression.Constant(0),
				n
			),
			x, n).Compile();

		Console.WriteLine(f("abcdef", 4));

		//unc<string, int, string> f = (x, n) => x.Substring(0, n);
	}
}