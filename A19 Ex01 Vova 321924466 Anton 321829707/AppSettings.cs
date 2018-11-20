using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace A19_Ex01_Vova_321924466_Anton_321829707
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public static AppSettings LoadFromFile()
        {
            AppSettings loadedSettings = null;

            if (!File.Exists(@"C:\FacebookApp\FacebookAppSettings.xml"))
            {
                loadedSettings = CreateNewSettingsFile();
            }
            else
            {
                using (Stream stream = new FileStream(@"C:\FacebookApp\FacebookAppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    loadedSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            
            return loadedSettings;
        }

        private static AppSettings CreateNewSettingsFile()
        {
            AppSettings newSettings = new AppSettings();

            DirectoryInfo dirInfo = Directory.CreateDirectory(@"C:\FacebookApp");

            FileStream newFileStream = File.Create(@"C:\FacebookApp\FacebookAppSettings.xml");
            newFileStream.Close();

            return newSettings;
        }

        private AppSettings()
        {
            LastWindowLocation = new Point(50, 50);
            LastWindowSize = new Size(900, 600);
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"C:\FacebookApp\FacebookAppSettings.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }       
    }
}