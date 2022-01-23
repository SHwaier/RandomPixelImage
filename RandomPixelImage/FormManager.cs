using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace RandomPixelImage
{
    /// <summary>
    /// This is mainly to manage the look of the whole application including
    /// </summary>
    class FormManager
    {
        /// <summary>
        /// The library used to manage the main look of the application
        /// </summary>
        private readonly MaterialSkinManager Msm = MaterialSkinManager.Instance;

        /// <summary>
        /// A blue color scheme for Material Skin Manager to change the application look
        /// </summary>
        private readonly ColorScheme BlueScheme = new ColorScheme(Primary.Blue800, Primary.Blue900,
                Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        /// <summary>
        /// A red color scheme for Material Skin Manager to change the application look
        /// </summary>
        private readonly ColorScheme RedScheme = new ColorScheme(Primary.Red800, Primary.Red900,
                Primary.Red500, Accent.Red200, TextShade.WHITE);

        /// <summary>
        /// A pink color scheme for Material Skin Manager to change the application look
        /// </summary>
        private readonly ColorScheme PinkScheme = new ColorScheme(Primary.Pink800, Primary.Pink900,
                Primary.Pink500, Accent.Red200, TextShade.WHITE);

        Preferences FormPreferences = new Preferences();
        private static readonly string ApplicationData = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}";
        private static readonly string PreferencesFile = $"{ApplicationData}\\Preferences.xml";
        MaterialForm form;
        public FormManager(MaterialForm FormToManage, Preferences Preferences1)
        {
            FormPreferences = Preferences1;
            Msm.AddFormToManage(FormToManage);
            form = FormToManage;
            Msm.Theme = FormPreferences.Theme == Preferences.Themes.Dark ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            ChangeColorScheme(FormPreferences.ColorScheme);
        }

        public void ChangeTheme(Preferences.Themes Themes)
        {
            switch (Themes)
            {
                case Preferences.Themes.Dark:
                    FormPreferences.Theme = Preferences.Themes.Dark;
                    Msm.Theme = MaterialSkinManager.Themes.DARK;
                    SavePrefernces();
                    break;
                case Preferences.Themes.Light:
                    FormPreferences.Theme = Preferences.Themes.Light;
                    Msm.Theme = MaterialSkinManager.Themes.LIGHT;
                    SavePrefernces();
                    break;
            }
        }
        public void ChangeColorScheme(Preferences.ColorSchemes ColorScheme)
        {
            switch (ColorScheme)
            {
                case Preferences.ColorSchemes.Blue:
                    FormPreferences.ColorScheme = Preferences.ColorSchemes.Blue;
                    Msm.ColorScheme = BlueScheme;
                    SavePrefernces();
                    break;
                case Preferences.ColorSchemes.Pink:
                    FormPreferences.ColorScheme = Preferences.ColorSchemes.Pink;
                    Msm.ColorScheme = PinkScheme;
                    SavePrefernces();
                    break;
                case Preferences.ColorSchemes.Red:
                    FormPreferences.ColorScheme = Preferences.ColorSchemes.Red;
                    Msm.ColorScheme = RedScheme;
                    SavePrefernces();
                    break;
            }
        }
        public void SavePrefernces()
        {
            FormPreferences.Save(PreferencesFile);
        }
    }
}
