
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Slide09
{
    public class Revision
    {
        public string Text { get; set; }
        public int CursorPosition { get; set; }
    }

	public class Program
	{
        static TextBox doc;

        static List<Revision> Revisions = new List<Revision>();

        static void SaveRevision()
        {
            Revisions.Add(new Revision
            {
                 CursorPosition= doc.SelectionStart,
                 Text=doc.Text
            });
        }

		static void Main()
		{
            var form = new Form();
            doc = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill
            };
            form.Controls.Add(doc);
            Application.Run(form);


		}
	}
}