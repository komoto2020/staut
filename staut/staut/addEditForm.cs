using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace staut
{
	public partial class addEditForm : Form
	{
		private int numberofAPBClicks;  //「プログラムを追加」ボタンが押された回数

		public addEditForm()
		{
			InitializeComponent();
			numberofAPBClicks = 0;
		}

		//「プログラムを追加」ボタン
		private void addProgButton_Click(object sender, EventArgs e)
		{
			numberofAPBClicks++;

			//prognameLabel
			const string PNLABEL_TEXT = "プログラム名";
			string PNLABEL_NAME = $"prognameLabel{numberofAPBClicks}";
			const int PNLABEL_OFFSET = 100;
			int PNLABEL_X = prognameLabel1.Location.X; //prognameLabelのX座標
			int PNLABEL_Y = PNLABEL_OFFSET * numberofAPBClicks + allProgPanel.AutoScrollPosition.Y; //prognameLabelのY座標

			//pathLabel
			const string PATHLABEL_TEXT = "パス";
			string PATHLABEL_NAME = $"pathLabel{numberofAPBClicks}";
			const int PATHLABEL_OFFSET = 100;
			int PATHLABEL_X = pathLabel1.Location.X; //pathLabelのX座標
			int PATHLABEL_Y = PATHLABEL_OFFSET * numberofAPBClicks + allProgPanel.AutoScrollPosition.Y; //pathLabelのY座標

			//prognameTextBox
			const int PNBOX_OFFSET = 100;
			string PNBOX_NAME = $"prognameTextBox{numberofAPBClicks}";
			int PNBOX_X = prognameTextBox1.Location.X; //prognameTextBoxのX座標
			int PNBOX_Y = PNBOX_OFFSET * numberofAPBClicks + 28 + allProgPanel.AutoScrollPosition.Y; //prognameTextBoxのX座標
			int PNBOX_SIZE_X = prognameTextBox1.Size.Width;
			int PNBOX_SIZE_Y = prognameTextBox1.Size.Height;

			//pathTextBox
			const int PATHBOX_OFFSET = 100;
			string PATHBOX_NAME = $"pathTextBox{numberofAPBClicks}";
			int PATHBOX_X = pathTextBox1.Location.X; //prognameTextBoxのX座標
			int PATHBOX_Y = PATHBOX_OFFSET * numberofAPBClicks + 28 + allProgPanel.AutoScrollPosition.Y; //prognameTextBoxのX座標
			int PATHBOX_SIZE_X = pathTextBox1.Size.Width;
			int PATHBOX_SIZE_Y = pathTextBox1.Size.Height;


			Console.WriteLine("add program");

			Label prognameLabel = new Label();
			prognameLabel.Location = new Point(PNLABEL_X, PNLABEL_Y);
			prognameLabel.Text = PNLABEL_TEXT;
			allProgPanel.Controls.Add(prognameLabel);

			Label pathLabel = new Label();
			pathLabel.Location = new Point(PATHLABEL_X, PATHLABEL_Y);
			pathLabel.Text = PATHLABEL_TEXT;
			allProgPanel.Controls.Add(pathLabel);

			TextBox prognameTextBox = new TextBox();
			prognameTextBox.Location = new Point(PNBOX_X, PNBOX_Y);
			prognameTextBox.Size = new Size(PNBOX_SIZE_X, PNBOX_SIZE_Y); ;
			allProgPanel.Controls.Add(prognameTextBox);

			TextBox pathTextBox = new TextBox();
			pathTextBox.Location = new Point(PATHBOX_X, PATHBOX_Y);
			pathTextBox.Size = new Size(PATHBOX_SIZE_X, PATHBOX_SIZE_Y);
			allProgPanel.Controls.Add(pathTextBox);

			Console.WriteLine($"prognameTextBox01.Location.Y = {prognameTextBox1.Location.Y}");
			Console.WriteLine($" allProgPanel.AutoScrollPosition.Y = { allProgPanel.AutoScrollPosition.Y}");
			
			Console.WriteLine($"PNLABEL(X, Y) = ({PNLABEL_X}, {PNLABEL_Y})");
			Console.WriteLine($"PATHLABEL(X, Y) = ({PATHLABEL_X}, {PATHLABEL_Y})");
			Console.WriteLine($"PNBOX(X, Y) = ({PNBOX_X}, {PNBOX_Y})");
			Console.WriteLine($"PATHBOX(X, Y) = ({PATHBOX_X}, {PATHBOX_Y})");
		}

	}
}
