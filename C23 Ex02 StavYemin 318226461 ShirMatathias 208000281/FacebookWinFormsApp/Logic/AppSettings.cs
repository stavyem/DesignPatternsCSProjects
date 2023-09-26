using System.Xml.Serialization;
using System.IO;

namespace BasicFacebookFeatures.Logic
{
    public sealed class AppSettings
    {
        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;

            try
            {
                string appSettingsPath = @".\AppSettings.xml";

                using (Stream stream = new FileStream(appSettingsPath, FileMode.Open))
                {
                    XmlSerializer xmlSerlize = new XmlSerializer(typeof(AppSettings));
                    appSettings = xmlSerlize.Deserialize(stream) as AppSettings;
                }
            }
            catch
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            string appSettingsPath = @".\AppSettings.xml";

            using (Stream stream = new FileStream(appSettingsPath, FileMode.Create))
            {
                XmlSerializer xmlSerelize = new XmlSerializer(this.GetType());
                xmlSerelize.Serialize(stream, this);
            }
        }
    }
}
