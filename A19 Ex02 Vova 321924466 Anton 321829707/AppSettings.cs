using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace A19_Ex02_Vova_321924466_Anton_321829707
{
    public sealed class AppSettings
    {
        private static readonly object sr_SettingsInstanceLock = new object();
        private static AppSettings s_Instance;    

        private AppSettings()
        {
            this.LastWindowLocation = new Point(50, 50);
            this.LastWindowSize = new Size(700, 600);
        }

        public static AppSettings GetInstance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_SettingsInstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppSettings();
                        }
                    }
                }
                return s_Instance;
            }
        }

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }       

        public void LoadFromFile()
        {
            AppSettings loadedSettings;

            if (!File.Exists(@"C:\FacebookApp\FacebookAppSettings.xml"))
            {
                CreateNewSettingsFile();
            }
            else
            {
                try
                {
                    using (Stream stream = new FileStream(@"C:\FacebookApp\FacebookAppSettings.xml", FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        loadedSettings = serializer.Deserialize(stream) as AppSettings;
                        this.LastWindowLocation = loadedSettings.LastWindowLocation;
                        this.LastWindowSize = loadedSettings.LastWindowSize;
                    }
                }
                catch (Exception loadFromFileException)
                {
                    MessageBox.Show("An error occured during settings loading. Please, restart application and/or delete settings file." +
                        System.Environment.NewLine + loadFromFileException.Message);
                }
            }
        }

        public void SaveToFile(Form io_AppUI)
        {
            try
            {
                using (Stream stream = new FileStream(@"C:\FacebookApp\FacebookAppSettings.xml", FileMode.Truncate))
                {
                    this.LastWindowLocation = io_AppUI.Location;
                    this.LastWindowSize = io_AppUI.Size;
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            catch (Exception saveToFileException)
            {
                MessageBox.Show("An error occured during saving application settings." + System.Environment.NewLine + saveToFileException.Message);
            }
        }

        private void CreateNewSettingsFile()
        {
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
        }           
    }
}