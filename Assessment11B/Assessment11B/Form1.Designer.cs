namespace Assessment11B
{
    partial class Form1
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
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchReplaceButton = new System.Windows.Forms.Button();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.replaceBox = new System.Windows.Forms.TextBox();
            this.pasteBin = new System.Windows.Forms.TextBox();
            this.pasteBinLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.numbersCheck = new System.Windows.Forms.CheckBox();
            this.specialCheck = new System.Windows.Forms.CheckBox();
            this.spaceCheck = new System.Windows.Forms.CheckBox();
            this.uppercaseCheck = new System.Windows.Forms.CheckBox();
            this.lowerCheck = new System.Windows.Forms.CheckBox();
            this.passwordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(284, 346);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(387, 346);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(375, 73);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 2;
            // 
            // searchReplaceButton
            // 
            this.searchReplaceButton.Location = new System.Drawing.Point(490, 92);
            this.searchReplaceButton.Name = "searchReplaceButton";
            this.searchReplaceButton.Size = new System.Drawing.Size(99, 23);
            this.searchReplaceButton.TabIndex = 3;
            this.searchReplaceButton.Text = "Search/Replace";
            this.searchReplaceButton.UseVisualStyleBackColor = true;
            this.searchReplaceButton.Click += new System.EventHandler(this.searchReplaceButton_Click);
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(375, 152);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(120, 121);
            this.searchListBox.TabIndex = 4;
            // 
            // replaceBox
            // 
            this.replaceBox.Location = new System.Drawing.Point(375, 118);
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(100, 20);
            this.replaceBox.TabIndex = 5;
            // 
            // pasteBin
            // 
            this.pasteBin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pasteBin.Location = new System.Drawing.Point(7, 73);
            this.pasteBin.Multiline = true;
            this.pasteBin.Name = "pasteBin";
            this.pasteBin.Size = new System.Drawing.Size(347, 200);
            this.pasteBin.TabIndex = 6;
            // 
            // pasteBinLabel
            // 
            this.pasteBinLabel.AutoSize = true;
            this.pasteBinLabel.Location = new System.Drawing.Point(138, 57);
            this.pasteBinLabel.Name = "pasteBinLabel";
            this.pasteBinLabel.Size = new System.Drawing.Size(84, 13);
            this.pasteBinLabel.TabIndex = 7;
            this.pasteBinLabel.Text = "Paste Text Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Replace";
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.numbersCheck);
            this.passwordGroupBox.Controls.Add(this.specialCheck);
            this.passwordGroupBox.Controls.Add(this.spaceCheck);
            this.passwordGroupBox.Controls.Add(this.uppercaseCheck);
            this.passwordGroupBox.Controls.Add(this.lowerCheck);
            this.passwordGroupBox.Controls.Add(this.passwordLabel);
            this.passwordGroupBox.Controls.Add(this.passwordBox);
            this.passwordGroupBox.Location = new System.Drawing.Point(612, 118);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(200, 214);
            this.passwordGroupBox.TabIndex = 10;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Check A Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(84, 173);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 11;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 176);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // numbersCheck
            // 
            this.numbersCheck.AutoSize = true;
            this.numbersCheck.Enabled = false;
            this.numbersCheck.Location = new System.Drawing.Point(84, 39);
            this.numbersCheck.Name = "numbersCheck";
            this.numbersCheck.Size = new System.Drawing.Size(86, 17);
            this.numbersCheck.TabIndex = 11;
            this.numbersCheck.Text = "Numbers 0-9";
            this.numbersCheck.UseVisualStyleBackColor = true;
            // 
            // specialCheck
            // 
            this.specialCheck.AutoSize = true;
            this.specialCheck.Enabled = false;
            this.specialCheck.Location = new System.Drawing.Point(84, 62);
            this.specialCheck.Name = "specialCheck";
            this.specialCheck.Size = new System.Drawing.Size(99, 17);
            this.specialCheck.TabIndex = 12;
            this.specialCheck.Text = "Special !@#$%";
            this.specialCheck.UseVisualStyleBackColor = true;
            // 
            // spaceCheck
            // 
            this.spaceCheck.AutoSize = true;
            this.spaceCheck.Enabled = false;
            this.spaceCheck.Location = new System.Drawing.Point(84, 85);
            this.spaceCheck.Name = "spaceCheck";
            this.spaceCheck.Size = new System.Drawing.Size(83, 17);
            this.spaceCheck.TabIndex = 13;
            this.spaceCheck.Text = "S P A C E S";
            this.spaceCheck.UseVisualStyleBackColor = true;
            // 
            // uppercaseCheck
            // 
            this.uppercaseCheck.AutoSize = true;
            this.uppercaseCheck.Enabled = false;
            this.uppercaseCheck.Location = new System.Drawing.Point(84, 108);
            this.uppercaseCheck.Name = "uppercaseCheck";
            this.uppercaseCheck.Size = new System.Drawing.Size(91, 17);
            this.uppercaseCheck.TabIndex = 14;
            this.uppercaseCheck.Text = "UPPERCASE";
            this.uppercaseCheck.UseVisualStyleBackColor = true;
            // 
            // lowerCheck
            // 
            this.lowerCheck.AutoSize = true;
            this.lowerCheck.Enabled = false;
            this.lowerCheck.Location = new System.Drawing.Point(84, 131);
            this.lowerCheck.Name = "lowerCheck";
            this.lowerCheck.Size = new System.Drawing.Size(74, 17);
            this.lowerCheck.TabIndex = 15;
            this.lowerCheck.Text = "lowercase";
            this.lowerCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 424);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pasteBinLabel);
            this.Controls.Add(this.pasteBin);
            this.Controls.Add(this.replaceBox);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.searchReplaceButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Assessment11B";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchReplaceButton;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.TextBox pasteBin;
        private System.Windows.Forms.Label pasteBinLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.CheckBox numbersCheck;
        private System.Windows.Forms.CheckBox specialCheck;
        private System.Windows.Forms.CheckBox spaceCheck;
        private System.Windows.Forms.CheckBox uppercaseCheck;
        private System.Windows.Forms.CheckBox lowerCheck;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
    }
}

