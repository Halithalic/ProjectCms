using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace WindowsFormsApplication1
{
    public class Settings
    {
        public class Setting
        {
            public User User = new User();
            public List<Site> Sites = new List<Site>();
            public Language Languages = new Language();
            public List<Category> Categories = new List<Category>();
        }

        public class User
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class Site
        {
            public string SiteName { get; set; }
            public string Domain { get; set; }
            public string Meta { get; set; }
            public string FavIcon { get; set; }
        }

        public class Language
        {
            public string LangName { get; set; }
        }

        public class Category
        {
            public string CategoryName { get; set; }
        }

        static public bool SerializeToXml(Setting setting)
        {
            bool result = true;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Setting));
                StreamWriter writer = new StreamWriter(Application.StartupPath + "\\settings.xml");
                serializer.Serialize(writer, setting);
                writer.Close();
                serializer = null;
                writer.Dispose();
                writer = null;
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
            XmlSerializer deserializer = new XmlSerializer(typeof(Setting));
            FileStream fs = new FileStream(Application.StartupPath + "\\settings.xml", FileMode.OpenOrCreate);
            Setting setting = null;
            if (fs.Length > 0)
            {
                setting = (Setting) deserializer.Deserialize(fs);
            }
            deserializer = null;
            fs.Dispose();
            fs = null;
            GC.Collect();
            return setting;
        }

    }
}
