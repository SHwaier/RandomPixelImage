namespace RandomPixelImage
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.save = new System.Windows.Forms.Panel();
            this.SaveOptionsPanel = new System.Windows.Forms.Panel();
            this.RuntimePicSave = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LayoutType2 = new MaterialSkin.Controls.MaterialComboBox();
            this.SaveBtn = new MaterialSkin.Controls.MaterialButton();
            this.TxtSaveWidth = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSaveHeight = new MaterialSkin.Controls.MaterialLabel();
            this.TxtQuality = new MaterialSkin.Controls.MaterialLabel();
            this.TQuality = new MetroFramework.Controls.MetroTrackBar();
            this.THeight = new MetroFramework.Controls.MetroTrackBar();
            this.TWidth = new MetroFramework.Controls.MetroTrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Cancel = new MaterialSkin.Controls.MaterialButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AdvancedPanel = new System.Windows.Forms.Panel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.LblViewMode = new MaterialSkin.Controls.MaterialLabel();
            this.TxtB = new MaterialSkin.Controls.MaterialTextBox();
            this.LblBlue = new MaterialSkin.Controls.MaterialLabel();
            this.TxtA = new MaterialSkin.Controls.MaterialTextBox();
            this.LblGreen = new MaterialSkin.Controls.MaterialLabel();
            this.TxtR = new MaterialSkin.Controls.MaterialTextBox();
            this.LblRed = new MaterialSkin.Controls.MaterialLabel();
            this.TxtG = new MaterialSkin.Controls.MaterialTextBox();
            this.LayoutType = new MaterialSkin.Controls.MaterialComboBox();
            this.LblAlpha = new MaterialSkin.Controls.MaterialLabel();
            this.AdvancedPanelMenu = new MaterialSkin.Controls.MaterialButton();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.GenerateBtn = new MaterialSkin.Controls.MaterialButton();
            this.StartSaveBtn = new MaterialSkin.Controls.MaterialButton();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BasicPanel = new System.Windows.Forms.Panel();
            this.ThemeType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.BackgroundType = new MaterialSkin.Controls.MaterialComboBox();
            this.LblImageType = new MaterialSkin.Controls.MaterialLabel();
            this.BasicPanelMenu = new MaterialSkin.Controls.MaterialButton();
            this.SizePanel = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TxtHeight = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtWidth = new MaterialSkin.Controls.MaterialTextBox();
            this.LblWidth = new MaterialSkin.Controls.MaterialLabel();
            this.LblHeight = new MaterialSkin.Controls.MaterialLabel();
            this.SizePanelMenu = new MaterialSkin.Controls.MaterialButton();
            this.RightSizeGrip = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftSizeGrip = new System.Windows.Forms.Panel();
            this.MainContextStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save.SuspendLayout();
            this.SaveOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RuntimePicSave)).BeginInit();
            this.panel1.SuspendLayout();
            this.AdvancedPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.BasicPanel.SuspendLayout();
            this.SizePanel.SuspendLayout();
            this.RightSizeGrip.SuspendLayout();
            this.MainContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.save.Controls.Add(this.SaveOptionsPanel);
            this.save.Location = new System.Drawing.Point(0, 62);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(1116, 553);
            this.save.TabIndex = 28;
            this.save.Visible = false;
            // 
            // SaveOptionsPanel
            // 
            this.SaveOptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveOptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.SaveOptionsPanel.Controls.Add(this.RuntimePicSave);
            this.SaveOptionsPanel.Controls.Add(this.panel1);
            this.SaveOptionsPanel.Location = new System.Drawing.Point(12, 15);
            this.SaveOptionsPanel.Name = "SaveOptionsPanel";
            this.SaveOptionsPanel.Size = new System.Drawing.Size(1087, 520);
            this.SaveOptionsPanel.TabIndex = 37;
            // 
            // RuntimePicSave
            // 
            this.RuntimePicSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RuntimePicSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RuntimePicSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuntimePicSave.Location = new System.Drawing.Point(0, 0);
            this.RuntimePicSave.Name = "RuntimePicSave";
            this.RuntimePicSave.Size = new System.Drawing.Size(635, 520);
            this.RuntimePicSave.TabIndex = 3;
            this.RuntimePicSave.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.LayoutType2);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.TxtSaveWidth);
            this.panel1.Controls.Add(this.TxtSaveHeight);
            this.panel1.Controls.Add(this.TxtQuality);
            this.panel1.Controls.Add(this.TQuality);
            this.panel1.Controls.Add(this.THeight);
            this.panel1.Controls.Add(this.TWidth);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(635, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 520);
            this.panel1.TabIndex = 37;
            // 
            // LayoutType2
            // 
            this.LayoutType2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LayoutType2.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Tile",
            "Center",
            "Strech",
            "Zoom"});
            this.LayoutType2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LayoutType2.AutoResize = false;
            this.LayoutType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LayoutType2.Depth = 0;
            this.LayoutType2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.LayoutType2.DropDownHeight = 118;
            this.LayoutType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LayoutType2.DropDownWidth = 121;
            this.LayoutType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LayoutType2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LayoutType2.FormattingEnabled = true;
            this.LayoutType2.Hint = "Zoom";
            this.LayoutType2.IntegralHeight = false;
            this.LayoutType2.ItemHeight = 29;
            this.LayoutType2.Items.AddRange(new object[] {
            "None",
            "Tile",
            "Center",
            "Strech",
            "Zoom"});
            this.LayoutType2.Location = new System.Drawing.Point(18, 327);
            this.LayoutType2.MaxDropDownItems = 4;
            this.LayoutType2.MouseState = MaterialSkin.MouseState.OUT;
            this.LayoutType2.Name = "LayoutType2";
            this.LayoutType2.Size = new System.Drawing.Size(200, 35);
            this.LayoutType2.TabIndex = 60;
            this.LayoutType2.UseTallSize = false;
            this.LayoutType2.SelectedIndexChanged += new System.EventHandler(this.LayoutType2_SelectedIndexChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveBtn.Depth = 0;
            this.SaveBtn.DrawShadows = true;
            this.SaveBtn.HighEmphasis = true;
            this.SaveBtn.Icon = null;
            this.SaveBtn.Location = new System.Drawing.Point(294, 477);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(58, 36);
            this.SaveBtn.TabIndex = 59;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveBtn.UseAccentColor = false;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TxtSaveWidth
            // 
            this.TxtSaveWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSaveWidth.AutoSize = true;
            this.TxtSaveWidth.Depth = 0;
            this.TxtSaveWidth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaveWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtSaveWidth.Location = new System.Drawing.Point(369, 167);
            this.TxtSaveWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaveWidth.Name = "TxtSaveWidth";
            this.TxtSaveWidth.Size = new System.Drawing.Size(45, 19);
            this.TxtSaveWidth.TabIndex = 47;
            this.TxtSaveWidth.Text = "100px";
            // 
            // TxtSaveHeight
            // 
            this.TxtSaveHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSaveHeight.AutoSize = true;
            this.TxtSaveHeight.Depth = 0;
            this.TxtSaveHeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaveHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtSaveHeight.Location = new System.Drawing.Point(371, 124);
            this.TxtSaveHeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaveHeight.Name = "TxtSaveHeight";
            this.TxtSaveHeight.Size = new System.Drawing.Size(36, 19);
            this.TxtSaveHeight.TabIndex = 46;
            this.TxtSaveHeight.Text = "50px";
            // 
            // TxtQuality
            // 
            this.TxtQuality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtQuality.AutoSize = true;
            this.TxtQuality.Depth = 0;
            this.TxtQuality.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtQuality.Location = new System.Drawing.Point(371, 202);
            this.TxtQuality.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtQuality.Name = "TxtQuality";
            this.TxtQuality.Size = new System.Drawing.Size(19, 19);
            this.TxtQuality.TabIndex = 45;
            this.TxtQuality.Text = "75";
            // 
            // TQuality
            // 
            this.TQuality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TQuality.BackColor = System.Drawing.Color.Transparent;
            this.TQuality.LargeChange = 100;
            this.TQuality.Location = new System.Drawing.Point(104, 203);
            this.TQuality.Minimum = 1;
            this.TQuality.MouseWheelBarPartitions = 500;
            this.TQuality.Name = "TQuality";
            this.TQuality.Size = new System.Drawing.Size(264, 23);
            this.TQuality.SmallChange = 5;
            this.TQuality.Style = MetroFramework.MetroColorStyle.Green;
            this.TQuality.TabIndex = 44;
            this.TQuality.Text = "metroTrackBar1";
            this.TQuality.UseCustomBackColor = true;
            this.TQuality.Value = 75;
            this.TQuality.ValueChanged += new System.EventHandler(this.TQuality_ValueChanged);
            // 
            // THeight
            // 
            this.THeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.THeight.BackColor = System.Drawing.Color.Transparent;
            this.THeight.LargeChange = 100;
            this.THeight.Location = new System.Drawing.Point(104, 125);
            this.THeight.Maximum = 720;
            this.THeight.Minimum = 1;
            this.THeight.MouseWheelBarPartitions = 500;
            this.THeight.Name = "THeight";
            this.THeight.Size = new System.Drawing.Size(264, 23);
            this.THeight.Style = MetroFramework.MetroColorStyle.Green;
            this.THeight.TabIndex = 43;
            this.THeight.Text = "metroTrackBar1";
            this.THeight.UseCustomBackColor = true;
            this.THeight.ValueChanged += new System.EventHandler(this.THeight_Scroll);
            // 
            // TWidth
            // 
            this.TWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TWidth.BackColor = System.Drawing.Color.Transparent;
            this.TWidth.LargeChange = 100;
            this.TWidth.Location = new System.Drawing.Point(104, 168);
            this.TWidth.Maximum = 720;
            this.TWidth.Minimum = 1;
            this.TWidth.MouseWheelBarPartitions = 500;
            this.TWidth.Name = "TWidth";
            this.TWidth.Size = new System.Drawing.Size(264, 23);
            this.TWidth.Style = MetroFramework.MetroColorStyle.Green;
            this.TWidth.TabIndex = 42;
            this.TWidth.Text = "metroTrackBar1";
            this.TWidth.UseCustomBackColor = true;
            this.TWidth.ValueChanged += new System.EventHandler(this.TWidth_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "The view mode will not change the final image.";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "View Mode";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(13, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 28);
            this.label15.TabIndex = 38;
            this.label15.Text = "Width:";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.Depth = 0;
            this.Cancel.DrawShadows = true;
            this.Cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.Cancel.HighEmphasis = true;
            this.Cancel.Icon = null;
            this.Cancel.Location = new System.Drawing.Point(360, 477);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(77, 36);
            this.Cancel.TabIndex = 37;
            this.Cancel.Text = "Cancel";
            this.Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Cancel.UseAccentColor = false;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(13, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 28);
            this.label14.TabIndex = 37;
            this.label14.Text = "Height:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 28);
            this.label13.TabIndex = 35;
            this.label13.Text = "Quality:";
            // 
            // AdvancedPanel
            // 
            this.AdvancedPanel.Controls.Add(this.materialDivider3);
            this.AdvancedPanel.Controls.Add(this.LblViewMode);
            this.AdvancedPanel.Controls.Add(this.TxtB);
            this.AdvancedPanel.Controls.Add(this.LblBlue);
            this.AdvancedPanel.Controls.Add(this.TxtA);
            this.AdvancedPanel.Controls.Add(this.LblGreen);
            this.AdvancedPanel.Controls.Add(this.TxtR);
            this.AdvancedPanel.Controls.Add(this.LblRed);
            this.AdvancedPanel.Controls.Add(this.TxtG);
            this.AdvancedPanel.Controls.Add(this.LayoutType);
            this.AdvancedPanel.Controls.Add(this.LblAlpha);
            this.AdvancedPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdvancedPanel.Location = new System.Drawing.Point(0, 335);
            this.AdvancedPanel.Name = "AdvancedPanel";
            this.AdvancedPanel.Size = new System.Drawing.Size(237, 241);
            this.AdvancedPanel.TabIndex = 62;
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(10, 235);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(215, 3);
            this.materialDivider3.TabIndex = 60;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // LblViewMode
            // 
            this.LblViewMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblViewMode.AutoSize = true;
            this.LblViewMode.Depth = 0;
            this.LblViewMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblViewMode.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblViewMode.Location = new System.Drawing.Point(7, 198);
            this.LblViewMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblViewMode.Name = "LblViewMode";
            this.LblViewMode.Size = new System.Drawing.Size(79, 19);
            this.LblViewMode.TabIndex = 60;
            this.LblViewMode.Text = "View Mode";
            // 
            // TxtB
            // 
            this.TxtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TxtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtB.Depth = 0;
            this.TxtB.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtB.ForeColor = System.Drawing.Color.Silver;
            this.TxtB.Location = new System.Drawing.Point(112, 143);
            this.TxtB.MaxLength = 3;
            this.TxtB.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtB.Multiline = false;
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(122, 36);
            this.TxtB.TabIndex = 52;
            this.TxtB.Text = "";
            this.TxtB.UseTallSize = false;
            // 
            // LblBlue
            // 
            this.LblBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblBlue.AutoSize = true;
            this.LblBlue.Depth = 0;
            this.LblBlue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBlue.Location = new System.Drawing.Point(10, 160);
            this.LblBlue.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(32, 19);
            this.LblBlue.TabIndex = 62;
            this.LblBlue.Text = "Blue";
            // 
            // TxtA
            // 
            this.TxtA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TxtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtA.Depth = 0;
            this.TxtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtA.ForeColor = System.Drawing.Color.Silver;
            this.TxtA.Location = new System.Drawing.Point(112, 17);
            this.TxtA.MaxLength = 3;
            this.TxtA.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtA.Multiline = false;
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(122, 36);
            this.TxtA.TabIndex = 50;
            this.TxtA.Text = "255";
            this.TxtA.UseTallSize = false;
            // 
            // LblGreen
            // 
            this.LblGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblGreen.AutoSize = true;
            this.LblGreen.Depth = 0;
            this.LblGreen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblGreen.Location = new System.Drawing.Point(10, 118);
            this.LblGreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(42, 19);
            this.LblGreen.TabIndex = 61;
            this.LblGreen.Text = "Green";
            // 
            // TxtR
            // 
            this.TxtR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TxtR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtR.Depth = 0;
            this.TxtR.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtR.ForeColor = System.Drawing.Color.SteelBlue;
            this.TxtR.Location = new System.Drawing.Point(112, 59);
            this.TxtR.MaxLength = 3;
            this.TxtR.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtR.Multiline = false;
            this.TxtR.Name = "TxtR";
            this.TxtR.Size = new System.Drawing.Size(122, 36);
            this.TxtR.TabIndex = 51;
            this.TxtR.Text = "";
            this.TxtR.UseTallSize = false;
            // 
            // LblRed
            // 
            this.LblRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRed.AutoSize = true;
            this.LblRed.Depth = 0;
            this.LblRed.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblRed.Location = new System.Drawing.Point(10, 74);
            this.LblRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRed.Name = "LblRed";
            this.LblRed.Size = new System.Drawing.Size(28, 19);
            this.LblRed.TabIndex = 60;
            this.LblRed.Text = "Red";
            // 
            // TxtG
            // 
            this.TxtG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TxtG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtG.Depth = 0;
            this.TxtG.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtG.ForeColor = System.Drawing.Color.Silver;
            this.TxtG.Location = new System.Drawing.Point(112, 101);
            this.TxtG.MaxLength = 3;
            this.TxtG.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtG.Multiline = false;
            this.TxtG.Name = "TxtG";
            this.TxtG.Size = new System.Drawing.Size(122, 36);
            this.TxtG.TabIndex = 49;
            this.TxtG.Text = "";
            this.TxtG.UseTallSize = false;
            // 
            // LayoutType
            // 
            this.LayoutType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutType.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Tile",
            "Center",
            "Strech",
            "Zoom"});
            this.LayoutType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LayoutType.AutoResize = false;
            this.LayoutType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LayoutType.Depth = 0;
            this.LayoutType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.LayoutType.DropDownHeight = 118;
            this.LayoutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LayoutType.DropDownWidth = 121;
            this.LayoutType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LayoutType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LayoutType.FormattingEnabled = true;
            this.LayoutType.Hint = "Zoom";
            this.LayoutType.IntegralHeight = false;
            this.LayoutType.ItemHeight = 29;
            this.LayoutType.Items.AddRange(new object[] {
            "None",
            "Tile",
            "Center",
            "Strech",
            "Zoom"});
            this.LayoutType.Location = new System.Drawing.Point(112, 185);
            this.LayoutType.MaxDropDownItems = 4;
            this.LayoutType.MouseState = MaterialSkin.MouseState.OUT;
            this.LayoutType.Name = "LayoutType";
            this.LayoutType.Size = new System.Drawing.Size(122, 35);
            this.LayoutType.TabIndex = 59;
            this.LayoutType.UseTallSize = false;
            this.LayoutType.SelectedIndexChanged += new System.EventHandler(this.LayoutType_SelectedIndexChanged_1);
            // 
            // LblAlpha
            // 
            this.LblAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblAlpha.AutoSize = true;
            this.LblAlpha.Depth = 0;
            this.LblAlpha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblAlpha.Location = new System.Drawing.Point(10, 34);
            this.LblAlpha.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAlpha.Name = "LblAlpha";
            this.LblAlpha.Size = new System.Drawing.Size(42, 19);
            this.LblAlpha.TabIndex = 59;
            this.LblAlpha.Text = "Alpha";
            // 
            // AdvancedPanelMenu
            // 
            this.AdvancedPanelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdvancedPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AdvancedPanelMenu.Depth = 0;
            this.AdvancedPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdvancedPanelMenu.DrawShadows = true;
            this.AdvancedPanelMenu.HighEmphasis = true;
            this.AdvancedPanelMenu.Icon = null;
            this.AdvancedPanelMenu.Location = new System.Drawing.Point(0, 299);
            this.AdvancedPanelMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AdvancedPanelMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdvancedPanelMenu.Name = "AdvancedPanelMenu";
            this.AdvancedPanelMenu.Size = new System.Drawing.Size(237, 36);
            this.AdvancedPanelMenu.TabIndex = 63;
            this.AdvancedPanelMenu.Text = "Advanced";
            this.AdvancedPanelMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.AdvancedPanelMenu.UseAccentColor = false;
            this.AdvancedPanelMenu.UseVisualStyleBackColor = false;
            this.AdvancedPanelMenu.Click += new System.EventHandler(this.AdvancedPanelMenu_Click_1);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EditPanel.Controls.Add(this.splitContainer1);
            this.EditPanel.Controls.Add(this.RightSizeGrip);
            this.EditPanel.Controls.Add(this.LeftSizeGrip);
            this.EditPanel.Location = new System.Drawing.Point(0, 62);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1119, 553);
            this.EditPanel.TabIndex = 31;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PreviewBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GenerateBtn);
            this.splitContainer1.Panel2.Controls.Add(this.StartSaveBtn);
            this.splitContainer1.Panel2.Controls.Add(this.MenuPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1115, 553);
            this.splitContainer1.SplitterDistance = 846;
            this.splitContainer1.TabIndex = 62;
            // 
            // PreviewBox
            // 
            this.PreviewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PreviewBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewBox.InitialImage = null;
            this.PreviewBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewBox.Margin = new System.Windows.Forms.Padding(9, 900, 9, 9);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(846, 553);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewBox.TabIndex = 0;
            this.PreviewBox.TabStop = false;
            this.PreviewBox.Click += new System.EventHandler(this.PreviewBox_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateBtn.Depth = 0;
            this.GenerateBtn.DrawShadows = true;
            this.GenerateBtn.HighEmphasis = true;
            this.GenerateBtn.Icon = null;
            this.GenerateBtn.Location = new System.Drawing.Point(147, 502);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenerateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(95, 36);
            this.GenerateBtn.TabIndex = 57;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GenerateBtn.UseAccentColor = false;
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // StartSaveBtn
            // 
            this.StartSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartSaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartSaveBtn.Depth = 0;
            this.StartSaveBtn.DrawShadows = true;
            this.StartSaveBtn.HighEmphasis = true;
            this.StartSaveBtn.Icon = null;
            this.StartSaveBtn.Location = new System.Drawing.Point(84, 502);
            this.StartSaveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartSaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartSaveBtn.Name = "StartSaveBtn";
            this.StartSaveBtn.Size = new System.Drawing.Size(58, 36);
            this.StartSaveBtn.TabIndex = 58;
            this.StartSaveBtn.Text = "Save";
            this.StartSaveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.StartSaveBtn.UseAccentColor = false;
            this.StartSaveBtn.UseVisualStyleBackColor = true;
            this.StartSaveBtn.Click += new System.EventHandler(this.StartSaveBtn_Click_1);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.Controls.Add(this.AdvancedPanel);
            this.MenuPanel.Controls.Add(this.AdvancedPanelMenu);
            this.MenuPanel.Controls.Add(this.BasicPanel);
            this.MenuPanel.Controls.Add(this.BasicPanelMenu);
            this.MenuPanel.Controls.Add(this.SizePanel);
            this.MenuPanel.Controls.Add(this.SizePanelMenu);
            this.MenuPanel.Location = new System.Drawing.Point(3, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(254, 433);
            this.MenuPanel.TabIndex = 48;
            // 
            // BasicPanel
            // 
            this.BasicPanel.Controls.Add(this.ThemeType);
            this.BasicPanel.Controls.Add(this.materialLabel1);
            this.BasicPanel.Controls.Add(this.materialDivider2);
            this.BasicPanel.Controls.Add(this.BackgroundType);
            this.BasicPanel.Controls.Add(this.LblImageType);
            this.BasicPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BasicPanel.Location = new System.Drawing.Point(0, 172);
            this.BasicPanel.Name = "BasicPanel";
            this.BasicPanel.Size = new System.Drawing.Size(237, 127);
            this.BasicPanel.TabIndex = 0;
            // 
            // ThemeType
            // 
            this.ThemeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeType.AutoCompleteCustomSource.AddRange(new string[] {
            "Red",
            "Yellow",
            "Pink",
            "Blue",
            "Green",
            "Purple"});
            this.ThemeType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ThemeType.AutoResize = false;
            this.ThemeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ThemeType.Depth = 0;
            this.ThemeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ThemeType.DropDownHeight = 118;
            this.ThemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeType.DropDownWidth = 121;
            this.ThemeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ThemeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ThemeType.FormattingEnabled = true;
            this.ThemeType.Hint = "Theme";
            this.ThemeType.IntegralHeight = false;
            this.ThemeType.ItemHeight = 29;
            this.ThemeType.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Pink",
            "Blue",
            "Green",
            "Purple"});
            this.ThemeType.Location = new System.Drawing.Point(107, 18);
            this.ThemeType.MaxDropDownItems = 4;
            this.ThemeType.MouseState = MaterialSkin.MouseState.OUT;
            this.ThemeType.Name = "ThemeType";
            this.ThemeType.Size = new System.Drawing.Size(122, 35);
            this.ThemeType.TabIndex = 62;
            this.ThemeType.UseTallSize = false;
            this.ThemeType.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 63;
            this.materialLabel1.Text = "Theme";
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(10, 121);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(211, 3);
            this.materialDivider2.TabIndex = 60;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // BackgroundType
            // 
            this.BackgroundType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundType.AutoCompleteCustomSource.AddRange(new string[] {
            "Pixel",
            "Gradient",
            "Custom"});
            this.BackgroundType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BackgroundType.AutoResize = false;
            this.BackgroundType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundType.Depth = 0;
            this.BackgroundType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BackgroundType.DropDownHeight = 118;
            this.BackgroundType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackgroundType.DropDownWidth = 121;
            this.BackgroundType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BackgroundType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundType.FormattingEnabled = true;
            this.BackgroundType.Hint = "Random";
            this.BackgroundType.IntegralHeight = false;
            this.BackgroundType.ItemHeight = 29;
            this.BackgroundType.Items.AddRange(new object[] {
            "Pixel",
            "Gradient",
            "Custom"});
            this.BackgroundType.Location = new System.Drawing.Point(110, 70);
            this.BackgroundType.MaxDropDownItems = 4;
            this.BackgroundType.MouseState = MaterialSkin.MouseState.OUT;
            this.BackgroundType.Name = "BackgroundType";
            this.BackgroundType.Size = new System.Drawing.Size(122, 35);
            this.BackgroundType.TabIndex = 58;
            this.BackgroundType.UseTallSize = false;
            this.BackgroundType.SelectedIndexChanged += new System.EventHandler(this.BackgroundType_SelectedIndexChanged);
            // 
            // LblImageType
            // 
            this.LblImageType.AutoSize = true;
            this.LblImageType.Depth = 0;
            this.LblImageType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblImageType.Location = new System.Drawing.Point(9, 74);
            this.LblImageType.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblImageType.Name = "LblImageType";
            this.LblImageType.Size = new System.Drawing.Size(84, 19);
            this.LblImageType.TabIndex = 61;
            this.LblImageType.Text = "Image Type";
            // 
            // BasicPanelMenu
            // 
            this.BasicPanelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BasicPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BasicPanelMenu.Depth = 0;
            this.BasicPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BasicPanelMenu.DrawShadows = true;
            this.BasicPanelMenu.HighEmphasis = true;
            this.BasicPanelMenu.Icon = null;
            this.BasicPanelMenu.Location = new System.Drawing.Point(0, 136);
            this.BasicPanelMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BasicPanelMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.BasicPanelMenu.Name = "BasicPanelMenu";
            this.BasicPanelMenu.Size = new System.Drawing.Size(237, 36);
            this.BasicPanelMenu.TabIndex = 49;
            this.BasicPanelMenu.Text = "Basic";
            this.BasicPanelMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.BasicPanelMenu.UseAccentColor = false;
            this.BasicPanelMenu.UseVisualStyleBackColor = false;
            this.BasicPanelMenu.Click += new System.EventHandler(this.BasicPanelMenu_Click);
            // 
            // SizePanel
            // 
            this.SizePanel.Controls.Add(this.materialDivider1);
            this.SizePanel.Controls.Add(this.TxtHeight);
            this.SizePanel.Controls.Add(this.TxtWidth);
            this.SizePanel.Controls.Add(this.LblWidth);
            this.SizePanel.Controls.Add(this.LblHeight);
            this.SizePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SizePanel.Location = new System.Drawing.Point(0, 36);
            this.SizePanel.Name = "SizePanel";
            this.SizePanel.Size = new System.Drawing.Size(237, 100);
            this.SizePanel.TabIndex = 0;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(10, 90);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(211, 3);
            this.materialDivider1.TabIndex = 59;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TxtHeight
            // 
            this.TxtHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TxtHeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TxtHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHeight.Depth = 0;
            this.TxtHeight.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtHeight.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TxtHeight.Location = new System.Drawing.Point(111, 3);
            this.TxtHeight.MaxLength = 3;
            this.TxtHeight.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtHeight.Multiline = false;
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(119, 36);
            this.TxtHeight.TabIndex = 34;
            this.TxtHeight.Text = "";
            this.TxtHeight.UseTallSize = false;
            this.TxtHeight.TextChanged += new System.EventHandler(this.TxtHeight_TextChanged);
            this.TxtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generate_KeyPress);
            // 
            // TxtWidth
            // 
            this.TxtWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TxtWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtWidth.Depth = 0;
            this.TxtWidth.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtWidth.ForeColor = System.Drawing.Color.Silver;
            this.TxtWidth.Location = new System.Drawing.Point(111, 45);
            this.TxtWidth.MaxLength = 3;
            this.TxtWidth.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtWidth.Multiline = false;
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(119, 36);
            this.TxtWidth.TabIndex = 36;
            this.TxtWidth.Text = "";
            this.TxtWidth.UseTallSize = false;
            this.TxtWidth.TextChanged += new System.EventHandler(this.TxtWidth_TextChanged);
            this.TxtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generate_KeyPress);
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Depth = 0;
            this.LblWidth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblWidth.Location = new System.Drawing.Point(10, 62);
            this.LblWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(42, 19);
            this.LblWidth.TabIndex = 41;
            this.LblWidth.Text = "Width";
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Depth = 0;
            this.LblHeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblHeight.Location = new System.Drawing.Point(10, 20);
            this.LblHeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(47, 19);
            this.LblHeight.TabIndex = 40;
            this.LblHeight.Text = "Height";
            // 
            // SizePanelMenu
            // 
            this.SizePanelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SizePanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SizePanelMenu.Depth = 0;
            this.SizePanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SizePanelMenu.DrawShadows = true;
            this.SizePanelMenu.HighEmphasis = true;
            this.SizePanelMenu.Icon = null;
            this.SizePanelMenu.Location = new System.Drawing.Point(0, 0);
            this.SizePanelMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SizePanelMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.SizePanelMenu.Name = "SizePanelMenu";
            this.SizePanelMenu.Size = new System.Drawing.Size(237, 36);
            this.SizePanelMenu.TabIndex = 46;
            this.SizePanelMenu.Text = "Size";
            this.SizePanelMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.SizePanelMenu.UseAccentColor = false;
            this.SizePanelMenu.UseVisualStyleBackColor = false;
            this.SizePanelMenu.Click += new System.EventHandler(this.SizePanelMenu_Click);
            // 
            // RightSizeGrip
            // 
            this.RightSizeGrip.Controls.Add(this.panel2);
            this.RightSizeGrip.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightSizeGrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSizeGrip.Location = new System.Drawing.Point(1117, 0);
            this.RightSizeGrip.Margin = new System.Windows.Forms.Padding(0);
            this.RightSizeGrip.Name = "RightSizeGrip";
            this.RightSizeGrip.Size = new System.Drawing.Size(2, 553);
            this.RightSizeGrip.TabIndex = 59;
            this.RightSizeGrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightSizeGrip_MouseDown);
            this.RightSizeGrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightSizeGrip_MouseMove);
            this.RightSizeGrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightSizeGrip_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 553);
            this.panel2.TabIndex = 60;
            // 
            // LeftSizeGrip
            // 
            this.LeftSizeGrip.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftSizeGrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSizeGrip.Location = new System.Drawing.Point(0, 0);
            this.LeftSizeGrip.Margin = new System.Windows.Forms.Padding(0);
            this.LeftSizeGrip.Name = "LeftSizeGrip";
            this.LeftSizeGrip.Size = new System.Drawing.Size(2, 553);
            this.LeftSizeGrip.TabIndex = 60;
            this.LeftSizeGrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftSizeGrip_MouseDown);
            this.LeftSizeGrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftSizeGrip_MouseMove);
            this.LeftSizeGrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftSizeGrip_MouseUp);
            // 
            // MainContextStrip
            // 
            this.MainContextStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MainContextStrip.Depth = 0;
            this.MainContextStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.MainContextStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainContextStrip.Name = "MainContextStrip";
            this.MainContextStrip.Size = new System.Drawing.Size(184, 26);
            this.MainContextStrip.Text = "fdfgh";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences & Settings";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 615);
            this.ContextMenuStrip = this.MainContextStrip;
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.save);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Random Pixel Image";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.save.ResumeLayout(false);
            this.SaveOptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RuntimePicSave)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AdvancedPanel.ResumeLayout(false);
            this.AdvancedPanel.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.BasicPanel.ResumeLayout(false);
            this.BasicPanel.PerformLayout();
            this.SizePanel.ResumeLayout(false);
            this.SizePanel.PerformLayout();
            this.RightSizeGrip.ResumeLayout(false);
            this.MainContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel save;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel SaveOptionsPanel;
        private MaterialSkin.Controls.MaterialButton Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialTextBox TxtWidth;
        private MaterialSkin.Controls.MaterialTextBox TxtHeight;
        private MetroFramework.Controls.MetroTrackBar THeight;
        private MetroFramework.Controls.MetroTrackBar TWidth;
        private MetroFramework.Controls.MetroTrackBar TQuality;
        private MaterialSkin.Controls.MaterialLabel LblHeight;
        private MaterialSkin.Controls.MaterialLabel LblWidth;
        private MaterialSkin.Controls.MaterialLabel TxtQuality;
        private MaterialSkin.Controls.MaterialLabel TxtSaveHeight;
        private MaterialSkin.Controls.MaterialLabel TxtSaveWidth;
        private MaterialSkin.Controls.MaterialButton SizePanelMenu;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel BasicPanel;
        private MaterialSkin.Controls.MaterialButton BasicPanelMenu;
        private System.Windows.Forms.Panel SizePanel;
        private MaterialSkin.Controls.MaterialTextBox TxtB;
        private MaterialSkin.Controls.MaterialTextBox TxtG;
        private MaterialSkin.Controls.MaterialTextBox TxtA;
        private MaterialSkin.Controls.MaterialTextBox TxtR;
        private System.Windows.Forms.PictureBox RuntimePicSave;
        private MaterialSkin.Controls.MaterialComboBox LayoutType;
        private MaterialSkin.Controls.MaterialLabel LblViewMode;
        private MaterialSkin.Controls.MaterialLabel LblBlue;
        private MaterialSkin.Controls.MaterialLabel LblGreen;
        private MaterialSkin.Controls.MaterialLabel LblRed;
        private MaterialSkin.Controls.MaterialLabel LblAlpha;
        private MaterialSkin.Controls.MaterialButton SaveBtn;
        private MaterialSkin.Controls.MaterialComboBox LayoutType2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialContextMenuStrip MainContextStrip;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton GenerateBtn;
        private MaterialSkin.Controls.MaterialLabel LblImageType;
        private MaterialSkin.Controls.MaterialButton StartSaveBtn;
        private MaterialSkin.Controls.MaterialComboBox BackgroundType;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel AdvancedPanel;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialButton AdvancedPanelMenu;
        private MaterialSkin.Controls.MaterialComboBox ThemeType;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel RightSizeGrip;
        private System.Windows.Forms.Panel LeftSizeGrip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PreviewBox;
    }
}