namespace JovenSystems
{
    partial class MainApp
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countryBox = new MetroFramework.Controls.MetroComboBox();
            this.startDateBox = new MetroFramework.Controls.MetroComboBox();
            this.endDateBox = new MetroFramework.Controls.MetroComboBox();
            this.processBtn = new MetroFramework.Controls.MetroTile();
            this.saveBtn = new MetroFramework.Controls.MetroTile();
            this.uploadBtn = new MetroFramework.Controls.MetroTile();
            this.resetBtn = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.DarkGreen;
            this.cartesianChart1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cartesianChart1.Location = new System.Drawing.Point(3, 98);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1400, 460);
            this.cartesianChart1.TabIndex = 3;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(33, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Country:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 690);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(33, 776);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryBox
            // 
            this.countryBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.countryBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countryBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.countryBox.FormattingEnabled = true;
            this.countryBox.ItemHeight = 29;
            this.countryBox.Location = new System.Drawing.Point(295, 623);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(606, 35);
            this.countryBox.Style = MetroFramework.MetroColorStyle.Green;
            this.countryBox.TabIndex = 7;
            this.countryBox.UseSelectable = true;
            // 
            // startDateBox
            // 
            this.startDateBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.startDateBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDateBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.startDateBox.FormattingEnabled = true;
            this.startDateBox.ItemHeight = 29;
            this.startDateBox.Location = new System.Drawing.Point(295, 690);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(361, 35);
            this.startDateBox.Style = MetroFramework.MetroColorStyle.Green;
            this.startDateBox.TabIndex = 7;
            this.startDateBox.UseSelectable = true;
            // 
            // endDateBox
            // 
            this.endDateBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.endDateBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endDateBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.endDateBox.FormattingEnabled = true;
            this.endDateBox.ItemHeight = 29;
            this.endDateBox.Location = new System.Drawing.Point(295, 776);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(361, 35);
            this.endDateBox.Style = MetroFramework.MetroColorStyle.Green;
            this.endDateBox.TabIndex = 7;
            this.endDateBox.UseSelectable = true;
            // 
            // processBtn
            // 
            this.processBtn.ActiveControl = null;
            this.processBtn.Location = new System.Drawing.Point(1209, 594);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(300, 100);
            this.processBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.processBtn.TabIndex = 8;
            this.processBtn.Text = "Process";
            this.processBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.processBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.processBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.processBtn.UseSelectable = true;
            this.processBtn.Click += new System.EventHandler(this.ProcessData);
            // 
            // saveBtn
            // 
            this.saveBtn.ActiveControl = null;
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(1594, 594);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(300, 100);
            this.saveBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save Report";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveReport);
            // 
            // uploadBtn
            // 
            this.uploadBtn.ActiveControl = null;
            this.uploadBtn.Enabled = false;
            this.uploadBtn.Location = new System.Drawing.Point(1594, 738);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(300, 100);
            this.uploadBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.uploadBtn.TabIndex = 8;
            this.uploadBtn.Text = "Upload Report to Cloud";
            this.uploadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uploadBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.uploadBtn.UseSelectable = true;
            this.uploadBtn.Click += new System.EventHandler(this.UploadToCloud);
            // 
            // resetBtn
            // 
            this.resetBtn.ActiveControl = null;
            this.resetBtn.Enabled = false;
            this.resetBtn.Location = new System.Drawing.Point(1209, 738);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(300, 100);
            this.resetBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resetBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.resetBtn.UseSelectable = true;
            this.resetBtn.Click += new System.EventHandler(this.Reset);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(1209, 879);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(685, 100);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile6.TabIndex = 8;
            this.metroTile6.Text = "Exit";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.Exit);
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.BackColor = System.Drawing.Color.DarkGreen;
            this.cartesianChart2.Location = new System.Drawing.Point(1409, 98);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(500, 460);
            this.cartesianChart2.TabIndex = 9;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(887, 738);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(300, 100);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Process";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.PrintReport);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1005);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Joven Systems";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.DeepSkyBlue;
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox countryBox;
        private MetroFramework.Controls.MetroComboBox startDateBox;
        private MetroFramework.Controls.MetroComboBox endDateBox;
        private MetroFramework.Controls.MetroTile processBtn;
        private MetroFramework.Controls.MetroTile saveBtn;
        private MetroFramework.Controls.MetroTile uploadBtn;
        private MetroFramework.Controls.MetroTile resetBtn;
        private MetroFramework.Controls.MetroTile metroTile6;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

