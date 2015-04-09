using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace S01
{
	class MyClass
	{
		public int Property { get; set; }
		private bool Field;
		public int Method(int argument)
		{
			return Property + argument;
		}
	}

	class Program
	{
		public static void Main()
		{
			var obj = new MyClass();
			obj.Property = 5;
			var variable = obj.Method(3);

			Type type = typeof(MyClass);
			ConstructorInfo ctor = type.GetConstructor(new Type[] { });
			var result = ctor.Invoke(new object[] { });

			var propertyInfo = type.GetProperty("Property");
			propertyInfo.SetValue(result, 5);
			var variable1 = (int)type.GetMethod("Method").Invoke(result, new object[] { 3 });

			var field = type.GetField("Field", BindingFlags.NonPublic | BindingFlags.Instance);
			field.SetValue(result, true);
		}
	}
}