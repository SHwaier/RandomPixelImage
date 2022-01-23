using MaterialSkin.Controls;
using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
namespace RandomPixelImage
{
    public partial class PreferencesForm : MaterialForm
    {
        FormManager FormManager1;
        MaterialForm FormMain;
        public PreferencesForm(Preferences FormPreferences, MaterialForm MainForm)
        {
            InitializeComponent();
            FormMain = MainForm;
            FormManager1 = new FormManager(this, FormPreferences);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(0);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(1);
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(2);
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            CreateShortcut();
        }
        private void CreateShortcut()
        {
            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription("");
            link.SetPath(System.Windows.Forms.Application.StartupPath + @"\RandomPixelImage.exe");

            // save it
            IPersistFile file = (IPersistFile)link;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            file.Save(Path.Combine(desktopPath, "Random Pixel Image.lnk"), false);
        }

        private void LightBtn_Click(object sender, EventArgs e)
        {
            FormManager1.ChangeTheme(Preferences.Themes.Light);
        }

        private void DarkBtn_Click(object sender, EventArgs e)
        {
            FormManager1.ChangeTheme(Preferences.Themes.Dark);
        }

        private void BlueBtn_Click(object sender, EventArgs e)
        {
            FormManager1.ChangeColorScheme(Preferences.ColorSchemes.Blue);
            WindowState = FormWindowState.Minimized;
            WindowState = FormWindowState.Normal;
            FormWindowState FWS = FormMain.WindowState;
            FormMain.WindowState = FormWindowState.Minimized;
            FormMain.WindowState = FWS;
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            FormManager1.ChangeColorScheme(Preferences.ColorSchemes.Red);
            WindowState = FormWindowState.Minimized;
            WindowState = FormWindowState.Normal;
            FormWindowState FWS = FormMain.WindowState;
            FormMain.WindowState = FormWindowState.Minimized;
            FormMain.WindowState = FWS;
        }

        private void PinkBtn_Click(object sender, EventArgs e)
        {
            FormManager1.ChangeColorScheme(Preferences.ColorSchemes.Pink);
            WindowState = FormWindowState.Minimized;
            WindowState = FormWindowState.Normal;
            FormWindowState FWS = FormMain.WindowState;
            FormMain.WindowState = FormWindowState.Minimized;
            FormMain.WindowState = FWS;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RestoreDefaultsBtn_Click(object sender, EventArgs e)
        {
            FormManager1.ChangeTheme(Preferences.Themes.Light);
            FormManager1.ChangeColorScheme(Preferences.ColorSchemes.Blue);
            WindowState = FormWindowState.Minimized;
            WindowState = FormWindowState.Normal;
            FormWindowState FWS = FormMain.WindowState;
            FormMain.WindowState = FormWindowState.Minimized;
            FormMain.WindowState = FWS;
        }
    }
}
