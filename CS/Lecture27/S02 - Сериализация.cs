namespace S02
{
	using System;
	using System.Text;
	class Enterprise
	{
		public string Name { get; set; }
		public string DirectorName { get; set; }
		public string RegistrationNumber { get; set; }

	}

	class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	class Program
	{
		static void Print(object obj)
		{
			var builder = new StringBuilder();

			var type = obj.GetType();
			foreach (var property in type.GetProperties())
			{
				builder.Append(property.Name);
				builder.Append(" : ");
				builder.Append(property.GetValue(obj));
				builder.Append("\n");
			}
			var str = builder.ToString();
			Console.WriteLine(str);
		}

		public static void Main()
		{
			var enterprise = new Enterprise { Name = "Vector", DirectorName = "Jones", RegistrationNumber = "123" };
			Print(enterprise);

			var person = new Person { FirstName = "William", LastName = "Smith" };
			Print(person);
		}
	}
}