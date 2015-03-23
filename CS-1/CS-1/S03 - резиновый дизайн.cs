using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide03
{
	public class MyForm : Form
	{
		public MyForm()
		{
			var label = new Label
			{
				Text = "Enter a number"
			};
			var box = new TextBox
			{
				
			};
			var button = new Button
			{
				Text = "Increment!"
			};
			Controls.Add(label);
			Controls.Add(box);
			Controls.Add(button);

			button.Click += (sender, args) => box.Text = (int.Parse(box.Text) + 1).ToString();

			SizeChanged += (sender, args) =>
				{
					label.Size = new Size(ClientSize.Width, 30);
					box.Size = label.Size;
					button.Size = label.Size;

					var totalHeight = label.Height + box.Height + button.Height;
					label.Location = new Point(0, (ClientSize.Height-totalHeight)/2);
					box.Location = new Point(0, label.Bottom);
					button.Location = new Point(0, box.Bottom);
				};
			Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
		}

		public static void MainX()
		{
			Application.Run(new MyForm());
		}

	}

}
