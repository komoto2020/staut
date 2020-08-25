using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace staut
{
	class CreateTools
	{
		public static Label createLabel(string name, string text, int[] locate, ScrollableControl container)
		{
			Label label = new Label();
			label.Name = name;
			label.Location = new Point(locate[0], locate[1]);
			label.Text = text;
			container.Controls.Add(label);
			return label;
		}

		public static TextBox createTextBox(string name, int[] locate, int[] size, ScrollableControl container)
		{
			TextBox textBox = new TextBox();
			textBox.Name = name;
			textBox.Location = new Point(locate[0], locate[1]);
			textBox.Size = new Size(size[0], size[1]);
			container.Controls.Add(textBox);
			return textBox;
		}

		public static Button createButton(string name, string text, int tag, int[] locate, int[] size, ScrollableControl container)
		{
			Button button = new Button();
			button.Name = name;
			button.Text = text;
			button.Tag = tag;
			button.Location = new Point(locate[0], locate[1]);
			button.Size = new Size(size[0], size[1]);
			container.Controls.Add(button);
			return button;
		}

	}
}
