using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlCMS
{
    public partial class FrmNewSite : Form
    {

        private readonly string siteName;
        private readonly Settings.Setting setting;
        public FrmNewSite()
        {
            InitializeComponent();
        }

        public FrmNewSite(Settings.Setting _setting, string _siteName)
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
                txtLanguages.Clear();
                txtCategories.Clear();
                txtSiteName.Text = site.SiteName;
                txtDomain.Text = site.Domain;
                foreach (var cat in site.Categories)
                {
                    txtCategories.Text += cat.Name + " - " + cat.ShortName + Environment.NewLine;
                }

                foreach (var cat in site.Languages)
                {
                    txtLanguages.Text += cat.Name + " - " + cat.ShortName + Environment.NewLine;
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDomain.Text) || string.IsNullOrEmpty(txtSiteName.Text) || string.IsNullOrEmpty(txtLanguages.Text) || string.IsNullOrEmpty(txtCategories.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
                return;
            }

            List<Settings.Language> languages = new List<Settings.Language>();
            foreach (var language in txtLanguages.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList())
            {
                if (language.Split('-').Count() == 2)
                {
                    languages.Add(new Settings.Language
                                      {
                                          Name = language.Split('-')[0].Trim(),
                                          ShortName = language.Split('-')[1].Trim()
                                      }
                        );
                }
            }

            List<Settings.Category> categories = new List<Settings.Category>();
            foreach (var category in txtCategories.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList())
            {
                if (category.Split('-').Count() == 2)
                {
                    categories.Add(new Settings.Category
                                       {
                                           Name = category.Split('-')[0].Trim(),
                                           ShortName = category.Split('-')[1].Trim()
                                       }
                        );
                }
            }

            var siteExist = setting.Sites.FirstOrDefault(w => w.SiteName == txtSiteName.Text.Trim());
            if (siteExist != null)
                setting.Sites.Remove(siteExist);

            setting.Sites.Add(new Settings.Site
                                  {
                                      SiteName = txtSiteName.Text.Trim(),
                                      Domain = txtDomain.Text.Trim(),
                                      Categories = categories,
                                      Languages = languages
                                  });

            if (Settings.SerializeToXml(setting))
            {
                Settings.CreatePath("", "sites");
                Settings.CreatePath("\\sites\\", txtSiteName.Text);

                Settings.CreatePath("\\sites\\" + txtSiteName.Text, "s");
                Settings.CreatePath("\\sites\\" + txtSiteName.Text + "\\s\\", "img");
                Settings.CreatePath("\\sites\\" + txtSiteName.Text + "\\s\\", "js");
                Settings.CreatePath("\\sites\\" + txtSiteName.Text + "\\s\\", "css");

                foreach (var language in languages)
                {
                    Settings.CreatePath("\\sites\\" + txtSiteName.Text + "\\", language.ShortName);
                    foreach (var category in categories)
                    {
                        Settings.CreatePath("\\sites\\" + txtSiteName.Text + "\\" + language.ShortName + "\\", category.ShortName);
                    }
                }

                MessageBox.Show("Succesfull");
            }
            else
            {
                MessageBox.Show("Unsuccesfull");
            }
        }
    }
}
