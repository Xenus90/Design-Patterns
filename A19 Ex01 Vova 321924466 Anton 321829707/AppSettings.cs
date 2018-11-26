using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace A19_Ex01_Vova_321924466_Anton_321829707
{
    public class AppSettings
    {
        private AppSettings()
        {
            this.LastWindowLocation = new Point(50, 50);
            this.LastWindowSize = new Size(700, 600);
        }

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
                try
                {
                    using (Stream stream = new FileStream(@"C:\FacebookApp\FacebookAppSettings.xml", FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        loadedSettings = serializer.Deserialize(stream) as AppSettings;
                    }
                }
                catch (Exception loadFromFileException)
                {
                    MessageBox.Show("An error occured during settings loading. Please, restart application and/or delete settings file." +
                        System.Environment.NewLine + loadFromFileException.Message);
                }
            }

            return loadedSettings;
        }

        public void SaveToFile()
        {
            try
            {
                using (Stream stream = new FileStream(@"C:\FacebookApp\FacebookAppSettings.xml", FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            catch (Exception saveToFileException)
            {
                MessageBox.Show("An error occured during saving application settings." + System.Environment.NewLine + saveToFileException.Message);
            }
        }

        private static AppSettings CreateNewSettingsFile()
        {
            AppSettings newSettings = new AppSettings();

            try
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(@"C:\FacebookApp");
                FileStream newFileStream = File.Create(@"C:\FacebookApp\FacebookAppSettings.xml");
                newFileStream.Close();
            }
            catch (Exception newSettingsFileException)
            {
                MessageBox.Show("An error occured during creation of a new settings file." + System.Environment.NewLine + newSettingsFileException.Message);
            }

            return newSettings;
        }           
    }
}