using System;
using System.Collections;
using System.Collections.Generic;
namespace Slide06
{
	public delegate int StringComparer<T>(T x, T y);

	
	public class Program
	{
		public static void Sort<T>(T[] array, StringComparer<T> comparer)
		{
			for (int i = array.Length - 1; i > 0; i--)
				for (int j = 1; j <= i; j++)
				{
					var element1 = array[j - 1];
					var element2 = array[j];
					if (comparer(element1, element2) > 0)
					{
						var temporary = array[j];
						array[j] = array[j - 1];
						array[j - 1] = temporary;
					}
				}
		}

	
		static int CompareStringLength(string x, string y)
		{
			return x.Length.CompareTo(y.Length);
		}

		class MyClass
		{
			public bool Descending { get; set; }
			public int CompareStrings(string x, string y)
			{
				return x.CompareTo(y) * (Descending ? -1 : 1);
			}
		}

		static void MainX()
		{
			var strings = new[] { "A", "B", "AA" };
			Sort(strings, CompareStringLength);
			var obj = new MyClass { Descending = true };
			Sort(strings, obj.CompareStrings);
		}
	}
}