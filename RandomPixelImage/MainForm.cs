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
        /// Specifies what type of generation should be performed
        /// </summary>
        private enum GenerationMode
        {
            Pixel,
            Gradient,
            Custom
        };
        GenerationMode Mode;
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
        readonly FormManager FormManager1;

        //public MainForm(Preferences FormPreferences1)
        public MainForm()
        {
            InitializeComponent();
            SetClassLong(Handle, GCL_STYLE, GetClassLong(Handle, GCL_STYLE) | CS_DropSHADOW);
            //FormPreferences = FormPreferences1;
            FormManager1 = new FormManager(this, FormPreferences);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
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
            SavePanel.Size = new Size(Width, FormHeight);
            EditPanel.Size = new Size(Width, FormHeight);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            SavePanel.Size = new Size(Width, Height - 62);
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

            Image NewImage = new Bitmap(img, size.Width, size.Height);
            using (Graphics GFX = Graphics.FromImage((Bitmap)NewImage))
            {
                GFX.InterpolationMode = InterpolationMode.HighQualityBicubic;
                GFX.SmoothingMode = SmoothingMode.HighQuality;
                GFX.PixelOffsetMode = PixelOffsetMode.HighQuality;
                GFX.CompositingQuality = CompositingQuality.HighQuality;
                GFX.DrawImage(img, new Rectangle(Point.Empty, size));
                GFX.Dispose();
                return NewImage;
            }

        }
        private void ChageSavingProgress(int IncreaseBy, bool IsSave)
        {
            //if (IsSave)
                //SavingMsg.Progress(SavingMsg.Value + IncreaseBy);
        }

        private void UpdateSaveRuntime(int _Width, int _Height)
        {
            if (IsSizeChanging)
                RuntimePicSave.BackgroundImage = null;
            Image img = PreviewBox.BackgroundImage;
            Size size = new Size(_Width, _Height);
            img = ResizeImage(img, size);
            RuntimePicSave.BackgroundImage = img;
        }

        /// <summary>
        /// Validates the user input and makes sure that the input is a numeric input between 1-255. 
        /// Set second and third parameters (a and b) to 0 if no range is needed
        /// Will return -1 if invalid input, -2 if input is empty, otherwise valid input will be returned.
        /// </summary>
        /// <param name="input">string input. The input the user enters, and will be validated</param>
        /// <param name="a">int start range. User input will be evaluated based on this start range</param>
        /// <param name="b">int end range. User input will be evaluated based on this end range</param>
        /// <returns></returns>
        public int ValidateNumericInput(string input, int a, int b)
        {
            int value = 0;
            if (a == 0 && b == 0)
            {
                if (int.TryParse(input, out value))
                {

                    return value;
                }
            }
            if (int.TryParse(input, out value) && value >= a && value <= b)
            {

                return value;
            }
            MessageBox.Show("The input you provided is invalid, please enter an integer number, between 1-255!", "Invalid Input");
            return -1;
            
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
                SavePanel.Visible = false;
                SavePanel.SendToBack();
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
                ImageCodecInfo ici = null;
                EncoderParameters ep = new EncoderParameters();
                ep.Param[0] = new EncoderParameter(Encoder.Quality, (long)TQuality.Value);
                foreach (ImageCodecInfo codec in codecs)
                {
                    if (codec.MimeType == "image/jpeg")
                    {
                        ici = codec;
                    }
                }
                bm.Save(SVFileName, ici, ep);
                ep.Dispose();
                bm.Dispose();
            }
            else
            {
                img.Save(SVFileName);
            }
        }

        private void TWidth_ValueChanged(object sender, EventArgs e)
        {
            TxtSaveWidth.Text = TWidth.Value + "px";
        }

        private void THeight_Scroll(object sender, EventArgs e)
        {
            TxtSaveHeight.Text = THeight.Value + "px";
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
            Mode = GenerationMode.Custom;
            BackgroundType.Refresh();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            SavePanel.Visible = false;
            RuntimePicSave.BackgroundImage = null;
            EditPanel.BringToFront();
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

                PreviewBox.BackgroundImage = Bmp;
                
                Activate();
                IsGenerated = true;
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
            if (Mode == GenerationMode.Custom && TxtHeight.Text != "" && TxtWidth.Text != "")
            {
                GenerateCustom();
                return;
            }
            switch (Mode)
            {
                case GenerationMode.Pixel:
                GeneratePixel();
                    break;
                case GenerationMode.Gradient:
                GenerateGradient();
                    break;
                case GenerationMode.Custom:
                MessageBox.Show("Please enter some custom inputs first", "Notice");
                    break;
                default:
                    break;
            }
        }

        private void StartSaveBtn_Click_1(object sender, EventArgs e)
        {
            if (IsGenerated)
            {
                THeight.Value = PreviewBox.BackgroundImage.Height;
                TWidth.Value = PreviewBox.BackgroundImage.Width;
                UpdateSaveRuntime(TWidth.Value, THeight.Value);
                SavePanel.Visible = true;
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
                    Mode = GenerationMode.Gradient;
                    TxtHeight.Text = "";
                    TxtWidth.Text = "";
                    LayoutType.SelectedItem = "Zoom";
                    break;
                case "Pixel":
                    Mode = GenerationMode.Pixel;
                    break;
                case "Custom":
                    Mode = GenerationMode.Custom;
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

                    TxtB.Text = (rnd.Next(25, 155)).ToString();
                    break;
            }
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
                this.Width = Width + Cursor.Position.X;
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
                this.Width = Cursor.Position.X + this.Left;
            }
        }

        private void PreviewBox_Click(object sender, EventArgs e)
        {

        }
    }
}

