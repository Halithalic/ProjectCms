using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace HtmlCMS
{
    public static class Settings
    {
        public class Setting
        {
            public readonly List<Site> Sites = new List<Site>();

            public int ImageCounter { get; set; }
        }

        public class Site
        {
            public string SiteName { get; set; }
            public string Domain { get; set; }

            public List<Language> Languages { get; set; }
            public List<Category> Categories = new List<Category>();
            public readonly List<SiteFileInfo> SiteFileInfos = new List<SiteFileInfo>();
        }

        public class Language
        {
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class Category
        {
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class SiteFileInfo
        {
            [XmlIgnore]
            public bool IsSelected { get; set; }
            public string CategoryName { get; set; }
            public string LanguageName { get; set; }
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public DateTime ChangeDateTime { get; set; }
            public bool Changed { get; set; }
            public Status Status {get;set;}
        }

        public enum Status
        {
            Uploaded,
            ReadyToUpload,
            NeedsGeneration
        }

        public static void CreatePath(string path, string folder)
        {
            string createPath = Path.Combine(Application.StartupPath + path, folder);
            Directory.CreateDirectory(createPath);
        }

        static public bool SerializeToXml(Setting setting)
        {
            bool result = true;
            try
            {
                var serializer = new XmlSerializer(typeof(Setting));
                var writer = new StreamWriter(Application.StartupPath + "\\settings.xml");
                serializer.Serialize(writer, setting);
                writer.Close();
                writer.Dispose();
                GC.Collect();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        static public Setting DeserializeFromXML()
        {
            var deserializer = new XmlSerializer(typeof(Setting));
            var fs = new FileStream(Application.StartupPath + "\\settings.xml", FileMode.OpenOrCreate);
            Setting setting = null;
            if (fs.Length > 0)
            {
                setting = (Setting)deserializer.Deserialize(fs);
            }
            fs.Dispose();
            GC.Collect();
            return setting;
        }

    }
}
