
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class JsonConvert
{
	public static string SerializeObject(object obj)
	{ return null; }

}

class Student
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
}

class Program
{
	public static void Main()
	{
		var students = new List<Student>
	{
		new Student 
		{
			FirstName = "John",
			LastName = "Smith",
			Age = 20
		},
		new Student 
		{
			FirstName = "James",
			LastName = "Adams",
			Age=19
		}
	};
		var str = JsonConvert.SerializeObject(students);
		Console.WriteLine(str);

	}
}