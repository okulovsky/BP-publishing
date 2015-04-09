using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Slide07
{
	class MyForm : Form
	{
		public MyForm()
		{
			int time = 0;
			var timer = new Timer();
			timer.Interval = 500;
			var radius = Math.Min(ClientSize.Width,ClientSize.Height)/3;
			var centerX = ClientSize.Width/2;
			var centerY = ClientSize.Height/2;
			var size = 400;
			timer.Tick += (sender, args) =>
			{
				time++;
				var graphics = CreateGraphics();
				graphics.Clear(Color.White);
				graphics.FillEllipse(
					Brushes.Blue,
					new Rectangle(
						(int)(centerX + radius * Math.Cos(time * Math.PI / 6) - size / 2),
						(int)(centerY - radius * Math.Sin(time * Math.PI / 6) - size / 2),
						size,
						size));
			};
			timer.Start();
		}

		public static void MainЧ()
		{
			Application.Run(new MyForm { ClientSize = new Size(300, 300) });
		}
	}
}
