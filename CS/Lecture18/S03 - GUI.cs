using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Slide03
{
	public class Program
	{
		static void MainX()
		{
			var form = new Form();
			var button = new Button
			{
				Text = "Click me!",
				Dock = DockStyle.Fill
			};
			button.Click += 
				(s, a) =>
					{
						MessageBox.Show("You clicked the button");
					};
			form.Controls.Add(button);
			Application.Run(form);

		}
	}
}