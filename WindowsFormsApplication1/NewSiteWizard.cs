using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NewSiteWizard : Form
    {
        private string siteName;
        private Settings.Setting setting;

        public NewSiteWizard(Settings.Setting _setting, string _siteName)
        {
            InitializeComponent();
            siteName = _siteName;
            setting = _setting;
            LoadData();
        }

        private void LoadData()
        {
            var site = setting.Sites.FirstOrDefault(w => w.SiteName == siteName);
            if (site != null)
            {
                txtSiteName.Text = site.SiteName;
                txtDomain.Text = site.Domain;
                txtMeta.Text = site.Meta;
                txtFavicon.Text = site.FavIcon;
            }

            txtLanguage.Text = setting.Languages.LangName;

            LoadCategories();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (string.IsNullOrEmpty(txtDomain.Text) ||
                    string.IsNullOrEmpty(txtFavicon.Text) ||
                    string.IsNullOrEmpty(txtMeta.Text) ||
                    string.IsNullOrEmpty(txtSiteName.Text))
                {
                    MessageBox.Show("Lütfen alanları doldurunuz");
                    return;
                }

                if (string.IsNullOrEmpty(siteName))
                {
                    setting.Sites.Add(new Settings.Site
                        {
                            Domain = txtDomain.Text,
                            FavIcon = txtFavicon.Text,
                            Meta = txtMeta.Text,
                            SiteName = txtSiteName.Text
                        });

                    if (Settings.SerializeToXml(setting))
                    {
                        string newPath = System.IO.Path.Combine(Application.StartupPath, txtSiteName.Text);
                        System.IO.Directory.CreateDirectory(newPath);

                        newPath = System.IO.Path.Combine(Application.StartupPath + "\\" + txtSiteName.Text, "s");
                        System.IO.Directory.CreateDirectory(newPath);

                        newPath = System.IO.Path.Combine(Application.StartupPath + "\\s" + txtSiteName.Text, "img");
                        System.IO.Directory.CreateDirectory(newPath);

                        tabControl1.SelectTab(tabPage2);
                    }
                }
                else
                {
                    var site = setting.Sites.Where(w => w.SiteName == siteName).FirstOrDefault();
                    site.Domain = txtDomain.Text;
                    site.FavIcon = txtFavicon.Text;
                    site.Meta = txtMeta.Text;
                    Settings.SerializeToXml(setting);
                    tabControl1.SelectTab(tabPage2);
                }
            }


            if (tabControl1.SelectedTab == tabPage2)
            {
                if (string.IsNullOrEmpty(txtLanguage.Text.Trim()))
                {
                    MessageBox.Show("Lütfen alanı doldurunuz");
                    return;
                }

                setting.Languages.LangName = txtLanguage.Text;


                if (Settings.SerializeToXml(setting))
                {
                    foreach (var item in txtLanguage.Text.Split(';'))
                    {
                        string newPath = System.IO.Path.Combine(Application.StartupPath + "\\" + txtSiteName.Text, item);
                        System.IO.Directory.CreateDirectory(newPath);
                    }
                }
                tabControl1.SelectTab(tabPage3);
            }

            if (tabControl1.SelectedTab == tabPage3)
            {
                if (Settings.SerializeToXml(setting))
                {
                    foreach (var category in setting.Categories)
                    {
                        foreach (var item in txtLanguage.Text.Split(';'))
                        {
                            string newPath = System.IO.Path.Combine(Application.StartupPath + "\\" + txtSiteName.Text + "\\" + item, category.CategoryName);
                            System.IO.Directory.CreateDirectory(newPath);
                        }
                    }
                    tabControl1.SelectTab(tabPage4);
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategory.Text.Trim()))
            {
                MessageBox.Show("Lütfen alanı doldurunuz");
                return;
            }

            setting.Categories.Add(new Settings.Category
                {
                    CategoryName = txtCategory.Text
                });

            LoadCategories();
            txtCategory.Clear();
        }

        private void LoadCategories()
        {
            lstCategory.Items.Clear();
            foreach (var item in setting.Categories)
            {
                lstCategory.Items.Add(item.CategoryName);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var category = setting.Categories.FirstOrDefault(w => w.CategoryName == lstCategory.SelectedItem.ToString());
            if (category != null)
                setting.Categories.Remove(category);
        }
    }
}
