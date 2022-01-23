using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RandomPixelImage
{
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Tells if there is an image generated.
        /// </summary>
        public bool IsGenerated;
        /// <summary>
        /// Specifies That the generated image should be a pizel image
        /// </summary>
        private bool IsPixel;
        /// <summary>
        /// Specifies That the generated image should be a gradient image
        /// </summary>
        private bool IsGradient;
        /// <summary>
        /// Specifies That the generated image is a custom image with custom height and width
        /// </summary>
        private bool IsCustom;

        private bool IsSizeChanging = false;

        /// <summary>
        /// Rand is used to generate random numbers
        /// </summary>
        private readonly Random Rand = new Random();

        /// <summary>
        /// The bitmap generated after the random pixel image generating process
        /// </summary>
        private Bitmap Bmp;

        /// <summary>
        /// A Windows Form to show the saving progress of the image
        /// </summary>
        SavingMessage SavingMsg = new SavingMessage();

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);

        //The following code is for applying a drop shadow on all sides of the forn
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        Preferences FormPreferences = new Preferences();
        private static readonly string ApplicationData = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}";
        private static readonly string PreferencesFile = $"{ApplicationData}\\Preferences.xml";
        FormManager FormManager1;

        public MainForm(Preferences FormPreferences1)
        {
            InitializeComponent();
            SetClassLong(Handle, GCL_STYLE, GetClassLong(Handle, GCL_STYLE) | CS_DropSHADOW);
            FormPreferences = FormPreferences1;
            FormManager1 = new FormManager(this, FormPreferences);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            int FormHeight = Height - 62;
            save.Size = new Size(Width, FormHeight);
            EditPanel.Size = new Size(Width, FormHeight);
            BasicPanel.Visible = false;
            AdvancedPanel.Visible = false;
            SizePanel.Visible = false;
            BasicPanelMenu.PerformClick();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int FormHeight = Height - 62;
            save.Size = new Size(Width, FormHeight);
            EditPanel.Size = new Size(Width, FormHeight);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            save.Size = new Size(Width, Height - 62);
            EditPanel.Size = new Size(Width, Height - 62);
        }

        /// <summary>
        /// This is used to resize the an image with almost no loss of image quality
        /// </summary>
        /// <param name="img">The image to to resize</param>
        /// <param name="size">The new size of the image</param>
        /// <returns>This returns the same given image, but with the new size</returns>
        private Image ResizeImage(Image img, Size size)
        {
            try
            {
                Image NewImage = new Bitmap(img, size.Width, size.Height);
                ChangeSavingProgress(20, true);
                using (Graphics GFX = Graphics.FromImage((Bitmap)NewImage))
                {
                    ChangeSavingProgress(20, true);
                    GFX.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    GFX.SmoothingMode = SmoothingMode.HighQuality;
                    GFX.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    GFX.CompositingQuality = CompositingQuality.HighQuality;
                    ChangeSavingProgress(20, true);
                    GFX.DrawImage(img, new Rectangle(Point.Empty, size));
                    ChangeSavingProgress(20, true);
                    GFX.Dispose();
                    return NewImage;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void ChangeSavingProgress(int IncreaseBy, bool IsSave)
        {
            if (IsSave)
                SavingMsg.Progress(SavingMsg.Value + IncreaseBy);
        }

        private void UpdateSaveRuntime(int _Width, int _Height)
        {
            if (IsSizeChanging)
                RuntimePicSave.BackgroundImage.Dispose();
            Image img = PreviewBox.BackgroundImage;
            Size size = new Size(_Width, _Height);
            img = ResizeImage(img, size);
            RuntimePicSave.BackgroundImage = img;
        }

        private void Generate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GenerateBtn.PerformClick();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = RuntimePicSave.BackgroundImage;
                SaveFileDialog sv = new SaveFileDialog
                {
                    Filter = "JPEG JPG files| *.jpg|PNG files| *.png",
                    Title = "Saving...",
                    AddExtension = true
                };
                //A message box to show that the image is being saved
                SavingMsg = new SavingMessage();
                SavingMsg.Show();
                SavingMsg.Value = 0;
                //The size used to resize the final image 
                Size size = new Size(TWidth.Value, THeight.Value);
                img = ResizeImage(RuntimePicSave.BackgroundImage, size);
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    SaveImage(img, sv.FileName);
                }
                img.Dispose();
                sv.Dispose();
                SavingMsg.Close();
                SavingMsg.Dispose();
                save.Visible = false;
                save.SendToBack();
                RuntimePicSave.Dispose();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveImage(Image img, string SVFileName)
        {
            if (TQuality.Value != 100)
            {
                Image bm = img;
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                ChangeSavingProgress(8, true);
                ImageCodecInfo ici = null;
                EncoderParameters ep = new EncoderParameters();
                ep.Param[0] = new EncoderParameter(Encoder.Quality, (long)TQuality.Value);
                ChangeSavingProgress(8, true);
                foreach (ImageCodecInfo codec in codecs)
                {
                    ChangeSavingProgress(8, true);
                    if (codec.MimeType == "image/jpeg")
                    {
                        ici = codec;
                    }
                }
                bm.Save(SVFileName, ici, ep);
                ep.Dispose();
                ChangeSavingProgress(8, true);
                bm.Dispose();
            }
            else
            {
                img.Save(SVFileName);//5
                ChangeSavingProgress(8, true);
            }
        }

        private void TWidth_ValueChanged(object sender, EventArgs e)
        {
            TxtSaveWidth.Text = TWidth.Value + "px";
            UpdateSaveRuntime(TWidth.Value, THeight.Value);
        }

        private void THeight_Scroll(object sender, EventArgs e)
        {
            TxtSaveHeight.Text = THeight.Value + "px";
            UpdateSaveRuntime(TWidth.Value, THeight.Value);
        }

        private void TQuality_ValueChanged(object sender, EventArgs e)
        {
            TxtQuality.Text = TQuality.Value.ToString();
        }

        private void SizePanelMenu_Click(object sender, EventArgs e)
        {
            AdvancedPanel.Visible = false;
            BasicPanel.Visible = false;
            SizePanel.Visible = SizePanel.Visible == true ? SizePanel.Visible = false : SizePanel.Visible = true;
        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            ChooseCustomBackgroundType();
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            ChooseCustomBackgroundType();
        }

        /// <summary>
        /// Changes the background type to Custom background type.
        /// </summary>
        private void ChooseCustomBackgroundType()
        {
            BackgroundType.SelectedIndex = BackgroundType.FindString("Custom");
            IsCustom = true;
            IsPixel = false;
            IsGradient = false;
            BackgroundType.Refresh();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            RuntimePicSave.BackgroundImage.Dispose();
            EditPanel.BringToFront();
            Dispose();
            InitializeComponent();
        }

        public void GeneratePixel()
        {
            Generate(Rand.Next(2, 200), Rand.Next(2, 200));
        }

        public void GenerateGradient()
        {
            Generate(Rand.Next(2, 5), Rand.Next(2, 5));
        }

        public void GenerateCustom()
        {
            Generate(Convert.ToInt32(TxtHeight.Text), Convert.ToInt32(TxtWidth.Text));
        }

        private void Generate(int ImageHeight, int ImageWidth)
        {
            try
            {
                /// The values used to generate the random pixel in the generating process
                
                IsGenerated = true;
                Bmp = new Bitmap(ImageWidth, ImageHeight);
                //Here we randomly generate a pixel for each column in the rows of the image
                for (int x = 0; x < ImageWidth; x++)
                {
                    for (int y = 0; y < ImageHeight; y++)
                    {
                        Bmp.SetPixel(x, y, Color.FromArgb(
                             TxtA.Text == "" ? Rand.Next(256) : Convert.ToInt32(TxtA.Text),
                             TxtR.Text == "" ? Rand.Next(256) : Convert.ToInt32(TxtR.Text),
                             TxtG.Text == "" ? Rand.Next(256) : Convert.ToInt32(TxtG.Text),
                             TxtB.Text == "" ? Rand.Next(256) : Convert.ToInt32(TxtB.Text)));

                    }
                }
                //ImageInfoLbl.Text = $"Image Width: {Bmp.Width} Height: {Bmp.Height}";

                Bmp = (Bitmap)ResizeImage(Bmp, new Size(720, 720));
                        Graphics g = Graphics.FromImage(Bmp);
                        SolidBrush nsb = new SolidBrush(Color.Red);
                        g.DrawEllipse(new Pen(nsb,50),0, 0, Rand.Next(ImageWidth -1), Rand.Next(ImageHeight - 1));
                g.DrawEllipse(new Pen(nsb, 50), 0, 0, 720 , 720);

                PreviewBox.BackgroundImage = Bmp;
                ImageInfoLbl.Text = $"Image Width: {PreviewBox.BackgroundImage.Width} Height: {PreviewBox.BackgroundImage.Height}";


                Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            if (IsGenerated)
                PreviewBox.BackgroundImage.Dispose();
            if (IsCustom && TxtHeight.Text != "" && TxtWidth.Text != "")
            {
                GenerateCustom();
                return;
            }
            else if (IsCustom)
            {
                MessageBox.Show("Please enter some custome inputs first", "Notice");
                return;
            }
            if (IsPixel)
            {
                GeneratePixel();
                return;
            }
            if (IsGradient)
            {
                GenerateGradient();
                return;
            }
        }

        private void StartSaveBtn_Click_1(object sender, EventArgs e)
        {
            if (IsGenerated)
            {
                THeight.Value = PreviewBox.BackgroundImage.Height;
                TWidth.Value = PreviewBox.BackgroundImage.Width;
                UpdateSaveRuntime(TWidth.Value, THeight.Value);
                save.Visible = true;
                EditPanel.SendToBack();
            }
            else
            {
                MessageBox.Show("You must generate an image first to save it!", "Error!");
            }
        }

        private void LayoutType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LayoutType2.SelectedItem)
            {
                case "Zoom":
                    RuntimePicSave.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                case "Strech":
                    RuntimePicSave.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Tile":
                    RuntimePicSave.BackgroundImageLayout = ImageLayout.Tile;
                    break;
                case "Center":
                    RuntimePicSave.BackgroundImageLayout = ImageLayout.Center;
                    break;
                case "None":
                    RuntimePicSave.BackgroundImageLayout = ImageLayout.None;
                    break;
            }
        }
        private void LayoutType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (LayoutType.SelectedItem)
            {
                case "Zoom":
                    PreviewBox.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                case "Strech":
                    PreviewBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Tile":
                    PreviewBox.BackgroundImageLayout = ImageLayout.Tile;
                    break;
                case "Center":
                    PreviewBox.BackgroundImageLayout = ImageLayout.Center;
                    break;
                case "None":
                    PreviewBox.BackgroundImageLayout = ImageLayout.None;
                    break;
            }
        }

        private void BackgroundType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BackgroundType.SelectedItem.ToString())
            {
                case "Gradient":
                    IsGradient = true;
                    IsPixel = false;
                    IsCustom = false;
                    TxtHeight.Text = "";
                    TxtWidth.Text = "";
                    LayoutType.SelectedItem = "Zoom";
                    break;
                case "Pixel":
                    IsPixel = true;
                    IsGradient = false;
                    IsCustom = false;
                    break;
                case "Custom":
                    IsCustom = true;
                    IsPixel = false;
                    IsGradient = false;
                    break;
                default:
                    break;
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesForm PF = new PreferencesForm(FormPreferences, this);
            if (PF.ShowDialog() == DialogResult.OK)
            {
                FormPreferences = Preferences.Load(PreferencesFile);
                FormManager1.ChangeColorScheme(FormPreferences.ColorScheme);
                FormManager1.ChangeTheme(FormPreferences.Theme);
                FormWindowState Fws = WindowState;
                WindowState = FormWindowState.Minimized;
                WindowState = Fws;
            }
        }

        private void AdvancedPanelMenu_Click_1(object sender, EventArgs e)
        {
            BasicPanel.Visible = false;
            SizePanel.Visible = false;
            AdvancedPanel.Visible = AdvancedPanel.Visible == true ? AdvancedPanel.Visible = false : AdvancedPanel.Visible = true;
        }
        private void BasicPanelMenu_Click(object sender, EventArgs e)
        {
            SizePanel.Visible = false;
            AdvancedPanel.Visible = false;
            BasicPanel.Visible = BasicPanel.Visible == true ? BasicPanel.Visible = false : BasicPanel.Visible = true;
        }
        private void ClearTheme()
        {
            TxtR.Clear();
            TxtG.Clear();
            TxtB.Clear();
        }
        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTheme();
            switch (ThemeType.SelectedItem.ToString())
            {
                case "Red":
                    TxtR.Text = "255";
                    break;
                case "Blue":
                    TxtB.Text = "255";
                    break;
                case "Pink":
                    TxtR.Text = "255";
                    TxtB.Text = "230";
                    break;
                case "Yellow":
                    TxtR.Text = "255";
                    TxtG.Text = "255";
                    break;
                case "Purple":
                    TxtR.Text = "130";
                    TxtB.Text = "255";
                    break;
                case "Green":
                    TxtG.Text = "255";
                    Random rnd = new Random();

                    TxtB.Text = (rnd.Next(25,155)).ToString();
                    break;
            }
        }

        private void TxtG_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private bool IsRightSizeGripDown;
        private void RightSizeGrip_MouseDown(object sender, MouseEventArgs e)
        {
            IsRightSizeGripDown = true;
        }

        private void RightSizeGrip_MouseUp(object sender, MouseEventArgs e)
        {
            IsRightSizeGripDown = false;
        }

        private void RightSizeGrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsRightSizeGripDown)
            {
                Width = Cursor.Position.X - Left;
                Application.DoEvents();
            }
        }
        private bool IsLeftSizeGripDown;
        private void LeftSizeGrip_MouseDown(object sender, MouseEventArgs e)
        {
            IsLeftSizeGripDown = true;
        }

        private void LeftSizeGrip_MouseUp(object sender, MouseEventArgs e)
        {
            IsLeftSizeGripDown = false;
        }

        private void LeftSizeGrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsLeftSizeGripDown)
            {
                //   this.Width = Cursor.Position.X + this.Right;
                Application.DoEvents();
            }
        }
    }
}

