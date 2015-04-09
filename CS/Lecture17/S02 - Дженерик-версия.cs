using System;
using System.Collections;
using System.Collections.Generic;
namespace Slide02
{
	public class Program
	{
		public static void Sort<T>(T[] array, IComparer<T> comparer)
		{
			for (int i = array.Length - 1; i > 0; i--)
				for (int j = 1; j <= i; j++)
				{
					var element1 = array[j - 1];
					var element2 = array[j];
					if (comparer.Compare(element1, element2) > 0)
					{
						var temporary = array[j];
						array[j] = array[j - 1];
						array[j - 1] = temporary;
					}
				}
		}

		class StringLengthComparer : IComparer<string>
		{
			public int Compare(string x, string y)
			{
				return x.Length.CompareTo(y.Length);
			}
		}

		class StringComparer : IComparer<string>
		{
			public int Compare(string x, string y)
			{
				return x.CompareTo(y);
			}
		}

		static void MainX()
		{
			var strings = new[] { "A", "B", "AA" };
			Sort(strings,new StringComparer());
			Sort(strings, new StringLengthComparer());
		}
	}
}