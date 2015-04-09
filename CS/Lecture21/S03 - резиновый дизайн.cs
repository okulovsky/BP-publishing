using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
	class MyForm : Form
	{
		public MyForm()
		{
			var label = new Label();
			label.Text = "Введите число";
			Controls.Add(label);

			var input = new TextBox();
			Controls.Add(input);

			var button = new Button();
			button.Text = "Увеличить!";
			button.Click += (sender, args) =>
			{
				var number = int.Parse(input.Text);
				number++;
				input.Text = number.ToString();
			};
			Controls.Add(button);

			var sizeChangedHandler = new EventHandler((sender, args) =>
			{
				var height = 30;

				label.Location = new Point(0, (ClientSize.Height - height * 3) / 2);
				label.Size = new Size(ClientSize.Width, height);
				input.Location = new Point(0, label.Bottom);
				input.Size = label.Size;
				button.Location = new Point(0, input.Bottom);
				button.Size = label.Size;

			});

			SizeChanged += sizeChangedHandler;
			Load += sizeChangedHandler;


		}

		public static void MainX()
		{
			Application.Run(new MyForm());
		}
	}
}
