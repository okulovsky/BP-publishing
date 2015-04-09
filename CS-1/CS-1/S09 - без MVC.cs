using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide09
{
	class MyForm : Form
	{
		int size = 5;
		TableLayoutPanel table;

		public MyForm()
		{
			table = new TableLayoutPanel();
			for (int i = 0; i < size; i++)
			{
				table.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / size));
				table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / size));
			}
			for (int column=0;column<size;column++)
				for (int row=0;row<size;row++)
				{
					var button = new Button();
					button.BackColor = (row+column)%2==0?Color.White : Color.Black;
					button.Dock = DockStyle.Fill;
					button.Click += MakeMove;
					table.Controls.Add(button, column, row);
				}
			table.Dock = DockStyle.Fill;
			Controls.Add(table);
		}

		void Flip(Button button)
		{
			button.BackColor=button.BackColor==Color.White?Color.Black:Color.White;
		}

		void MakeMove(object sender, EventArgs e)
		{
			var position = table.GetCellPosition((Control)sender);
			for (int column = 0; column < size; column++)
				Flip((Button)table.GetControlFromPosition(column, position.Row));
			for (int row = 0; row< size; row++)
				Flip((Button)table.GetControlFromPosition(position.Column,row));
			Flip((Button)sender);
		}

		public static void MainX()
		{
			Application.Run(new MyForm { ClientSize = new Size(300, 300) });
		}
	}
}
