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
			ClientSize = new Size(600, 600);
			var centerX = ClientSize.Width / 2;
			var centerY = ClientSize.Height / 2;
			var size = 100;
			var radius = Math.Min(ClientSize.Width, ClientSize.Height) / 3;
			
			int time = 0;
			var timer = new Timer();
			timer.Interval = 500;
			timer.Tick += (sender, args) =>
			{
				time++;
				var graphics = CreateGraphics();
				graphics.TranslateTransform(centerX, centerY);
				graphics.RotateTransform(-time*(360f / 12));
				graphics.FillEllipse(
					Brushes.Blue,
					new Rectangle(radius-size/2, -size/2,size,size));
						
			};
			timer.Start();
		}

		public static void MainX()
		{
			Application.Run(new MyForm());
		}
	}
}
