namespace PayrollSystem
{
    partial class MainTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTab));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.AccountDashboardTab = new System.Windows.Forms.TabPage();
            this.InformationTab = new System.Windows.Forms.TabPage();
            this.InfoNameLabel = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tabControlMain.SuspendLayout();
            this.InformationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.AccountDashboardTab);
            this.tabControlMain.Controls.Add(this.InformationTab);
            this.tabControlMain.Location = new System.Drawing.Point(0, 1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(483, 461);
            this.tabControlMain.TabIndex = 0;
            // 
            // AccountDashboardTab
            // 
            this.AccountDashboardTab.Location = new System.Drawing.Point(4, 22);
            this.AccountDashboardTab.Name = "AccountDashboardTab";
            this.AccountDashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountDashboardTab.Size = new System.Drawing.Size(475, 435);
            this.AccountDashboardTab.TabIndex = 0;
            this.AccountDashboardTab.Text = "Dashboard";
            this.AccountDashboardTab.UseVisualStyleBackColor = true;
            // 
            // InformationTab
            // 
            this.InformationTab.Controls.Add(this.InfoNameLabel);
            this.InformationTab.Location = new System.Drawing.Point(4, 22);
            this.InformationTab.Name = "InformationTab";
            this.InformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.InformationTab.Size = new System.Drawing.Size(475, 435);
            this.InformationTab.TabIndex = 1;
            this.InformationTab.Text = "Info";
            this.InformationTab.UseVisualStyleBackColor = true;
            // 
            // InfoNameLabel
            // 
            this.InfoNameLabel.AutoSize = true;
            this.InfoNameLabel.Location = new System.Drawing.Point(10, 30);
            this.InfoNameLabel.Name = "InfoNameLabel";
            this.InfoNameLabel.Size = new System.Drawing.Size(41, 13);
            this.InfoNameLabel.TabIndex = 0;
            this.InfoNameLabel.Text = "Name: ";
            // 
            // MainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainTab";
            this.Text = "PayrollSys";
            this.tabControlMain.ResumeLayout(false);
            this.InformationTab.ResumeLayout(false);
            this.InformationTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage AccountDashboardTab;
        private System.Windows.Forms.TabPage InformationTab;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label InfoNameLabel;
    }
}