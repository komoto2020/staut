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
			this.prognameLabel1 = new System.Windows.Forms.Label();
			this.prognameTextBox1 = new System.Windows.Forms.TextBox();
			this.pathLabel1 = new System.Windows.Forms.Label();
			this.pathTextBox1 = new System.Windows.Forms.TextBox();
			this.decideButton = new System.Windows.Forms.Button();
			this.addProgButton = new System.Windows.Forms.Button();
			this.allProgPanel = new System.Windows.Forms.Panel();
			this.progRefeButton1 = new System.Windows.Forms.Button();
			this.allProgPanel.SuspendLayout();
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
			// prognameLabel1
			// 
			this.prognameLabel1.AutoSize = true;
			this.prognameLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.prognameLabel1.Location = new System.Drawing.Point(204, 0);
			this.prognameLabel1.Name = "prognameLabel1";
			this.prognameLabel1.Size = new System.Drawing.Size(116, 25);
			this.prognameLabel1.TabIndex = 4;
			this.prognameLabel1.Text = "1. プログラム名";
			// 
			// prognameTextBox1
			// 
			this.prognameTextBox1.Location = new System.Drawing.Point(204, 28);
			this.prognameTextBox1.Name = "prognameTextBox1";
			this.prognameTextBox1.Size = new System.Drawing.Size(150, 31);
			this.prognameTextBox1.TabIndex = 5;
			// 
			// pathLabel1
			// 
			this.pathLabel1.AutoSize = true;
			this.pathLabel1.Location = new System.Drawing.Point(423, 0);
			this.pathLabel1.Name = "pathLabel1";
			this.pathLabel1.Size = new System.Drawing.Size(41, 25);
			this.pathLabel1.TabIndex = 6;
			this.pathLabel1.Text = "パス";
			// 
			// pathTextBox1
			// 
			this.pathTextBox1.Location = new System.Drawing.Point(423, 28);
			this.pathTextBox1.Name = "pathTextBox1";
			this.pathTextBox1.Size = new System.Drawing.Size(150, 31);
			this.pathTextBox1.TabIndex = 7;
			this.pathTextBox1.Tag = "1";
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
			// allProgPanel
			// 
			this.allProgPanel.AutoScroll = true;
			this.allProgPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.allProgPanel.Controls.Add(this.progRefeButton1);
			this.allProgPanel.Controls.Add(this.prognameLabel1);
			this.allProgPanel.Controls.Add(this.prognameTextBox1);
			this.allProgPanel.Controls.Add(this.pathLabel1);
			this.allProgPanel.Controls.Add(this.pathTextBox1);
			this.allProgPanel.Location = new System.Drawing.Point(2, 84);
			this.allProgPanel.Name = "allProgPanel";
			this.allProgPanel.Size = new System.Drawing.Size(802, 263);
			this.allProgPanel.TabIndex = 10;
			// 
			// progRefeButton1
			// 
			this.progRefeButton1.Location = new System.Drawing.Point(579, 28);
			this.progRefeButton1.Name = "progRefeButton1";
			this.progRefeButton1.Size = new System.Drawing.Size(74, 31);
			this.progRefeButton1.TabIndex = 11;
			this.progRefeButton1.Tag = "1";
			this.progRefeButton1.Text = "参照";
			this.progRefeButton1.UseVisualStyleBackColor = true;
			this.progRefeButton1.Click += new System.EventHandler(this.progRefeButton_Click);
			// 
			// addEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.allProgPanel);
			this.Controls.Add(this.addProgButton);
			this.Controls.Add(this.decideButton);
			this.Controls.Add(this.settitleTextBox);
			this.Controls.Add(this.settileLabel);
			this.Name = "addEditForm";
			this.Text = "addEditForm";
			this.allProgPanel.ResumeLayout(false);
			this.allProgPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label settileLabel;
		private System.Windows.Forms.TextBox settitleTextBox;
		private System.Windows.Forms.Label prognameLabel1;
		private System.Windows.Forms.TextBox prognameTextBox1;
		private System.Windows.Forms.Label pathLabel1;
		private System.Windows.Forms.TextBox pathTextBox1;
		private System.Windows.Forms.Button decideButton;
		private System.Windows.Forms.Button addProgButton;
		private System.Windows.Forms.Panel allProgPanel;
		private System.Windows.Forms.Button progRefeButton1;
	}
}