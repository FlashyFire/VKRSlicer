namespace SlicerProto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.glControl1 = new OpenTK.GLControl();
            this.panModel = new System.Windows.Forms.Panel();
            this.cbSolidLayer = new System.Windows.Forms.CheckBox();
            this.cbInnerPerimeter = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.edPositionY = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.edPositionX = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.butAutoScaling = new System.Windows.Forms.Button();
            this.butResetScaling = new System.Windows.Forms.Button();
            this.edScaleZ = new System.Windows.Forms.NumericUpDown();
            this.edScaleY = new System.Windows.Forms.NumericUpDown();
            this.edScaleX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.edModelHeight = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.edModelDepth = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.edModelWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKeepAspect = new System.Windows.Forms.CheckBox();
            this.butZ90 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.edPlane = new System.Windows.Forms.TrackBar();
            this.butY90 = new System.Windows.Forms.Button();
            this.butX90 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panDisplay = new System.Windows.Forms.Panel();
            this.cbWireframe = new System.Windows.Forms.CheckBox();
            this.butReset = new System.Windows.Forms.Button();
            this.edDistance = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.edRotationZ = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.edRotationX = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mnuFileGenerateGCode = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edScaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edModelHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edModelDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edModelWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPlane)).BeginInit();
            this.panDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRotationZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRotationX)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuOptions,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.mnuFileGenerateGCode,
            this.toolStripMenuItem1,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(57, 24);
            this.menuFile.Text = "Файл";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(254, 26);
            this.menuFileOpen.Text = "Открыть...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(251, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuFileExit.Size = new System.Drawing.Size(254, 26);
            this.menuFileExit.Text = "Выход";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptionsSettings});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(68, 24);
            this.menuOptions.Text = "Опции";
            // 
            // menuOptionsSettings
            // 
            this.menuOptionsSettings.Name = "menuOptionsSettings";
            this.menuOptionsSettings.Size = new System.Drawing.Size(168, 26);
            this.menuOptionsSettings.Text = "Настройки...";
            this.menuOptionsSettings.Click += new System.EventHandler(this.menuOptionsSettings_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(79, 24);
            this.menuHelp.Text = "Справка";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(188, 26);
            this.menuHelpAbout.Text = "О программе...";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "stl";
            this.openFileDialog1.Filter = "3D models|*.stl;*.obj|STL files|*.stl|OBJ files|*.obj|All files|*.*";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.glControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panModel);
            this.splitContainer1.Panel2.Controls.Add(this.panDisplay);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.splitContainer1.Panel2MinSize = 260;
            this.splitContainer1.Size = new System.Drawing.Size(1064, 533);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.TabIndex = 9;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.White;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(800, 533);
            this.glControl1.TabIndex = 3;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // panModel
            // 
            this.panModel.Controls.Add(this.cbSolidLayer);
            this.panModel.Controls.Add(this.cbInnerPerimeter);
            this.panModel.Controls.Add(this.label14);
            this.panModel.Controls.Add(this.edPositionY);
            this.panModel.Controls.Add(this.label12);
            this.panModel.Controls.Add(this.edPositionX);
            this.panModel.Controls.Add(this.label13);
            this.panModel.Controls.Add(this.label11);
            this.panModel.Controls.Add(this.butAutoScaling);
            this.panModel.Controls.Add(this.butResetScaling);
            this.panModel.Controls.Add(this.edScaleZ);
            this.panModel.Controls.Add(this.edScaleY);
            this.panModel.Controls.Add(this.edScaleX);
            this.panModel.Controls.Add(this.label4);
            this.panModel.Controls.Add(this.edModelHeight);
            this.panModel.Controls.Add(this.label10);
            this.panModel.Controls.Add(this.edModelDepth);
            this.panModel.Controls.Add(this.label9);
            this.panModel.Controls.Add(this.edModelWidth);
            this.panModel.Controls.Add(this.label8);
            this.panModel.Controls.Add(this.cbKeepAspect);
            this.panModel.Controls.Add(this.butZ90);
            this.panModel.Controls.Add(this.label7);
            this.panModel.Controls.Add(this.edPlane);
            this.panModel.Controls.Add(this.butY90);
            this.panModel.Controls.Add(this.butX90);
            this.panModel.Controls.Add(this.label6);
            this.panModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panModel.Location = new System.Drawing.Point(0, 321);
            this.panModel.Name = "panModel";
            this.panModel.Size = new System.Drawing.Size(237, 600);
            this.panModel.TabIndex = 1;
            this.panModel.SizeChanged += new System.EventHandler(this.panModel_SizeChanged);
            // 
            // cbSolidLayer
            // 
            this.cbSolidLayer.AutoSize = true;
            this.cbSolidLayer.Location = new System.Drawing.Point(17, 564);
            this.cbSolidLayer.Name = "cbSolidLayer";
            this.cbSolidLayer.Size = new System.Drawing.Size(133, 21);
            this.cbSolidLayer.TabIndex = 72;
            this.cbSolidLayer.Text = "Сплошной слой";
            this.cbSolidLayer.UseVisualStyleBackColor = true;
            this.cbSolidLayer.CheckedChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // cbInnerPerimeter
            // 
            this.cbInnerPerimeter.AutoSize = true;
            this.cbInnerPerimeter.Location = new System.Drawing.Point(16, 532);
            this.cbInnerPerimeter.Name = "cbInnerPerimeter";
            this.cbInnerPerimeter.Size = new System.Drawing.Size(87, 21);
            this.cbInnerPerimeter.TabIndex = 71;
            this.cbInnerPerimeter.Text = "Обводка";
            this.cbInnerPerimeter.UseVisualStyleBackColor = true;
            this.cbInnerPerimeter.CheckedChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 70;
            this.label14.Text = "Сечение";
            // 
            // edPositionY
            // 
            this.edPositionY.DecimalPlaces = 1;
            this.edPositionY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edPositionY.Location = new System.Drawing.Point(87, 391);
            this.edPositionY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edPositionY.Name = "edPositionY";
            this.edPositionY.Size = new System.Drawing.Size(72, 22);
            this.edPositionY.TabIndex = 69;
            this.edPositionY.ValueChanged += new System.EventHandler(this.edPositionY_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Y (мм):";
            // 
            // edPositionX
            // 
            this.edPositionX.DecimalPlaces = 1;
            this.edPositionX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edPositionX.Location = new System.Drawing.Point(87, 363);
            this.edPositionX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edPositionX.Name = "edPositionX";
            this.edPositionX.Size = new System.Drawing.Size(72, 22);
            this.edPositionX.TabIndex = 67;
            this.edPositionX.ValueChanged += new System.EventHandler(this.edPositionX_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "X (мм):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Позиция";
            // 
            // butAutoScaling
            // 
            this.butAutoScaling.Location = new System.Drawing.Point(97, 285);
            this.butAutoScaling.Name = "butAutoScaling";
            this.butAutoScaling.Size = new System.Drawing.Size(75, 28);
            this.butAutoScaling.TabIndex = 64;
            this.butAutoScaling.Text = "Авто";
            this.butAutoScaling.UseVisualStyleBackColor = true;
            this.butAutoScaling.Click += new System.EventHandler(this.butAutoScaling_Click);
            // 
            // butResetScaling
            // 
            this.butResetScaling.Location = new System.Drawing.Point(16, 285);
            this.butResetScaling.Name = "butResetScaling";
            this.butResetScaling.Size = new System.Drawing.Size(75, 28);
            this.butResetScaling.TabIndex = 63;
            this.butResetScaling.Text = "100%";
            this.butResetScaling.UseVisualStyleBackColor = true;
            this.butResetScaling.Click += new System.EventHandler(this.butResetScaling_Click);
            // 
            // edScaleZ
            // 
            this.edScaleZ.DecimalPlaces = 2;
            this.edScaleZ.Location = new System.Drawing.Point(165, 210);
            this.edScaleZ.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edScaleZ.Name = "edScaleZ";
            this.edScaleZ.Size = new System.Drawing.Size(72, 22);
            this.edScaleZ.TabIndex = 62;
            this.edScaleZ.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edScaleZ.ValueChanged += new System.EventHandler(this.edScaleZ_ValueChanged);
            // 
            // edScaleY
            // 
            this.edScaleY.DecimalPlaces = 2;
            this.edScaleY.Location = new System.Drawing.Point(165, 182);
            this.edScaleY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edScaleY.Name = "edScaleY";
            this.edScaleY.Size = new System.Drawing.Size(72, 22);
            this.edScaleY.TabIndex = 61;
            this.edScaleY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edScaleY.ValueChanged += new System.EventHandler(this.edScaleY_ValueChanged);
            // 
            // edScaleX
            // 
            this.edScaleX.DecimalPlaces = 2;
            this.edScaleX.Location = new System.Drawing.Point(165, 154);
            this.edScaleX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edScaleX.Name = "edScaleX";
            this.edScaleX.Size = new System.Drawing.Size(72, 22);
            this.edScaleX.TabIndex = 60;
            this.edScaleX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edScaleX.ValueChanged += new System.EventHandler(this.edScaleX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Масштабирование";
            // 
            // edModelHeight
            // 
            this.edModelHeight.DecimalPlaces = 1;
            this.edModelHeight.Location = new System.Drawing.Point(87, 210);
            this.edModelHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edModelHeight.Name = "edModelHeight";
            this.edModelHeight.Size = new System.Drawing.Size(72, 22);
            this.edModelHeight.TabIndex = 58;
            this.edModelHeight.ValueChanged += new System.EventHandler(this.edModelHeight_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Z (мм,%):";
            // 
            // edModelDepth
            // 
            this.edModelDepth.DecimalPlaces = 1;
            this.edModelDepth.Location = new System.Drawing.Point(87, 182);
            this.edModelDepth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edModelDepth.Name = "edModelDepth";
            this.edModelDepth.Size = new System.Drawing.Size(72, 22);
            this.edModelDepth.TabIndex = 56;
            this.edModelDepth.ValueChanged += new System.EventHandler(this.edModelDepth_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Y (мм,%):";
            // 
            // edModelWidth
            // 
            this.edModelWidth.DecimalPlaces = 1;
            this.edModelWidth.Location = new System.Drawing.Point(87, 154);
            this.edModelWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edModelWidth.Name = "edModelWidth";
            this.edModelWidth.Size = new System.Drawing.Size(72, 22);
            this.edModelWidth.TabIndex = 54;
            this.edModelWidth.ValueChanged += new System.EventHandler(this.edModelWidth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "X (мм,%):";
            // 
            // cbKeepAspect
            // 
            this.cbKeepAspect.AutoSize = true;
            this.cbKeepAspect.Checked = true;
            this.cbKeepAspect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKeepAspect.Location = new System.Drawing.Point(20, 249);
            this.cbKeepAspect.Name = "cbKeepAspect";
            this.cbKeepAspect.Size = new System.Drawing.Size(151, 21);
            this.cbKeepAspect.TabIndex = 52;
            this.cbKeepAspect.Text = "Пропорционально";
            this.cbKeepAspect.UseVisualStyleBackColor = true;
            this.cbKeepAspect.CheckedChanged += new System.EventHandler(this.cbKeepAspect_CheckedChanged);
            // 
            // butZ90
            // 
            this.butZ90.Location = new System.Drawing.Point(170, 73);
            this.butZ90.Name = "butZ90";
            this.butZ90.Size = new System.Drawing.Size(71, 28);
            this.butZ90.TabIndex = 51;
            this.butZ90.Text = "Z";
            this.butZ90.UseVisualStyleBackColor = true;
            this.butZ90.Click += new System.EventHandler(this.butZ90_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Повернуть на 90° вокруг оси:";
            // 
            // edPlane
            // 
            this.edPlane.Location = new System.Drawing.Point(3, 461);
            this.edPlane.Maximum = 100;
            this.edPlane.Name = "edPlane";
            this.edPlane.Size = new System.Drawing.Size(234, 56);
            this.edPlane.TabIndex = 49;
            this.edPlane.TickFrequency = 5;
            this.edPlane.Value = 100;
            this.edPlane.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // butY90
            // 
            this.butY90.Location = new System.Drawing.Point(93, 73);
            this.butY90.Name = "butY90";
            this.butY90.Size = new System.Drawing.Size(71, 28);
            this.butY90.TabIndex = 48;
            this.butY90.Text = "Y";
            this.butY90.UseVisualStyleBackColor = true;
            this.butY90.Click += new System.EventHandler(this.butY90_Click);
            // 
            // butX90
            // 
            this.butX90.Location = new System.Drawing.Point(16, 73);
            this.butX90.Name = "butX90";
            this.butX90.Size = new System.Drawing.Size(71, 28);
            this.butX90.TabIndex = 47;
            this.butX90.Text = "X";
            this.butX90.UseVisualStyleBackColor = true;
            this.butX90.Click += new System.EventHandler(this.butX90_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.label6.Size = new System.Drawing.Size(237, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Модель";
            // 
            // panDisplay
            // 
            this.panDisplay.Controls.Add(this.cbWireframe);
            this.panDisplay.Controls.Add(this.butReset);
            this.panDisplay.Controls.Add(this.edDistance);
            this.panDisplay.Controls.Add(this.label3);
            this.panDisplay.Controls.Add(this.edRotationZ);
            this.panDisplay.Controls.Add(this.label2);
            this.panDisplay.Controls.Add(this.edRotationX);
            this.panDisplay.Controls.Add(this.label1);
            this.panDisplay.Controls.Add(this.label5);
            this.panDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDisplay.Location = new System.Drawing.Point(0, 0);
            this.panDisplay.Name = "panDisplay";
            this.panDisplay.Size = new System.Drawing.Size(237, 321);
            this.panDisplay.TabIndex = 0;
            this.panDisplay.SizeChanged += new System.EventHandler(this.panDisplay_SizeChanged);
            // 
            // cbWireframe
            // 
            this.cbWireframe.AutoSize = true;
            this.cbWireframe.Location = new System.Drawing.Point(124, 281);
            this.cbWireframe.Margin = new System.Windows.Forms.Padding(4);
            this.cbWireframe.Name = "cbWireframe";
            this.cbWireframe.Size = new System.Drawing.Size(77, 21);
            this.cbWireframe.TabIndex = 54;
            this.cbWireframe.Text = "Каркас";
            this.cbWireframe.UseVisualStyleBackColor = true;
            this.cbWireframe.Click += new System.EventHandler(this.OnValueChanged);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(16, 276);
            this.butReset.Margin = new System.Windows.Forms.Padding(4);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(100, 28);
            this.butReset.TabIndex = 53;
            this.butReset.Text = "Сброс";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // edDistance
            // 
            this.edDistance.Location = new System.Drawing.Point(3, 213);
            this.edDistance.Maximum = 60;
            this.edDistance.Minimum = 5;
            this.edDistance.Name = "edDistance";
            this.edDistance.Size = new System.Drawing.Size(245, 56);
            this.edDistance.TabIndex = 52;
            this.edDistance.TickFrequency = 5;
            this.edDistance.Value = 30;
            this.edDistance.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Дистанция:";
            // 
            // edRotationZ
            // 
            this.edRotationZ.Location = new System.Drawing.Point(3, 134);
            this.edRotationZ.Maximum = 180;
            this.edRotationZ.Minimum = -180;
            this.edRotationZ.Name = "edRotationZ";
            this.edRotationZ.Size = new System.Drawing.Size(245, 56);
            this.edRotationZ.TabIndex = 50;
            this.edRotationZ.TickFrequency = 20;
            this.edRotationZ.Value = 40;
            this.edRotationZ.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Поворот вокруг оси Z:";
            // 
            // edRotationX
            // 
            this.edRotationX.Location = new System.Drawing.Point(3, 55);
            this.edRotationX.Maximum = 90;
            this.edRotationX.Minimum = 1;
            this.edRotationX.Name = "edRotationX";
            this.edRotationX.Size = new System.Drawing.Size(245, 56);
            this.edRotationX.TabIndex = 48;
            this.edRotationX.TickFrequency = 5;
            this.edRotationX.Value = 45;
            this.edRotationX.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Поворот вокруг оси X:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.label5.Size = new System.Drawing.Size(237, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Просмотр";
            // 
            // mnuFileGenerateGCode
            // 
            this.mnuFileGenerateGCode.Name = "mnuFileGenerateGCode";
            this.mnuFileGenerateGCode.Size = new System.Drawing.Size(254, 26);
            this.mnuFileGenerateGCode.Text = "Сгенерировать G-Code...";
            this.mnuFileGenerateGCode.Click += new System.EventHandler(this.mnuFileGenerateGCode_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "gcode";
            this.saveFileDialog1.Filter = "Файлы G-Code *.gcode|*.gcode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 583);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Слайсер";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panModel.ResumeLayout(false);
            this.panModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edScaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edModelHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edModelDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edModelWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPlane)).EndInit();
            this.panDisplay.ResumeLayout(false);
            this.panDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRotationZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRotationX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuOptionsSettings;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Panel panDisplay;
        private System.Windows.Forms.CheckBox cbWireframe;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.TrackBar edDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar edRotationZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar edRotationX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panModel;
        private System.Windows.Forms.TrackBar edPlane;
        private System.Windows.Forms.Button butY90;
        private System.Windows.Forms.Button butX90;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butZ90;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown edModelHeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown edModelDepth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown edModelWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbKeepAspect;
        private System.Windows.Forms.Button butAutoScaling;
        private System.Windows.Forms.Button butResetScaling;
        private System.Windows.Forms.NumericUpDown edScaleZ;
        private System.Windows.Forms.NumericUpDown edScaleY;
        private System.Windows.Forms.NumericUpDown edScaleX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edPositionY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown edPositionX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbSolidLayer;
        private System.Windows.Forms.CheckBox cbInnerPerimeter;
        private System.Windows.Forms.ToolStripMenuItem mnuFileGenerateGCode;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

