namespace staut
{
	partial class addEditForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.settileLabel = new System.Windows.Forms.Label();
			this.settitleTextBox = new System.Windows.Forms.TextBox();
			this.wdirLabel = new System.Windows.Forms.Label();
			this.wdirTextBox = new System.Windows.Forms.TextBox();
			this.prognameLabel01 = new System.Windows.Forms.Label();
			this.prognameTextBox01 = new System.Windows.Forms.TextBox();
			this.pathLabel01 = new System.Windows.Forms.Label();
			this.pathTextBox01 = new System.Windows.Forms.TextBox();
			this.decideButton = new System.Windows.Forms.Button();
			this.addProgButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// settileLabel
			// 
			this.settileLabel.AutoSize = true;
			this.settileLabel.Location = new System.Drawing.Point(203, 37);
			this.settileLabel.Name = "settileLabel";
			this.settileLabel.Size = new System.Drawing.Size(105, 25);
			this.settileLabel.TabIndex = 0;
			this.settileLabel.Text = "セットタイトル";
			// 
			// settitleTextBox
			// 
			this.settitleTextBox.Location = new System.Drawing.Point(422, 34);
			this.settitleTextBox.Name = "settitleTextBox";
			this.settitleTextBox.Size = new System.Drawing.Size(150, 31);
			this.settitleTextBox.TabIndex = 1;
			// 
			// wdirLabel
			// 
			this.wdirLabel.AutoSize = true;
			this.wdirLabel.Location = new System.Drawing.Point(203, 104);
			this.wdirLabel.Name = "wdirLabel";
			this.wdirLabel.Size = new System.Drawing.Size(125, 25);
			this.wdirLabel.TabIndex = 2;
			this.wdirLabel.Text = "作業ディレクトリ";
			// 
			// wdirTextBox
			// 
			this.wdirTextBox.Location = new System.Drawing.Point(422, 101);
			this.wdirTextBox.Name = "wdirTextBox";
			this.wdirTextBox.Size = new System.Drawing.Size(150, 31);
			this.wdirTextBox.TabIndex = 3;
			// 
			// prognameLabel01
			// 
			this.prognameLabel01.AutoSize = true;
			this.prognameLabel01.Location = new System.Drawing.Point(204, 0);
			this.prognameLabel01.Name = "prognameLabel01";
			this.prognameLabel01.Size = new System.Drawing.Size(97, 25);
			this.prognameLabel01.TabIndex = 4;
			this.prognameLabel01.Text = "プログラム名";
			// 
			// prognameTextBox01
			// 
			this.prognameTextBox01.Location = new System.Drawing.Point(204, 28);
			this.prognameTextBox01.Name = "prognameTextBox01";
			this.prognameTextBox01.Size = new System.Drawing.Size(150, 31);
			this.prognameTextBox01.TabIndex = 5;
			// 
			// pathLabel01
			// 
			this.pathLabel01.AutoSize = true;
			this.pathLabel01.Location = new System.Drawing.Point(423, 0);
			this.pathLabel01.Name = "pathLabel01";
			this.pathLabel01.Size = new System.Drawing.Size(41, 25);
			this.pathLabel01.TabIndex = 6;
			this.pathLabel01.Text = "パス";
			// 
			// pathTextBox01
			// 
			this.pathTextBox01.Location = new System.Drawing.Point(423, 28);
			this.pathTextBox01.Name = "pathTextBox01";
			this.pathTextBox01.Size = new System.Drawing.Size(150, 31);
			this.pathTextBox01.TabIndex = 7;
			// 
			// decideButton
			// 
			this.decideButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.decideButton.Location = new System.Drawing.Point(676, 404);
			this.decideButton.Name = "decideButton";
			this.decideButton.Size = new System.Drawing.Size(112, 34);
			this.decideButton.TabIndex = 8;
			this.decideButton.Text = "決定";
			this.decideButton.UseVisualStyleBackColor = true;
			// 
			// addProgButton
			// 
			this.addProgButton.Location = new System.Drawing.Point(323, 353);
			this.addProgButton.Name = "addProgButton";
			this.addProgButton.Size = new System.Drawing.Size(171, 34);
			this.addProgButton.TabIndex = 9;
			this.addProgButton.Text = "プログラムを追加";
			this.addProgButton.UseVisualStyleBackColor = true;
			this.addProgButton.Click += new System.EventHandler(this.addProgButton_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.prognameLabel01);
			this.panel1.Controls.Add(this.prognameTextBox01);
			this.panel1.Controls.Add(this.pathLabel01);
			this.panel1.Controls.Add(this.pathTextBox01);
			this.panel1.Location = new System.Drawing.Point(-1, 183);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(802, 145);
			this.panel1.TabIndex = 10;
			// 
			// addEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.addProgButton);
			this.Controls.Add(this.decideButton);
			this.Controls.Add(this.wdirTextBox);
			this.Controls.Add(this.wdirLabel);
			this.Controls.Add(this.settitleTextBox);
			this.Controls.Add(this.settileLabel);
			this.Name = "addEditForm";
			this.Text = "addEditForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label settileLabel;
		private System.Windows.Forms.TextBox settitleTextBox;
		private System.Windows.Forms.Label wdirLabel;
		private System.Windows.Forms.TextBox wdirTextBox;
		private System.Windows.Forms.Label prognameLabel01;
		private System.Windows.Forms.TextBox prognameTextBox01;
		private System.Windows.Forms.Label pathLabel01;
		private System.Windows.Forms.TextBox pathTextBox01;
		private System.Windows.Forms.Button decideButton;
		private System.Windows.Forms.Button addProgButton;
		private System.Windows.Forms.Panel panel1;
	}
}