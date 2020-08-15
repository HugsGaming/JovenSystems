namespace JovenSystems
{
    partial class LogIn
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
            this.uNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pWord = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.logInBtn = new MetroFramework.Controls.MetroButton();
            this.exitBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // uNameTxt
            // 
            // 
            // 
            // 
            this.uNameTxt.CustomButton.Image = null;
            this.uNameTxt.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.uNameTxt.CustomButton.Name = "";
            this.uNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uNameTxt.CustomButton.TabIndex = 1;
            this.uNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uNameTxt.CustomButton.UseSelectable = true;
            this.uNameTxt.CustomButton.Visible = false;
            this.uNameTxt.Lines = new string[0];
            this.uNameTxt.Location = new System.Drawing.Point(250, 136);
            this.uNameTxt.MaxLength = 32767;
            this.uNameTxt.Name = "uNameTxt";
            this.uNameTxt.PasswordChar = '\0';
            this.uNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uNameTxt.SelectedText = "";
            this.uNameTxt.SelectionLength = 0;
            this.uNameTxt.SelectionStart = 0;
            this.uNameTxt.ShortcutsEnabled = true;
            this.uNameTxt.Size = new System.Drawing.Size(265, 23);
            this.uNameTxt.Style = MetroFramework.MetroColorStyle.Green;
            this.uNameTxt.TabIndex = 0;
            this.uNameTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uNameTxt.UseSelectable = true;
            this.uNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Chartreuse;
            this.metroLabel1.Location = new System.Drawing.Point(84, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Username: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pWord
            // 
            // 
            // 
            // 
            this.pWord.CustomButton.Image = null;
            this.pWord.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.pWord.CustomButton.Name = "";
            this.pWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pWord.CustomButton.TabIndex = 1;
            this.pWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pWord.CustomButton.UseSelectable = true;
            this.pWord.CustomButton.Visible = false;
            this.pWord.Lines = new string[0];
            this.pWord.Location = new System.Drawing.Point(250, 212);
            this.pWord.MaxLength = 32767;
            this.pWord.Name = "pWord";
            this.pWord.PasswordChar = '\0';
            this.pWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pWord.SelectedText = "";
            this.pWord.SelectionLength = 0;
            this.pWord.SelectionStart = 0;
            this.pWord.ShortcutsEnabled = true;
            this.pWord.Size = new System.Drawing.Size(265, 23);
            this.pWord.Style = MetroFramework.MetroColorStyle.Green;
            this.pWord.TabIndex = 0;
            this.pWord.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pWord.UseSelectable = true;
            this.pWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Chartreuse;
            this.metroLabel2.Location = new System.Drawing.Point(84, 215);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password: ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // logInBtn
            // 
            this.logInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInBtn.Location = new System.Drawing.Point(349, 297);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(166, 23);
            this.logInBtn.TabIndex = 2;
            this.logInBtn.Text = "Login";
            this.logInBtn.UseSelectable = true;
            this.logInBtn.Click += new System.EventHandler(this.LoggingIn);
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Location = new System.Drawing.Point(563, 297);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(166, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseSelectable = true;
            this.exitBtn.Click += new System.EventHandler(this.Exit);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pWord);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.uNameTxt);
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Log In";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox uNameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox pWord;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton logInBtn;
        private MetroFramework.Controls.MetroButton exitBtn;
    }
}