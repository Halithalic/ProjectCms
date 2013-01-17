namespace WindowsFormsApplication1
{
    partial class NewSiteWizard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtFavicon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDeleteLang = new System.Windows.Forms.Button();
            this.lstLangs = new System.Windows.Forms.ListBox();
            this.btnLangAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtFavicon);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtMeta);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDomain);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSiteName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(630, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bilgi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtFavicon
            // 
            this.txtFavicon.Location = new System.Drawing.Point(87, 134);
            this.txtFavicon.Name = "txtFavicon";
            this.txtFavicon.Size = new System.Drawing.Size(141, 20);
            this.txtFavicon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Favicon";
            // 
            // txtMeta
            // 
            this.txtMeta.Location = new System.Drawing.Point(87, 85);
            this.txtMeta.Multiline = true;
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.Size = new System.Drawing.Size(141, 43);
            this.txtMeta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meta";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(87, 61);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(141, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domain";
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(87, 36);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(141, 20);
            this.txtSiteName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site Adı";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLangAdd);
            this.tabPage2.Controls.Add(this.btnDeleteLang);
            this.tabPage2.Controls.Add(this.lstLangs);
            this.tabPage2.Controls.Add(this.txtLanguage);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(630, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diller";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(77, 29);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(141, 20);
            this.txtLanguage.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Diller";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteCategory);
            this.tabPage3.Controls.Add(this.btnAddCategory);
            this.tabPage3.Controls.Add(this.lstCategory);
            this.tabPage3.Controls.Add(this.txtCategory);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(630, 292);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kategoriler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(139, 219);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 8;
            this.btnDeleteCategory.Text = "Sil";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(220, 19);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Ekle";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(73, 66);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(141, 147);
            this.lstCategory.TabIndex = 6;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(73, 19);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(141, 20);
            this.txtCategory.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kategori";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(552, 347);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Sonraki";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnDeleteLang
            // 
            this.btnDeleteLang.Location = new System.Drawing.Point(143, 208);
            this.btnDeleteLang.Name = "btnDeleteLang";
            this.btnDeleteLang.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLang.TabIndex = 10;
            this.btnDeleteLang.Text = "Sil";
            this.btnDeleteLang.UseVisualStyleBackColor = true;
            this.btnDeleteLang.Click += new System.EventHandler(this.btnDeleteLang_Click);
            // 
            // lstLangs
            // 
            this.lstLangs.FormattingEnabled = true;
            this.lstLangs.Location = new System.Drawing.Point(77, 55);
            this.lstLangs.Name = "lstLangs";
            this.lstLangs.Size = new System.Drawing.Size(141, 147);
            this.lstLangs.TabIndex = 9;
            // 
            // btnLangAdd
            // 
            this.btnLangAdd.Location = new System.Drawing.Point(224, 27);
            this.btnLangAdd.Name = "btnLangAdd";
            this.btnLangAdd.Size = new System.Drawing.Size(75, 23);
            this.btnLangAdd.TabIndex = 11;
            this.btnLangAdd.Text = "Ekle";
            this.btnLangAdd.UseVisualStyleBackColor = true;
            this.btnLangAdd.Click += new System.EventHandler(this.btnLangAdd_Click);
            // 
            // NewSiteWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 401);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewSiteWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Site Hazırlama";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtFavicon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLangAdd;
        private System.Windows.Forms.Button btnDeleteLang;
        private System.Windows.Forms.ListBox lstLangs;
    }
}