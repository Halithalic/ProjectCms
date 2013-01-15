namespace WindowsFormsApplication1
{
    partial class FrmSites
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
            this.btnCreateNewSite = new System.Windows.Forms.Button();
            this.SiteList = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditSite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewSite
            // 
            this.btnCreateNewSite.Location = new System.Drawing.Point(18, 248);
            this.btnCreateNewSite.Name = "btnCreateNewSite";
            this.btnCreateNewSite.Size = new System.Drawing.Size(176, 30);
            this.btnCreateNewSite.TabIndex = 0;
            this.btnCreateNewSite.Text = "Yeni Site Yarat";
            this.btnCreateNewSite.UseVisualStyleBackColor = true;
            this.btnCreateNewSite.Click += new System.EventHandler(this.btnCreateNewSite_Click);
            // 
            // SiteList
            // 
            this.SiteList.FormattingEnabled = true;
            this.SiteList.Location = new System.Drawing.Point(18, 17);
            this.SiteList.Name = "SiteList";
            this.SiteList.Size = new System.Drawing.Size(176, 225);
            this.SiteList.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(348, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Site Ara";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(418, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEditSite
            // 
            this.btnEditSite.Location = new System.Drawing.Point(18, 284);
            this.btnEditSite.Name = "btnEditSite";
            this.btnEditSite.Size = new System.Drawing.Size(176, 30);
            this.btnEditSite.TabIndex = 5;
            this.btnEditSite.Text = "Düzenle";
            this.btnEditSite.UseVisualStyleBackColor = true;
            this.btnEditSite.Click += new System.EventHandler(this.btnEditSite_Click);
            // 
            // FrmSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 338);
            this.Controls.Add(this.btnEditSite);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.SiteList);
            this.Controls.Add(this.btnCreateNewSite);
            this.Name = "FrmSites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siteler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSites_FormClosed);
            this.Load += new System.EventHandler(this.FrmSites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewSite;
        private System.Windows.Forms.ListBox SiteList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditSite;
    }
}