using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class S05
{
	public static List<int> list = new List<int>();

	static void MakeWork()
	{
		for (int i = 0; ; i++)
		{
			lock (list)
			{
				list.Add(i);
			}
		}
	}

	static void Main()
	{
		new Action(MakeWork).BeginInvoke(null, null);
		while (true)
		{
			lock (list)
			{
				if (list.Count > 100000) list.Clear();
				else if (list.Count > 1) list.RemoveAt(0);
			}
		}

	}

}