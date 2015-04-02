namespace AOJsubmitform {
	partial class ConfigForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		public void InitializeComponent() {
      this.UserNameLabel = new System.Windows.Forms.Label();
      this.PassWordLabel = new System.Windows.Forms.Label();
      this.UserNameBox = new System.Windows.Forms.TextBox();
      this.PassWordBox = new System.Windows.Forms.TextBox();
      this.OKButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.DirectoryNameBox = new System.Windows.Forms.TextBox();
      this.twitterConfigButton = new System.Windows.Forms.Button();
      this.asciiFilterCheckBox = new System.Windows.Forms.CheckBox();
      this.TweetAllCheckBox = new System.Windows.Forms.CheckBox();
      this.saveCheckBox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // UserNameLabel
      // 
      this.UserNameLabel.AutoSize = true;
      this.UserNameLabel.Location = new System.Drawing.Point(13, 13);
      this.UserNameLabel.Name = "UserNameLabel";
      this.UserNameLabel.Size = new System.Drawing.Size(57, 12);
      this.UserNameLabel.TabIndex = 0;
      this.UserNameLabel.Text = "ユーザー名";
      // 
      // PassWordLabel
      // 
      this.PassWordLabel.AutoSize = true;
      this.PassWordLabel.Location = new System.Drawing.Point(13, 37);
      this.PassWordLabel.Name = "PassWordLabel";
      this.PassWordLabel.Size = new System.Drawing.Size(52, 12);
      this.PassWordLabel.TabIndex = 1;
      this.PassWordLabel.Text = "パスワード";
      // 
      // UserNameBox
      // 
      this.UserNameBox.Location = new System.Drawing.Point(76, 10);
      this.UserNameBox.Name = "UserNameBox";
      this.UserNameBox.Size = new System.Drawing.Size(124, 19);
      this.UserNameBox.TabIndex = 2;
      // 
      // PassWordBox
      // 
      this.PassWordBox.Location = new System.Drawing.Point(76, 34);
      this.PassWordBox.Name = "PassWordBox";
      this.PassWordBox.Size = new System.Drawing.Size(124, 19);
      this.PassWordBox.TabIndex = 3;
      this.PassWordBox.UseSystemPasswordChar = true;
      // 
      // OKButton
      // 
      this.OKButton.Location = new System.Drawing.Point(131, 154);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(72, 23);
      this.OKButton.TabIndex = 4;
      this.OKButton.Text = "OK";
      this.OKButton.UseVisualStyleBackColor = true;
      this.OKButton.Click += new System.EventHandler(this.OkButtonClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 12);
      this.label1.TabIndex = 5;
      this.label1.Text = "保存フォルダ";
      // 
      // DirectoryNameBox
      // 
      this.DirectoryNameBox.Location = new System.Drawing.Point(76, 59);
      this.DirectoryNameBox.Name = "DirectoryNameBox";
      this.DirectoryNameBox.Size = new System.Drawing.Size(124, 19);
      this.DirectoryNameBox.TabIndex = 6;
      // 
      // twitterConfigButton
      // 
      this.twitterConfigButton.Location = new System.Drawing.Point(8, 154);
      this.twitterConfigButton.Name = "twitterConfigButton";
      this.twitterConfigButton.Size = new System.Drawing.Size(77, 23);
      this.twitterConfigButton.TabIndex = 7;
      this.twitterConfigButton.Text = "twitter 認証";
      this.twitterConfigButton.UseVisualStyleBackColor = true;
      this.twitterConfigButton.Click += new System.EventHandler(this.twitterConfigButton_Click);
      // 
      // asciiFilterCheckBox
      // 
      this.asciiFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.asciiFilterCheckBox.AutoSize = true;
      this.asciiFilterCheckBox.Location = new System.Drawing.Point(12, 84);
      this.asciiFilterCheckBox.MaximumSize = new System.Drawing.Size(200, 16);
      this.asciiFilterCheckBox.MinimumSize = new System.Drawing.Size(200, 16);
      this.asciiFilterCheckBox.Name = "asciiFilterCheckBox";
      this.asciiFilterCheckBox.Size = new System.Drawing.Size(200, 16);
      this.asciiFilterCheckBox.TabIndex = 8;
      this.asciiFilterCheckBox.Text = "提出時にASCII文字以外を削除する";
      this.asciiFilterCheckBox.UseVisualStyleBackColor = true;
      // 
      // TweetAllCheckBox
      // 
      this.TweetAllCheckBox.AutoSize = true;
      this.TweetAllCheckBox.Location = new System.Drawing.Point(12, 130);
      this.TweetAllCheckBox.Name = "TweetAllCheckBox";
      this.TweetAllCheckBox.Size = new System.Drawing.Size(138, 16);
      this.TweetAllCheckBox.TabIndex = 9;
      this.TweetAllCheckBox.Text = "AC以外でもツイートする";
      this.TweetAllCheckBox.UseVisualStyleBackColor = true;
      // 
      // saveCheckBox
      // 
      this.saveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.saveCheckBox.AutoSize = true;
      this.saveCheckBox.Location = new System.Drawing.Point(12, 107);
      this.saveCheckBox.MaximumSize = new System.Drawing.Size(200, 16);
      this.saveCheckBox.MinimumSize = new System.Drawing.Size(200, 16);
      this.saveCheckBox.Name = "saveCheckBox";
      this.saveCheckBox.Size = new System.Drawing.Size(200, 16);
      this.saveCheckBox.TabIndex = 10;
      this.saveCheckBox.Text = "保存ファイル名に問題名を入れる";
      this.saveCheckBox.UseVisualStyleBackColor = true;
      // 
      // ConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(214, 184);
      this.Controls.Add(this.saveCheckBox);
      this.Controls.Add(this.TweetAllCheckBox);
      this.Controls.Add(this.asciiFilterCheckBox);
      this.Controls.Add(this.twitterConfigButton);
      this.Controls.Add(this.DirectoryNameBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.OKButton);
      this.Controls.Add(this.PassWordBox);
      this.Controls.Add(this.UserNameBox);
      this.Controls.Add(this.PassWordLabel);
      this.Controls.Add(this.UserNameLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.MaximumSize = new System.Drawing.Size(230, 223);
      this.MinimumSize = new System.Drawing.Size(230, 223);
      this.Name = "ConfigForm";
      this.Text = "ConfigForm";
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UserNameLabel;
		private System.Windows.Forms.Label PassWordLabel;
		private System.Windows.Forms.TextBox UserNameBox;
		private System.Windows.Forms.TextBox PassWordBox;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox DirectoryNameBox;
		private System.Windows.Forms.Button twitterConfigButton;
		private System.Windows.Forms.CheckBox asciiFilterCheckBox;
		private System.Windows.Forms.CheckBox TweetAllCheckBox;
    private System.Windows.Forms.CheckBox saveCheckBox;
	}
}