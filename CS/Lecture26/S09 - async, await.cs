using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S09
{
	class MyForm : Form
	{
		Label label;
		Button button;
		public MyForm()
		{
			label = new Label { Size = new Size(ClientSize.Width, 30) };
			button = new Button
			{
				Location = new Point(0, label.Bottom),
				Size = label.Size
			};
			button.Click += MakeWork;
			Controls.Add(label);
			Controls.Add(button);
		}

		Task<string> MakeWorkInThread()
		{
			var task = new Task<string>(
				() => { Thread.Sleep(5000); return "Completed"; }
				);
			task.Start();
			return task;
		}

		async void MakeWork(object sender, EventArgs e)
		{
			var labelText = await MakeWorkInThread();
			label.Text = labelText;
		}

		public static void MainX()
		{
			Application.Run(new MyForm());
		}

	}
}
