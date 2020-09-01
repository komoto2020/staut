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
		private int numberofProgram = 0;  //当該セットに追加されている起動プログラム数
		private const int PROG_NUM = 10; //同時に起動できるファイルの数
		private TextBox[] prognameTextBoxes = new TextBox[PROG_NUM]; //プログラム名入力テキストボックスの集まり
		private TextBox[] pathTextBoxes = new TextBox[PROG_NUM]; //パス入力テキストボックスの集まり

		//セットを新規作成する場合のインスタンス処理
		public addEditForm() 
		{
			InitializeComponent();
			CreateComponentCluster();
		}

		//既存セットを編集するときのインスタンス処理
		public addEditForm (IQueryable<SetTitle> setTitles, IQueryable<StartupProg> startupProgs) 
		{
			InitializeComponent();
			Console.WriteLine($"setTitle_data = {setTitles.Count()}");
			Console.WriteLine($"startupProgs_data = {startupProgs.Count()}");
			foreach(var setTitle in setTitles)
			{
				settitleTextBox.Text = setTitle.TitleName;
			}
			foreach(var startupProg in startupProgs)
			{
				string program_name = startupProg.StartupProgName;
				string program_path = startupProg.StartupProgPath;
				CreateComponentCluster(program_name, program_path);
			}
		}

		private void progRefeButton_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.InitialDirectory = Environment.CurrentDirectory;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				int tag = Convert.ToInt32(button.Tag);
				pathTextBoxes[tag].Text = dialog.FileName;
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
			//パステキストボックスの作成上限数を超えた場合（プログラム追加上限数を超えた場合）
			if (numberofProgram >= PROG_NUM) 
			{
				MessageBox.Show("これ以上プログラムを追加できません。","追加不可", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			CreateComponentCluster();
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

		private void CreateComponentCluster(string program_name="", string program_path="")
		{
			//prognameLabel
			string PNLABEL_NAME = $"prognameLabel{numberofProgram}";
			string PNLABEL_TEXT = $"{numberofProgram + 1}. プログラム名";
			const int PNLABEL_OFFSET = 100;
			int[] PNLABEL_LOCATE = {
				204, //X座標
				PNLABEL_OFFSET * numberofProgram + allProgPanel.AutoScrollPosition.Y //Y座標
			};

			//pathLabel
			string PATHLABEL_NAME = $"pathLabel{numberofProgram}";
			const string PATHLABEL_TEXT = "パス";
			const int PATHLABEL_OFFSET = 100;
			int[] PATHLABEL_LOCATE = {
				423, //X座標
				PATHLABEL_OFFSET * numberofProgram + allProgPanel.AutoScrollPosition.Y //Y座標
			};

			//prognameTextBox
			string PNBOX_NAME = $"prognameTextBox{numberofProgram}";
			const int PNBOX_OFFSET = 100; //テキストボックス間の距離（Y）
			const int PNBOX_FIRST_OFFSET = 28; //Panelと最上部のテキストボックスとの距離（Y）
			int[] PNBOX_LOCATE = {
				204, //X座標
				PNBOX_OFFSET * numberofProgram + PNBOX_FIRST_OFFSET + allProgPanel.AutoScrollPosition.Y //Y座標
			};
			int[] PNBOX_SIZE = {
				150, //テキストボックス幅
				31 //テキストボックス高さ
			};

			//pathTextBox
			string PATHBOX_NAME = $"pathTextBox{numberofProgram}";
			const int PATHBOX_OFFSET = 100;
			const int PATHBOX_FIRST_OFFSET = 28; //Panelと最上部のテキストボックスとの距離（Y）
			int[] PATHBOX_LOCATE = {
				423, //X座標
				PATHBOX_OFFSET * numberofProgram + PATHBOX_FIRST_OFFSET + allProgPanel.AutoScrollPosition.Y //Y座標
			};
			int[] PATHBOX_SIZE = {
				150, //テキストボックス幅
				31 //テキストボックス高さ
			};

			//progRefeButton
			string PRBUTTON_NAME = $"progRefeButton{numberofProgram}";
			const string PRBUTTON_TEXT = "参照";
			int PRBUTTON_TAG = numberofProgram;
			const int PRBUTTON_OFFSET = 100;
			const int PRBUTTON_FIRST_OFFSET = 28;
			int[] PRBUTTON_LOCATE ={
				579,
				PRBUTTON_OFFSET * numberofProgram + PRBUTTON_FIRST_OFFSET + allProgPanel.AutoScrollPosition.Y
			};
			int[] PRBUTTON_SIZE ={
				74,
				31
			};

			CreateTools.createLabel(PNLABEL_NAME, PNLABEL_TEXT, PNLABEL_LOCATE, allProgPanel);
			CreateTools.createLabel(PATHLABEL_NAME, PATHLABEL_TEXT, PATHLABEL_LOCATE, allProgPanel);
			TextBox prognameTextBox = CreateTools.createTextBox(PNBOX_NAME, PNBOX_LOCATE, PNBOX_SIZE, allProgPanel);
			prognameTextBox.Text = program_name;
			prognameTextBoxes[numberofProgram] = prognameTextBox;
			TextBox pathTextBox = CreateTools.createTextBox(PATHBOX_NAME, PATHBOX_LOCATE, PATHBOX_SIZE, allProgPanel);
			pathTextBox.Text = program_path;
			pathTextBoxes[numberofProgram] = pathTextBox;
			Button button = CreateTools.createButton(PRBUTTON_NAME, PRBUTTON_TEXT, PRBUTTON_TAG, PRBUTTON_LOCATE, PRBUTTON_SIZE, allProgPanel);
			button.Click += progRefeButton_Click;

			numberofProgram++;
			return;
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
