using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Linq;
using OpenXML;

namespace HtmlCMS
{
    public partial class FrmMain : Form
    {
        readonly Settings.Setting setting = new Settings.Setting();
        List<Settings.Site> sites = new List<Settings.Site>();

        private Settings.Site selectedSite;

        public FrmMain()
        {
            InitializeComponent();
            setting = Settings.DeserializeFromXML() ?? new Settings.Setting();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadSites();
            if (setting.Sites.Count > 0)
            {
                selectedSite = setting.Sites.FirstOrDefault();
                LoadList();
            }
            timer1.Enabled = true;
            FrmMain_Resize(null, null);
        }

        private void LoadList()
        {
            if (selectedSite == null) return;
            grdList.DataSource = selectedSite.SiteFileInfos.ToList();
            grdList.AutoGenerateColumns = false;
            grdList.AutoResizeColumns();

            btnConvert.Enabled = selectedSite.SiteFileInfos.Count > 0;
            btnUpload.Enabled = selectedSite.SiteFileInfos.Count > 0;



            grdList.Columns.Clear();

            grdList.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "IsSelected",
                HeaderText = "Select",
                Visible = true,
                DataPropertyName = "IsSelected",
                ReadOnly = false
            });

            grdList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "LanguageName",
                HeaderText = "Language",
                Visible = true,
                DataPropertyName = "LanguageName",
                ReadOnly = true
            });

            grdList.Columns.Add(new DataGridViewTextBoxColumn()
                                    {
                                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                                        Name = "CategoryName",
                                        HeaderText = "Category Name",
                                        Visible = true,
                                        DataPropertyName = "CategoryName",
                                        ReadOnly = true
                                    });

            grdList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "FileName",
                HeaderText = "File Name",
                Visible = true,
                DataPropertyName = "FileName",
                ReadOnly = true
            });

            grdList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "ChangeDateTime",
                HeaderText = "Change Date",
                Visible = true,
                DataPropertyName = "ChangeDateTime",
                ReadOnly = true
            });

            grdList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = "Status",
                HeaderText = "Status",
                Visible = true,
                DataPropertyName = "Status",
                ReadOnly = true
            });
        }

        private void PathAnalyzer()
        {
            foreach (var site in setting.Sites)
            {
                foreach (var language in site.Languages)
                {
                    foreach (var category in site.Categories)
                    {
                        var path = Application.StartupPath + "\\sites\\" + site.SiteName + "\\" + language.ShortName + "\\" + category.ShortName;
                        var filePathDocxs = Directory.GetFiles(path, "*.docx", SearchOption.AllDirectories);

                        if (filePathDocxs.Count() <= site.SiteFileInfos.Count)
                        {
                            var removedFiles = site.SiteFileInfos.Where(item => !File.Exists(item.FilePath)).ToList();

                            foreach (var removedFile in removedFiles)
                            {
                                site.SiteFileInfos.Remove(removedFile);
                            }
                        }

                        foreach (var item in filePathDocxs)
                        {
                            if (!item.Contains("\\s\\img\\"))
                            {
                                var fileInfo = new FileInfo(item);

                                //Console.WriteLine(fileInfo.LastWriteTime);
                                var fileName = Path.GetFileName(item);
                                if (fileName != null && fileName[0].ToString(CultureInfo.InvariantCulture) == "~") continue;

                                if (!site.SiteFileInfos.Any(w => item.Contains(w.FilePath)))
                                {
                                    site.SiteFileInfos.Add(new Settings.SiteFileInfo
                                    {
                                        FilePath = item,
                                        FileName = Path.GetFileName(item),
                                        ChangeDateTime = fileInfo.LastWriteTime,
                                        Changed = true,
                                        CategoryName = category.Name,
                                        LanguageName = language.Name,
                                        Status = Settings.Status.NeedsGeneration
                                    });
                                }
                                else
                                {
                                    var siteFileInfo = site.SiteFileInfos.FirstOrDefault(w => item.Contains(w.FilePath));
                                    if (siteFileInfo != null && fileInfo.LastWriteTime != siteFileInfo.ChangeDateTime)
                                    {
                                        siteFileInfo.ChangeDateTime = fileInfo.LastWriteTime;
                                        siteFileInfo.Changed = true;
                                    }
                                }
                                //Console.WriteLine("Docx - " + Path.GetFileName(item) + " -- " + item);
                            }
                        }
                        FileSystemWatcher(path);
                    }
                }
            }
            LoadList();
            Settings.SerializeToXml(setting);
        }

        #region FileSystemWatcher
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void FileSystemWatcher(string path)
        {
            var watcher = new FileSystemWatcher
                              {
                                  Path = path,
                                  NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                                                 NotifyFilters.FileName | NotifyFilters.DirectoryName,
                                  Filter = "*.*"
                              };
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            // Only watch text files.

            //// Add event handlers.
            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnRenamed;
            watcher.SynchronizingObject = this;
            //// Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            var strFileExt = Path.GetExtension(e.FullPath);
            if (strFileExt != ".docx" && strFileExt != ".doc") return;

            //Console.WriteLine("File: " + e.Name + " " + e.ChangeType);

            if (e.Name[0].ToString(CultureInfo.InvariantCulture) != "~")
            {
                var str = e.FullPath.Split('\\').Reverse().ToArray();

                var site = setting.Sites.FirstOrDefault(w => w.SiteName == str[3]);
                if (site != null)
                {
                    string categoryName = str[1];
                    string languageName = str[2];

                    var fileInfo = new FileInfo(e.FullPath);
                    if (!site.SiteFileInfos.Any(w => e.Name.Contains(w.FileName) && w.CategoryName == categoryName && w.LanguageName == languageName))
                    {
                        site.SiteFileInfos.Add(new Settings.SiteFileInfo
                                                   {
                                                       FileName = e.Name,
                                                       FilePath = e.FullPath,
                                                       ChangeDateTime = fileInfo.LastWriteTime,
                                                       Changed = true,
                                                       CategoryName = categoryName,
                                                       Status = Settings.Status.NeedsGeneration,
                                                       LanguageName = languageName
                                                   });
                    }
                    else
                    {
                        var siteFileInfos = site.SiteFileInfos.FirstOrDefault(w => e.FullPath.Contains(w.FilePath) && w.CategoryName == categoryName && w.LanguageName == languageName);
                        if (siteFileInfos != null && fileInfo.LastWriteTime != siteFileInfos.ChangeDateTime)
                        {
                            siteFileInfos.ChangeDateTime = fileInfo.LastWriteTime;
                            siteFileInfos.Changed = true;
                        }
                    }

                    if (e.ChangeType == WatcherChangeTypes.Deleted)
                    {
                        var file = site.SiteFileInfos.FirstOrDefault(w => e.Name.Contains(w.FileName) && w.CategoryName == categoryName && w.LanguageName == languageName);
                        if (file != null)
                            site.SiteFileInfos.Remove(file);
                    }
                    Settings.SerializeToXml(setting);
                    LoadList();
                }
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            string strFileExt = Path.GetExtension(e.FullPath);

            if (strFileExt == ".docx" || strFileExt == ".doc")
            {
                var str = e.FullPath.Split('\\').Reverse().ToArray();

                var site = setting.Sites.FirstOrDefault(w => w.SiteName == str[3]);
                if (site != null)
                {
                    string categoryName = str[1];
                    string languageName = str[2];

                    var fileInfo = new FileInfo(e.FullPath);
                    if (!site.SiteFileInfos.Any(w => e.Name.Contains(w.FileName) && w.CategoryName == categoryName && w.LanguageName == languageName))
                    {
                        site.SiteFileInfos.Add(new Settings.SiteFileInfo
                                                   {
                                                       FileName = e.Name,
                                                       FilePath = e.FullPath,
                                                       ChangeDateTime = fileInfo.LastWriteTime,
                                                       Changed = true,
                                                       CategoryName = categoryName,
                                                       Status = Settings.Status.NeedsGeneration,
                                                       LanguageName = languageName
                                                   });
                    }
                    else
                    {
                        var siteFileInfos = site.SiteFileInfos.FirstOrDefault(w => e.FullPath.Contains(w.FilePath) && w.CategoryName == categoryName && w.LanguageName == languageName);
                        if (siteFileInfos != null && fileInfo.LastWriteTime != siteFileInfos.ChangeDateTime)
                        {
                            siteFileInfos.ChangeDateTime = fileInfo.LastWriteTime;
                            siteFileInfos.Changed = true;
                        }
                    }
                    LoadList();
                    Settings.SerializeToXml(setting);
                }
                //Console.WriteLine("File: {0} renamed to {1}", e.OldName, e.Name);
            }
        }
        #endregion

        private void LoadSites()
        {
            sites = setting.Sites;
            lstSite.Items.Clear();
            foreach (var item in sites)
            {
                lstSite.Items.Add(item.SiteName);
            }
            PathAnalyzer();
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            var newSiteWizard = new FrmNewSite(setting, string.Empty);
            newSiteWizard.ShowDialog();
            newSiteWizard.Dispose();
            LoadSites();
        }

        private void lstSite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstSite.SelectedItem != null)
            {
                var newSiteWizard = new FrmNewSite(setting, lstSite.SelectedItem.ToString());
                newSiteWizard.ShowDialog();
                newSiteWizard.Dispose();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            foreach (var siteFileInfo in selectedSite.SiteFileInfos.Where(w => w.IsSelected && w.Status == Settings.Status.ReadyToUpload))
            {
                siteFileInfo.IsSelected = false;
                siteFileInfo.Status = Settings.Status.Uploaded;
                siteFileInfo.Changed = false;
            }
            Settings.SerializeToXml(setting);
            LoadList();
        }

        private void lstSite_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstSite.SelectedItem != null)
                selectedSite = setting.Sites.FirstOrDefault(w => w.SiteName == (string)lstSite.SelectedItem);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            foreach (var fileInfo in selectedSite.SiteFileInfos.Where(w => w.Changed && w.IsSelected))
            {
                setting.ImageCounter = Utility.ConvertToHtml(Application.StartupPath, fileInfo.FilePath, setting.ImageCounter, setting.MaxWidthSetting);
                var siteFileInfo = selectedSite.SiteFileInfos.FirstOrDefault(w => fileInfo.FilePath.Contains(w.FilePath));
                if (siteFileInfo != null)
                {
                    siteFileInfo.Changed = false;
                    siteFileInfo.Status = Settings.Status.ReadyToUpload;
                }
            }

            Settings.SerializeToXml(setting);

            LoadList();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frmSettings = new FrmSettings(setting);
            frmSettings.ShowDialog();
            frmSettings.Dispose();
        }

        private void grdList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                foreach (var selectedRow in grdList.SelectedRows)
                {
                    var dataRowViewItem = (selectedRow as DataGridViewRow);
                    if (dataRowViewItem != null)
                    {
                        var item = (dataRowViewItem.DataBoundItem as Settings.SiteFileInfo);
                        if (item != null)
                            item.IsSelected = true;
                    }
                }
                grdList.Refresh();
            }
        }

        private void lstSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSite.SelectedItem != null)
            {
                selectedSite = setting.Sites.FirstOrDefault(w => w.SiteName == lstSite.SelectedItem.ToString());
                LoadList();
            }
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.Width > 1000 && this.Height > 800)
            {
                btnAddSite.ImageList = btnIconList128;
                btnAddSite.ImageKey = "1361282448_monotone_plus_add.png";

                btnConvert.ImageList = btnIconList128;
                btnConvert.ImageKey = "1361282351_monotone_arrow_play_right_next.png";

                btnUpload.ImageList = btnIconList128;
                btnUpload.ImageKey = "1361282488_upload_arrow_up.png";

                btnSettings.ImageList = btnIconList128;
                btnSettings.ImageKey = "1361282347_monotone_cog_settings_gear.png";
            }
            else
            {
                btnAddSite.ImageList = btnIconList32;
                btnAddSite.ImageKey = "1361282448_32_monotone_plus_add.png";

                btnConvert.ImageList = btnIconList32;
                btnConvert.ImageKey = "1361282351_32_monotone_arrow_play_right_next.png";

                btnUpload.ImageList = btnIconList32;
                btnUpload.ImageKey = "1361282488_32_upload_arrow_up.png";

                btnSettings.ImageList = btnIconList32;
                btnSettings.ImageKey = "1361282347_32_monotone_cog_settings_gear.png";
            }
        }
    }
}
