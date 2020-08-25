using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

using staut_ClassLibrary;

namespace staut
{
	public partial class addEditForm : Form
	{
		private int numberofAPBClicks;  //「プログラムを追加」ボタンが押された回数
		private TextBox[] prognameTextBoxes; //プログラム名入力テキストボックスの集まり
		private TextBox[] pathTextBoxes; //パス入力テキストボックスの集まり
		private const int PROG_NUM = 10; //同時に起動できるファイルの数

		public addEditForm()
		{
			InitializeComponent();
			numberofAPBClicks = 0;
			prognameTextBoxes = new TextBox[PROG_NUM];
			prognameTextBoxes[0] = prognameTextBox1; //デフォルトであるプログラム名入力テキストボックスを格納
			pathTextBoxes = new TextBox[PROG_NUM];
			pathTextBoxes[0] = pathTextBox1; //デフォルトであるパス入力テキストボックスを格納
		}

		private void progRefeButton_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.InitialDirectory = Environment.CurrentDirectory;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				int tag = Convert.ToInt32(button.Tag);
				pathTextBoxes[tag - 1].Text = dialog.FileName;
			}
			else
			{
				Console.WriteLine("canceled progRefButton Dialog");
			}
			dialog.Dispose();
			return;
		}


		//「プログラムを追加」ボタン
		private void addProgButton_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Clicked addProgramButton in addEditForm");
			numberofAPBClicks++; //クリック回数のカウント

			//パステキストボックスの作成上限数を超えた場合（プログラム追加上限数を超えた場合）
			if (numberofAPBClicks >= PROG_NUM) 
			{
				MessageBox.Show("これ以上プログラムを追加できません。","追加不可", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			//prognameLabel
			string PNLABEL_NAME = $"prognameLabel{numberofAPBClicks+1}";
			string PNLABEL_TEXT = $"{numberofAPBClicks+1}. プログラム名";
			const int PNLABEL_OFFSET = 100;
			int[] PNLABEL_LOCATE = {
				prognameLabel1.Location.X, //X座標
				PNLABEL_OFFSET * numberofAPBClicks + allProgPanel.AutoScrollPosition.Y //Y座標
			};

			//pathLabel
			string PATHLABEL_NAME = $"pathLabel{numberofAPBClicks+1}";
			const string PATHLABEL_TEXT = "パス";
			const int PATHLABEL_OFFSET = 100;
			int[] PATHLABEL_LOCATE = {
				pathLabel1.Location.X, //X座標
				PATHLABEL_OFFSET * numberofAPBClicks + allProgPanel.AutoScrollPosition.Y //Y座標
			};

			//prognameTextBox
			string PNBOX_NAME = $"prognameTextBox{numberofAPBClicks+1}";
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
			string PATHBOX_NAME = $"pathTextBox{numberofAPBClicks+1}";
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

			//progRefeButton
			string PRBUTTON_NAME = $"progRefeButton{numberofAPBClicks+1}";
			const string PRBUTTON_TEXT = "参照";
			int PRBUTTON_TAG = numberofAPBClicks + 1;
			const int PRBUTTON_OFFSET = 100;
			const int PRBUTTON_FIRST_OFFSET = 28;
			int[] PRBUTTON_LOCATE ={
				progRefeButton1.Location.X,
				PRBUTTON_OFFSET * numberofAPBClicks + PRBUTTON_FIRST_OFFSET + allProgPanel.AutoScrollPosition.Y
			};
			int[] PRBUTTON_SIZE ={
				progRefeButton1.Size.Width,
				progRefeButton1.Size.Height
			};

			CreateTools.createLabel(PNLABEL_NAME, PNLABEL_TEXT, PNLABEL_LOCATE, allProgPanel);
			CreateTools.createLabel(PATHLABEL_NAME, PATHLABEL_TEXT, PATHLABEL_LOCATE, allProgPanel);
			TextBox prognameTextBox = CreateTools.createTextBox(PNBOX_NAME, PNBOX_LOCATE, PNBOX_SIZE, allProgPanel);
			prognameTextBoxes[numberofAPBClicks] = prognameTextBox;
			TextBox pathTextBox = CreateTools.createTextBox(PATHBOX_NAME, PATHBOX_LOCATE, PATHBOX_SIZE, allProgPanel);
			pathTextBoxes[numberofAPBClicks] = pathTextBox;
			Button button = CreateTools.createButton(PRBUTTON_NAME, PRBUTTON_TEXT, PRBUTTON_TAG, PRBUTTON_LOCATE, PRBUTTON_SIZE, allProgPanel);
			button.Click += progRefeButton_Click;
			return;
		}

		//「決定」ボタン
		//データベース
		private void decideButton_Click(object sender, EventArgs e)
		{
			using(var db = new SetTitleDbContext())
			{
				db.Add(new SetTitle { TitleName = settitleTextBox.Text });
				db.SaveChanges();

				var set = db.SetTitles
					.OrderBy(s => s.SetTitleId)
					.Last();
				for (int i = 0; i < PROG_NUM; i++)
				{
					try
					{
						set.StartupProgs.Add(new StartupProg
						{
							StartupProgName = prognameTextBoxes[i].Text,
							StartupProgPath = pathTextBoxes[i].Text,
							SetTitleId = set.SetTitleId,
							SetTitle = set
						});
						db.SaveChanges();
					}
					catch (NullReferenceException ne) //起動できる上限数より少ないファイルを設定した場合
					{
						db.SaveChanges();
						break;
					}
				}
				ShowTables(db);
				return; 
			}
		}

		private void ShowTables(SetTitleDbContext db)
		{
			var queryAllSetTiles = from setTitle in db.SetTitles
									select setTitle;
			var queryAllStartupProg = from startupProg in db.StartupProgs
								   select startupProg;

			foreach (var data in queryAllSetTiles)
			{
				Console.WriteLine("SetTitleId = " + data.SetTitleId);
				Console.WriteLine("SetTitleName = " + data.TitleName);
				Console.WriteLine("SetTitle_StartupProg_Count = " + data.StartupProgs.Count);
			}
			Console.WriteLine();

			foreach (var data in queryAllStartupProg)
			{
				Console.WriteLine("StartupProgId = " + data.StartupProgId);
				Console.WriteLine("StartupProgName = " + data.StartupProgName);
				Console.WriteLine("StartupProgPath = " + data.StartupProgPath);
				Console.WriteLine("StartupProg_SetTitleId = " + data.SetTitleId);
				Console.WriteLine("StartupProg_SetTitle = " + data.SetTitle.SetTitleId);
			}
			Console.WriteLine();
		}
	}
}
