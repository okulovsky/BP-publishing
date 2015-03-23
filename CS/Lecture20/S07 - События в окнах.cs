using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Slide07
{
	public class Program
	{
		static void MainX()
		{
			var form = new Form();
			form.FormClosing += (sender, args) =>
				{
					var result = MessageBox.Show("Действительно закрыть?", "", MessageBoxButtons.YesNo);
					if (result != DialogResult.Yes) args.Cancel = true;
				};

		}
	}

	class MyWindow : Form
	{
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			var result = MessageBox.Show("Действительно закрыть?", "", MessageBoxButtons.YesNo);
			if (result != DialogResult.Yes) e.Cancel = true;
		}

	}
}