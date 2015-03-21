using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide04
{
	public class MyForm : Form
	{
		public MyForm()
		{
			var label = new Label
			{
				Text = "Enter a number",
				Dock = DockStyle.Top
			};
			var box = new TextBox
			{
				Dock=DockStyle.Top
			};
			var button = new Button
			{
				Text = "Increment!",
				Dock = DockStyle.Top
			};
			Controls.Add(button);
			Controls.Add(box);
			Controls.Add(label);
			

			button.Click += (sender, args) => box.Text = (int.Parse(box.Text) + 1).ToString();

		}

		public static void MainX()
		{
			Application.Run(new MyForm());
		}

	}

}
