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
			Console.WriteLine("Clicked addProgramButton in addEditForm");
			numberofAPBClicks++; //クリック回数のカウント

			//prognameLabel
			string PNLABEL_NAME = $"prognameLabel{numberofAPBClicks}";
			const string PNLABEL_TEXT = "プログラム名";
			const int PNLABEL_OFFSET = 100;
			int[] PNLABEL_LOCATE = {
				prognameLabel1.Location.X, //X座標
				PNLABEL_OFFSET * numberofAPBClicks + allProgPanel.AutoScrollPosition.Y //Y座標
			};

			//pathLabel
			string PATHLABEL_NAME = $"pathLabel{numberofAPBClicks}";
			const string PATHLABEL_TEXT = "パス";
			const int PATHLABEL_OFFSET = 100;
			int[] PATHLABEL_LOCATE = {
				pathLabel1.Location.X, //X座標
				PATHLABEL_OFFSET * numberofAPBClicks + allProgPanel.AutoScrollPosition.Y //Y座標
			};

			//prognameTextBox
			string PNBOX_NAME = $"prognameTextBox{numberofAPBClicks}";
			const int PNBOX_OFFSET = 100; //テキストボックス間の距離（Y）
			const int PNBOX_FIRST_OFFSET = 28; //Panelと最上部のテキストボックスとの距離（Y）
			int[] PNBOX_LOCATE = { 
				prognameTextBox1.Location.X, //X座標
				PNBOX_OFFSET * numberofAPBClicks + PNBOX_FIRST_OFFSET + allProgPanel.AutoScrollPosition.Y //Y座標
			};
			int[] PNBOX_SIZE = {
				prognameTextBox1.Size.Width, //テキストボックス幅
				prognameTextBox1.Size.Height //テキストボックス高さ
			};

			//pathTextBox
			string PATHBOX_NAME = $"pathTextBox{numberofAPBClicks}";
			const int PATHBOX_OFFSET = 100;
			const int PATHBOX_FIRST_OFFSET = 28; //Panelと最上部のテキストボックスとの距離（Y）
			int[] PATHBOX_LOCATE = {
				pathTextBox1.Location.X, //X座標
				PATHBOX_OFFSET * numberofAPBClicks + PATHBOX_FIRST_OFFSET + allProgPanel.AutoScrollPosition.Y //Y座標
			};
			int[] PATHBOX_SIZE = {
				pathTextBox1.Size.Width, //テキストボックス幅
				pathTextBox1.Size.Height //テキストボックス高さ
			};

			createLabel(PNLABEL_NAME, PNLABEL_TEXT, PNLABEL_LOCATE);
			createLabel(PATHLABEL_NAME, PATHLABEL_TEXT, PATHLABEL_LOCATE);
			createTextBox(PNBOX_NAME, PNBOX_LOCATE, PNBOX_SIZE);
			createTextBox(PATHBOX_NAME, PATHBOX_LOCATE, PATHBOX_SIZE);
		}

		private void createLabel(string name, string text, int[] locate)
		{
			Label label = new Label();
			label.Location = new Point(locate[0], locate[1]);
			label.Text = text;
			allProgPanel.Controls.Add(label);
		}

		private void createTextBox(string name, int[] locate, int[] size)
		{
			TextBox textBox = new TextBox();
			textBox.Location = new Point(locate[0], locate[1]);
			textBox.Size = new Size(size[0], size[1]);
			allProgPanel.Controls.Add(textBox);
		}
	}
}
