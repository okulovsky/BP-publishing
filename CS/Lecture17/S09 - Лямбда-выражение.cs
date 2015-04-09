using System;
using System.Collections;
using System.Collections.Generic;
namespace Slide09
{

	public class Program
	{
		public static void Sort<T>(T[] array, Func<T,T,int> comparer)
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


		static void MainX()
		{
			var strings = new[] { "A", "B", "AA" };
			Sort(strings, (x,y)=>x.Length.CompareTo(y.Length));
		}
	}
}