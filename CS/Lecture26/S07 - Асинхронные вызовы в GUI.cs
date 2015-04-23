using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HelloWorld
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

		void MakeWorkInThread()
		{
			Thread.Sleep(5000);
			//label.Text = "Complete"; // нельзя обращаться к контролам из неглавного треда
			BeginInvoke(new Action(() => label.Text = "Complete"));

		}

		void MakeWork(object sender, EventArgs e)
		{
			new Action(MakeWorkInThread).BeginInvoke(null, null);
		}

		public static void MainX()
		{
			Application.Run(new MyForm());
		}

	}
}
