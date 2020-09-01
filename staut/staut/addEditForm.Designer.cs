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
			this.decideButton = new System.Windows.Forms.Button();
			this.addProgButton = new System.Windows.Forms.Button();
			this.allProgPanel = new System.Windows.Forms.Panel();
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
			// decideButton
			// 
			this.decideButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.decideButton.Location = new System.Drawing.Point(676, 404);
			this.decideButton.Name = "decideButton";
			this.decideButton.Size = new System.Drawing.Size(112, 34);
			this.decideButton.TabIndex = 8;
			this.decideButton.Text = "決定";
			this.decideButton.UseVisualStyleBackColor = true;
			this.decideButton.Click += new System.EventHandler(this.decideButton_Click);
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
			this.allProgPanel.Location = new System.Drawing.Point(2, 84);
			this.allProgPanel.Name = "allProgPanel";
			this.allProgPanel.Size = new System.Drawing.Size(802, 263);
			this.allProgPanel.TabIndex = 10;
			// 
			// addEditForm
			// 
			this.AcceptButton = this.decideButton;
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label settileLabel;
		private System.Windows.Forms.TextBox settitleTextBox;
		private System.Windows.Forms.Button decideButton;
		private System.Windows.Forms.Button addProgButton;
		private System.Windows.Forms.Panel allProgPanel;
	}
}