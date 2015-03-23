using System;
using System.Collections;
namespace Slide01
{
	public class Program
	{
		public static void Sort(Array array, IComparer comparer)
		{
			for (int i = array.Length - 1; i > 0; i--)
				for (int j = 1; j <= i; j++)
				{
					object element1 = array.GetValue(j - 1);
					object element2 = array.GetValue(j);
					if (comparer.Compare(element1, element2) > 0)
					{
						object temporary = array.GetValue(j);
						array.SetValue(array.GetValue(j - 1), j);
						array.SetValue(temporary, j - 1);
					}
				}
		}

		class StringLengthComparer : IComparer
		{
			public int Compare(object x, object y)
			{
				return (x as string).Length.CompareTo((y as string).Length);
			}
		}

		class StringComparer : IComparer
		{

			public int Compare(object x, object y)
			{
				return (x as string).CompareTo(y as string);
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