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
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) //InitForm起動時
		{

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
					addeditform.ShowDialog();
					break;

				//一括削除ボタン
				case DELETE:
					break;
			}

		}
	}
}
