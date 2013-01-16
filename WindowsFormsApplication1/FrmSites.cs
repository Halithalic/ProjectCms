using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class FrmSites : Form
    {
        Settings.Setting setting = new Settings.Setting();
        List<Settings.Site> sites = new List<Settings.Site>();

        private int ChangeFileCount = 0;
        private int CreateFileCount = 0;
        private List<string> fileNames = new List<string>();
        public FrmSites()
        {
            InitializeComponent();
            setting = Settings.DeserializeFromXML();

            if (setting == null) setting = new Settings.Setting();

            //FrmLogin login = new FrmLogin(setting);
            //login.ShowDialog();

            lblChangeDocCount.Text = "Değişen Dosya Sayısı : 0";
            lblCreateDocCount.Text = "Eklenen Dosya Sayısı : 0";
            timer1.Enabled = true;
            Run();
        }

        #region FileSystemWatcher
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void Run()
        {
            string[] array1 = Directory.GetDirectories(Application.StartupPath);

            foreach (var siteItem in array1)
            {
                //Console.WriteLine(siteItem);
                if (setting.Sites.Any(w => siteItem.Contains(w.SiteName)))
                {
                    var site = siteItem.Remove(0,Application.StartupPath.Length + 1);

                    string[] array2 = Directory.GetDirectories(Application.StartupPath + "\\" + site);

                    foreach (var langItem in array2)
                    {
                        var lang = langItem.Remove(0, (siteItem).Length + 1);
                        //Console.WriteLine(langItem);
                        if (setting.Languages.LangName.Contains(lang))
                        {
                            string[] array3 = Directory.GetDirectories(Application.StartupPath + "\\" + site + "\\" + lang);

                            foreach (var catItem in array3)
                            {
                                var cat = catItem.Remove(0, (langItem).Length + 1);
                                //Console.WriteLine(catItem);
                                if (setting.Categories.Any(w=> cat.Contains(w.CategoryName)))
                                {
                                    FileSystemWatcher watcher = new FileSystemWatcher();
                                    watcher.Path = catItem;
                                    /* Watch for changes in LastAccess and LastWrite times, and
                                       the renaming of files or directories. */
                                    watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                                                           NotifyFilters.FileName | NotifyFilters.DirectoryName;
                                    // Only watch text files.
                                    watcher.Filter = "*.*";

                                    //// Add event handlers.
                                    watcher.Changed += new FileSystemEventHandler(OnChanged);
                                    watcher.Created += new FileSystemEventHandler(OnChanged);
                                    watcher.Deleted += new FileSystemEventHandler(OnChanged);
                                    watcher.Renamed += new RenamedEventHandler(OnRenamed);

                                    //// Begin watching.
                                    watcher.EnableRaisingEvents = true;
                                }
                            }
                        }
                    }
                }
            }

            ////FileSystemWatcher watcher = new FileSystemWatcher();
            //watcher.Path = Application.StartupPath + "\\aaa\\en\\aaa\\";
            ///* Watch for changes in LastAccess and LastWrite times, and
            //   the renaming of files or directories. */
            //watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            //// Only watch text files.
            //watcher.Filter = "*.*";

            ////// Add event handlers.
            //watcher.Changed += new FileSystemEventHandler(OnChanged);
            //watcher.Created += new FileSystemEventHandler(OnChanged);
            //watcher.Deleted += new FileSystemEventHandler(OnChanged);
            //watcher.Renamed += new RenamedEventHandler(OnRenamed);

            ////// Begin watching.
            //watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            string strFileExt = Path.GetExtension(e.FullPath);
            if (strFileExt == ".docx" || strFileExt == ".doc")
            {
                Console.WriteLine("File: " + e.Name + " " + e.ChangeType);
                
                if (e.Name[0].ToString() != "~")
                {
                    if (!fileNames.Contains(e.Name))
                    {
                        fileNames.Add(e.Name);
                        if (e.ChangeType == WatcherChangeTypes.Changed)
                            ChangeFileCount++;
                    }
                    
                    if (e.ChangeType == WatcherChangeTypes.Created)
                        CreateFileCount++;
                }
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            string strFileExt = Path.GetExtension(e.FullPath);

            if (strFileExt == ".docx" || strFileExt == ".doc")
            {
                if (!fileNames.Contains(e.Name))
                {
                    fileNames.Add(e.Name);
                    ChangeFileCount++;
                }
                Console.WriteLine("File: {0} renamed to {1}", e.OldName, e.Name);
            }
        }
        #endregion

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

        private void FrmSites_Activated(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblChangeDocCount.Text = "Değişen Dosya Sayısı : " + ChangeFileCount.ToString();
            lblCreateDocCount.Text = "Eklenen Dosya Sayısı : " + CreateFileCount.ToString();
        }
    }
}
