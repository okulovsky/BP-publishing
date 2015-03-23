
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Slide08
{
	public class Program
	{

		static void CreateReport(string monthName)
		{
			MessageBox.Show("Создаю отчет за " + monthName + "...");
		}

		static void MenuItemSelected(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			CreateReport(menuItem.Text);
		}

		public static void Main()
		{
			var monthNames = new[] { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", " декабрь" };
			var menuItems = monthNames
				.Select(name =>
				{
					var menuItem = new MenuItem(name);
					menuItem.Click += (sender, args) => CreateReport(name);
					return menuItem;
				})
				.ToArray();

			//Но раньше, когда не было лямбда-выражений, приходилось писать так:
			menuItems = new MenuItem[monthNames.Length];
			for (int i = 0; i < menuItems.Length; i++)
			{
				var item = new MenuItem(monthNames[i]);
				item.Click += MenuItemSelected;
				menuItems[i] = item;
			}

			var mainMenu = new MainMenu(
				new[]
				{
					new MenuItem("Создать отчет", menuItems)
				});
			var form = new Form();
			form.Menu = mainMenu;
			Application.Run(form);
		}
	}
}