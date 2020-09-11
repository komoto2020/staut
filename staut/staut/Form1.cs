//一括削除
using staut_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staut
{
	public partial class InitForm : Form
	{

		public InitForm()
		{
			Console.WriteLine("Form1: InitForm");
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) //InitForm起動時、1回のみ呼び出される
		{
			Console.WriteLine("Form1: Loaded");
			using (var db = new SetTitleDbContext())
			{
				var queryAllSetTiles = from setTitle in db.SetTitles
									   select setTitle;
				int numberofData = 0; //クエリで取得したデータの個数
				foreach (var data in queryAllSetTiles)
				{
					string TITLELABEL_NAME = "";
					string TITLELABEL_TEXT = "";
					const int TITLELABEL_OFFSET = 0;
					int[] TITLELABEL_LOCATE = new int[2] {0, 0};
					int TITLELABEL_TAG = data.SetTitleId;

					string STARTUPBUTTON_NAME = $"startupButton{numberofData}";
					const string STARTUPBUTTON_TEXT = "起動";
					const int STARTUPBUTTON_OFFSET = 0;
					int[] STARTUPBUTTON_LOCATE = new int[2] {0, 0};
					int[] STARTUPBUTTON_SIZE = new int[2] { 112, 34 };
					int STARTUPBUTTON_TAG = data.SetTitleId;

					numberofData++;

					if (numberofData % 2 == 1) //奇数番目の場合、フォームの左側に表示
					{
						//titleLabel
						TITLELABEL_NAME = $"titleLabel{numberofData}";
						TITLELABEL_TEXT = data.TitleName;
						TITLELABEL_LOCATE = new int[2] { 88, 67 * (numberofData / 2 + 1) };

						//startupButton
						STARTUPBUTTON_NAME = $"startupButton{numberofData}";
						STARTUPBUTTON_LOCATE = new int[2] {215, 67 * (numberofData / 2 + 1) };
					}
					else //偶数番目の場合、フォームの右側に表示
					{
						//titleLabel
						TITLELABEL_NAME = $"titleLabel{numberofData}";
						TITLELABEL_TEXT = data.TitleName;
						TITLELABEL_LOCATE = new int[2] { 422, 67 * (numberofData / 2) };

						//startupButton
						STARTUPBUTTON_NAME = $"startupButton{numberofData}";
						STARTUPBUTTON_LOCATE = new int[2] { 549, 67 * (numberofData / 2) };
					}
				 	LinkLabel titleLabel = CreateTools.createLinkLabel(TITLELABEL_NAME, TITLELABEL_TEXT, TITLELABEL_LOCATE, panel1);
					titleLabel.Tag = TITLELABEL_TAG;
					titleLabel.Font = new Font("Yu Gothic UI", 9);
					titleLabel.LinkClicked += titleLabel_LinkClick;

					Button startupButton = CreateTools.createButton(STARTUPBUTTON_NAME, STARTUPBUTTON_TEXT, STARTUPBUTTON_TAG, STARTUPBUTTON_LOCATE, STARTUPBUTTON_SIZE, panel1);
				}				
			}
			return;
		}

		private void titleLabel_LinkClick(object sender, EventArgs e)
		{
			using (var db = new SetTitleDbContext())
			{
				Console.WriteLine("Clicked titleLabel");
				LinkLabel linkLabel = sender as LinkLabel;
				int setTitleId = (int)linkLabel.Tag;
				Console.WriteLine($"setTitleId = {setTitleId}");

				var setTitle_data = from setTitle in db.SetTitles
						   where setTitle.SetTitleId == setTitleId
						   orderby setTitle.SetTitleId
						   select setTitle;
				var startupProg_data = from startupProg in db.StartupProgs
									   where startupProg.SetTitleId == setTitleId
									   orderby startupProg.StartupProgId
									   select startupProg;
				addEditForm addEditForm = new addEditForm(setTitle_data, startupProg_data);
				DialogResult dialogResult = addEditForm.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					InitForm newform = new InitForm();
					newform.Show();
					//Form1_Load(null, EventArgs.Empty);
				}

			}

		}

		//メニューバーの項目がクリックされた場合
		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			const string ADD = "add";
			const string DELETE = "delete";

			var item = e.ClickedItem as ToolStripButton;
			switch (item.Tag)
			{
				//追加ボタン
				case ADD:
					Console.WriteLine("Clicked addButton in InitForm.");
					addEditForm addeditform = new addEditForm();
					if (addeditform.ShowDialog() == DialogResult.OK)
					{
						InitForm newform = new InitForm();
						newform.Show();
					}
					break;

				//一括削除ボタン
				case DELETE:
					break;
			}
		}
	}
}
