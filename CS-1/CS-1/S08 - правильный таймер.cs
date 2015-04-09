using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide08
{
	class MyForm : Form
	{
		public MyForm()
		{
			DoubleBuffered = true;
			var timer = new Timer();
			timer.Interval = 500;
			timer.Tick += (sender, args) =>
			{
				sceneState++;
				Invalidate();

			};
			timer.Start();
		}

		int sceneState;

		protected override void OnPaint(PaintEventArgs e)
		{
			var radius = Math.Min(ClientSize.Width, ClientSize.Height) / 3;
			var centerX = ClientSize.Width / 2;
			var centerY = ClientSize.Height / 2;
			var size = 400;
			e.Graphics.Clear(Color.White);
			e.Graphics.FillEllipse(
				Brushes.Blue,
				new Rectangle(
					(int)(centerX + radius * Math.Cos(sceneState * Math.PI / 6) - size / 2),
					(int)(centerY - radius * Math.Sin(sceneState * Math.PI / 6) - size / 2),
					size,
					size));
		}

		public static void MainX()
		{
			Application.Run(new MyForm { ClientSize = new Size(300, 300) });
		}
	}
}
