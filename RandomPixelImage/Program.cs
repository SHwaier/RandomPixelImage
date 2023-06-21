using System;
using System.IO;
using System.Windows.Forms;

namespace RandomPixelImage
{
    static class Program
    {
        /// <summary>
        /// The directory in which the application data is saved in
        /// </summary>
        static readonly string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Application.CompanyName;
        static readonly string PreferencesFile = ApplicationData + "\\Preferences.xml";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Setup();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(Preferences.Load(PreferencesFile)));
            //Application.Run(new DrawingForm());
            //Application.Run(new PreferencesForm(Preferences.Load(PreferencesFile)));
        }
        public static void Setup()
        {
            //Check if the application data folder is created on the target machine or not, and create it if it's not created
            if (!File.Exists(ApplicationData))
                Directory.CreateDirectory(ApplicationData);
            //Check if the preferences file exists or not, if it doesn't then copy the default one to the application data folder
            if (!File.Exists(PreferencesFile))
                File.Copy(Application.StartupPath + "\\Preferences.xml", PreferencesFile);
        }
    }
}
