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
        
        public FrmSites()
        {
            InitializeComponent();
            setting = Settings.DeserializeFromXML();

            if (setting == null) setting = new Settings.Setting();

            //FrmLogin login = new FrmLogin(setting);
            //login.ShowDialog();

            lblChangeDocCount.Text = "Değişen Dosya Sayısı : 0";
            
            timer1.Enabled = true;
            FileSystemWatcher();
            PathAnalyzer();
        }

        #region PathAnalyzer
        private void PathAnalyzer()
        {
            foreach (var site in setting.Sites)
            {
                string[] filePathDocxs = Directory.GetFiles(Application.StartupPath + "\\" + site.SiteName, "*.docx", SearchOption.AllDirectories);

                if (filePathDocxs.Count() <= setting.FileInfos.Count)
                {
                    List<Settings.FileInfo> removedFiles = new List<Settings.FileInfo>();

                    foreach (var item in setting.FileInfos)
                    {
                        if (!File.Exists(item.FilePath))
                        {
                            removedFiles.Add(item);
                        }
                    }

                    foreach (var removedFile in removedFiles)
                    {
                        setting.FileInfos.Remove(removedFile);
                    }
                }

                foreach (var item in filePathDocxs)
                {
                    if (!item.Contains("\\s\\img\\"))
                    {
                        FileInfo fileInfo = new FileInfo(item);

                        //Console.WriteLine(fileInfo.LastWriteTime);
                        if (Path.GetFileName(item)[0].ToString() == "~") continue;
                        
                        if (!setting.FileInfos.Any(w => item.Contains(w.FilePath)))
                        {
                            setting.FileInfos.Add(new Settings.FileInfo
                                {
                                    FilePath = item,
                                    FileName = Path.GetFileName(item),
                                    ChangeDateTime = fileInfo.LastWriteTime,
                                    Changed = true
                                });
                        }
                        else
                        {
                            if (fileInfo.LastWriteTime !=
                                setting.FileInfos.FirstOrDefault(w => item.Contains(w.FilePath)).ChangeDateTime)
                            {
                                setting.FileInfos.FirstOrDefault(w => item.Contains(w.FilePath)).ChangeDateTime =
                                    fileInfo.LastWriteTime;
                                setting.FileInfos.FirstOrDefault(w => item.Contains(w.FilePath)).Changed = true;
                            }
                        }
                        //Console.WriteLine("Docx - " + Path.GetFileName(item) + " -- " + item);
                    }
                }
            }

            Settings.SerializeToXml(setting);
        }
        #endregion

        #region FileSystemWatcher
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void FileSystemWatcher()
        {
            string[] array1 = Directory.GetDirectories(Application.StartupPath);

            foreach (var siteItem in array1)
            {
                //Console.WriteLine(siteItem);
                if (setting.Sites.Any(w => siteItem.Contains(w.SiteName)))
                {
                    var site = siteItem.Remove(0, Application.StartupPath.Length + 1);

                    string[] array2 = Directory.GetDirectories(Application.StartupPath + "\\" + site);

                    foreach (var langItem in array2)
                    {
                        var lang = langItem.Remove(0, (siteItem).Length + 1);
                        //Console.WriteLine(langItem);
                        if (setting.Languages.Any(w=> lang.Contains(w.LangName)))
                        {
                            string[] array3 = Directory.GetDirectories(Application.StartupPath + "\\" + site + "\\" + lang);

                            foreach (var catItem in array3)
                            {
                                var cat = catItem.Remove(0, (langItem).Length + 1);
                                //Console.WriteLine(catItem);
                                if (setting.Categories.Any(w => cat.Contains(w.CategoryName)))
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
                    FileInfo fileInfo = new FileInfo(e.FullPath);
                    if (!setting.FileInfos.Any(w => e.Name.Contains(w.FileName)))
                    {
                        setting.FileInfos.Add(new Settings.FileInfo
                            {
                                FileName = e.Name,
                                FilePath = e.FullPath,
                                ChangeDateTime = fileInfo.LastWriteTime,
                                Changed = true
                            });
                    }
                    else
                    {
                        if (fileInfo.LastWriteTime !=
                            setting.FileInfos.FirstOrDefault(w => e.FullPath.Contains(w.FilePath)).ChangeDateTime)
                        {
                            setting.FileInfos.FirstOrDefault(w => e.Name.Contains(w.FileName)).ChangeDateTime =
                                fileInfo.LastWriteTime;
                            setting.FileInfos.FirstOrDefault(w => e.Name.Contains(w.FileName)).Changed = true;
                        }
                    }

                    if (e.ChangeType == WatcherChangeTypes.Deleted)
                    {
                        Settings.FileInfo file = setting.FileInfos.FirstOrDefault(w => e.Name.Contains(w.FileName));
                        if (file != null)
                            setting.FileInfos.Remove(file);
                    }
                }
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            string strFileExt = Path.GetExtension(e.FullPath);

            if (strFileExt == ".docx" || strFileExt == ".doc")
            {
                FileInfo fileInfo = new FileInfo(e.FullPath);
                if (!setting.FileInfos.Any(w => e.Name.Contains(w.FileName)))
                {
                    setting.FileInfos.Add(new Settings.FileInfo
                    {
                        FileName = e.Name,
                        FilePath = e.FullPath,
                        ChangeDateTime = fileInfo.LastWriteTime,
                        Changed = true
                    });
                }
                else
                {
                    if (fileInfo.LastWriteTime !=
                        setting.FileInfos.FirstOrDefault(w => e.FullPath.Contains(w.FilePath)).ChangeDateTime)
                    {
                        setting.FileInfos.FirstOrDefault(w => e.FullPath.Contains(w.FilePath)).ChangeDateTime =
                            fileInfo.LastWriteTime;
                        setting.FileInfos.FirstOrDefault(w => e.FullPath.Contains(w.FilePath)).Changed = true;
                    }
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
            Settings.SerializeToXml(setting);
            Application.Exit();
        }

        private void btnCreateNewSite_Click(object sender, EventArgs e)
        {
            NewSiteWizard newSite = new NewSiteWizard(setting, string.Empty);
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

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblChangeDocCount.Text = "Değişen Dosya Sayısı : " + setting.FileInfos.Where(w=> w.Changed).Count().ToString();
            if (i == 5)
            {
                Settings.SerializeToXml(setting);
                i = 0;
            }
            i++;
        }

        private void btnViewChangeFiles_Click(object sender, EventArgs e)
        {
            FrmConvertHtml convertHtml = new FrmConvertHtml(setting);
            convertHtml.ShowDialog();
            LoadSites();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\unknown\Documents\Visual Studio 2012\Projects\ProjectCms\ProjectCms\WindowsFormsApplication1\bin\Debug\aaa\en\aaa\New Microsoft Word Document.docx";

            string[] siteName = filePath.Split('\\');

            string result = string.Empty;
            for (int j = 0; j < siteName.Count() - 1; j++)
            {
                result += siteName[j] + "\\";
            }
            Console.WriteLine(result);
        }
    }
}
