
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



class S04
{
	static string PolishNotation(Expression expression)
	{
		if (expression is ConstantExpression)
			return ((ConstantExpression)expression).Value.ToString();
		else if (expression is ParameterExpression)
			return ((ParameterExpression)expression).Name;
		else if (expression is BinaryExpression)
		{
			var e = (BinaryExpression)expression;
			return string.Format("[{0}] {1} {2}",
				e.NodeType,
				PolishNotation(e.Left),
				PolishNotation(e.Right)
				);
		}
		else throw new NotImplementedException();
	}

	static string PolishNotation(Expression<Func<int, int>> tree)
	{
		return PolishNotation(tree.Body);
	}

	static void Main()
	{

		Console.WriteLine(PolishNotation(x => 2 * x + 5));
	}
}