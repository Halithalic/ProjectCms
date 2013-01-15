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
    public partial class FrmSites : Form
    {
        Settings.Setting setting = new Settings.Setting();
        List<Settings.Site> sites = new List<Settings.Site>();

        public FrmSites()
        {
            InitializeComponent();
            setting = Settings.DeserializeFromXML();

            if (setting == null) setting = new Settings.Setting();

            //FrmLogin login = new FrmLogin(setting);
            //login.ShowDialog();
        }

        private void FrmSites_Load(object sender, EventArgs e)
        {
            LoadSites();
        }

        private void FrmSites_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateNewSite_Click(object sender, EventArgs e)
        {
            NewSiteWizard newSite = new NewSiteWizard(setting,string.Empty);
            newSite.ShowDialog();
            newSite.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                sites = sites.Where(w => txtSearch.Text.Contains(w.SiteName)).ToList();
            else
                LoadSites();
            LoadSites();
        }

        private void LoadSites()
        {
            SiteList.Items.Clear();
            sites = setting.Sites;

            foreach (var item in sites)
            {
                SiteList.Items.Add(item.SiteName);
            }
        }

        private void btnEditSite_Click(object sender, EventArgs e)
        {
            if (SiteList.SelectedItem != null)
            {
                NewSiteWizard frm = new NewSiteWizard(setting, SiteList.SelectedItem.ToString());
                frm.ShowDialog();
                frm.Dispose();
            }
        }
    }
}
