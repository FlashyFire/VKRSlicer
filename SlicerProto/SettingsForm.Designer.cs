namespace SlicerProto
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrinter = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.edSpeedE = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.edSpeedZ = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.edSpeedXYSlow = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.edSpeedXYFast = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.edFanSpeed = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.cbUseFan = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.edTableTemperature = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.cbTableHeating = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edRetract = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.edFilamentRate = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.edExtruderTemperature = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.edExtruderDiameter = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edHomePositionY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.edHomePositionX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edBuildAreaSizeZ = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.edBuildAreaSizeY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.edBuildAreaSizeX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSlice = new System.Windows.Forms.TabPage();
            this.edFlattenTolerance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFlatten = new System.Windows.Forms.CheckBox();
            this.edSimplifyDistance = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.edSliceHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageFill = new System.Windows.Forms.TabPage();
            this.edSolidLayerCount = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.cbFillLocation = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.edPercentage = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.edCrossAngleInDegrees = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.edAngleInDegrees = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLayerByLayer = new System.Windows.Forms.CheckBox();
            this.cbFillType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageSkirt = new System.Windows.Forms.TabPage();
            this.edSkirtStep = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.edSkirtCount = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.edSkirtDistance = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.cbPrintSkirt = new System.Windows.Forms.CheckBox();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.colorModel = new SlicerProto.ColorPicker();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.edFillLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.colorFill = new SlicerProto.ColorPicker();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.edSliceLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.colorSlice = new SlicerProto.ColorPicker();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.edMajorGridlineFactor = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.cbShowAxes = new System.Windows.Forms.CheckBox();
            this.cbShowBuildArea = new System.Windows.Forms.CheckBox();
            this.colorAxes = new SlicerProto.ColorPicker();
            this.label17 = new System.Windows.Forms.Label();
            this.colorMinorGridlines = new SlicerProto.ColorPicker();
            this.label16 = new System.Windows.Forms.Label();
            this.colorMajorGridlines = new SlicerProto.ColorPicker();
            this.label15 = new System.Windows.Forms.Label();
            this.colorBuildAreaLine = new SlicerProto.ColorPicker();
            this.label14 = new System.Windows.Forms.Label();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.edSliceOffset = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePrinter.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeedE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeedZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeedXYSlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeedXYFast)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edFanSpeed)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTableTemperature)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRetract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFilamentRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edExtruderTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edExtruderDiameter)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edHomePositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHomePositionX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edBuildAreaSizeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBuildAreaSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBuildAreaSizeX)).BeginInit();
            this.tabPageSlice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edFlattenTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSimplifyDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSliceHeight)).BeginInit();
            this.tabPageFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSolidLayerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCrossAngleInDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngleInDegrees)).BeginInit();
            this.tabPageSkirt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSkirtStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSkirtCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSkirtDistance)).BeginInit();
            this.tabPageView.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edFillLineWidth)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSliceLineWidth)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edMajorGridlineFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSliceOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrinter);
            this.tabControl1.Controls.Add(this.tabPageSlice);
            this.tabControl1.Controls.Add(this.tabPageFill);
            this.tabControl1.Controls.Add(this.tabPageSkirt);
            this.tabControl1.Controls.Add(this.tabPageView);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePrinter
            // 
            this.tabPagePrinter.Controls.Add(this.groupBox9);
            this.tabPagePrinter.Controls.Add(this.groupBox8);
            this.tabPagePrinter.Controls.Add(this.groupBox7);
            this.tabPagePrinter.Controls.Add(this.groupBox3);
            this.tabPagePrinter.Controls.Add(this.groupBox2);
            this.tabPagePrinter.Controls.Add(this.groupBox1);
            this.tabPagePrinter.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrinter.Name = "tabPagePrinter";
            this.tabPagePrinter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrinter.Size = new System.Drawing.Size(898, 363);
            this.tabPagePrinter.TabIndex = 0;
            this.tabPagePrinter.Text = "Принтер";
            this.tabPagePrinter.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.edSpeedE);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.edSpeedZ);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Controls.Add(this.edSpeedXYSlow);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.edSpeedXYFast);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Location = new System.Drawing.Point(602, 17);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(279, 192);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Скорость (мм/мин):";
            // 
            // edSpeedE
            // 
            this.edSpeedE.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edSpeedE.Location = new System.Drawing.Point(179, 153);
            this.edSpeedE.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edSpeedE.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edSpeedE.Name = "edSpeedE";
            this.edSpeedE.Size = new System.Drawing.Size(78, 22);
            this.edSpeedE.TabIndex = 9;
            this.edSpeedE.Value = new decimal(new int[] {
            4800,
            0,
            0,
            0});
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(19, 156);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(21, 17);
            this.label32.TabIndex = 8;
            this.label32.Text = "E:";
            // 
            // edSpeedZ
            // 
            this.edSpeedZ.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edSpeedZ.Location = new System.Drawing.Point(179, 113);
            this.edSpeedZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edSpeedZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edSpeedZ.Name = "edSpeedZ";
            this.edSpeedZ.Size = new System.Drawing.Size(78, 22);
            this.edSpeedZ.TabIndex = 7;
            this.edSpeedZ.Value = new decimal(new int[] {
            1002,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(19, 116);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 17);
            this.label31.TabIndex = 6;
            this.label31.Text = "Z:";
            // 
            // edSpeedXYSlow
            // 
            this.edSpeedXYSlow.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edSpeedXYSlow.Location = new System.Drawing.Point(179, 72);
            this.edSpeedXYSlow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edSpeedXYSlow.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edSpeedXYSlow.Name = "edSpeedXYSlow";
            this.edSpeedXYSlow.Size = new System.Drawing.Size(78, 22);
            this.edSpeedXYSlow.TabIndex = 5;
            this.edSpeedXYSlow.Value = new decimal(new int[] {
            1134,
            0,
            0,
            0});
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 75);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(103, 17);
            this.label30.TabIndex = 4;
            this.label30.Text = "X/Y медленно:";
            // 
            // edSpeedXYFast
            // 
            this.edSpeedXYFast.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edSpeedXYFast.Location = new System.Drawing.Point(179, 30);
            this.edSpeedXYFast.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edSpeedXYFast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edSpeedXYFast.Name = "edSpeedXYFast";
            this.edSpeedXYFast.Size = new System.Drawing.Size(78, 22);
            this.edSpeedXYFast.TabIndex = 3;
            this.edSpeedXYFast.Value = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 33);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 17);
            this.label29.TabIndex = 2;
            this.label29.Text = "X/Y быстро:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.edFanSpeed);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.cbUseFan);
            this.groupBox8.Location = new System.Drawing.Point(602, 217);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(279, 114);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Охлаждение:";
            // 
            // edFanSpeed
            // 
            this.edFanSpeed.Location = new System.Drawing.Point(177, 72);
            this.edFanSpeed.Name = "edFanSpeed";
            this.edFanSpeed.Size = new System.Drawing.Size(78, 22);
            this.edFanSpeed.TabIndex = 13;
            this.edFanSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(17, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 17);
            this.label26.TabIndex = 12;
            this.label26.Text = "Скорость (%):";
            // 
            // cbUseFan
            // 
            this.cbUseFan.AutoSize = true;
            this.cbUseFan.Location = new System.Drawing.Point(17, 33);
            this.cbUseFan.Name = "cbUseFan";
            this.cbUseFan.Size = new System.Drawing.Size(109, 21);
            this.cbUseFan.TabIndex = 11;
            this.cbUseFan.Text = "Вентилятор";
            this.cbUseFan.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.edTableTemperature);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.cbTableHeating);
            this.groupBox7.Location = new System.Drawing.Point(311, 217);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(279, 114);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Стол:";
            // 
            // edTableTemperature
            // 
            this.edTableTemperature.DecimalPlaces = 1;
            this.edTableTemperature.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.edTableTemperature.Location = new System.Drawing.Point(177, 68);
            this.edTableTemperature.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edTableTemperature.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.edTableTemperature.Name = "edTableTemperature";
            this.edTableTemperature.Size = new System.Drawing.Size(78, 22);
            this.edTableTemperature.TabIndex = 9;
            this.edTableTemperature.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 70);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 17);
            this.label25.TabIndex = 8;
            this.label25.Text = "Температура:";
            // 
            // cbTableHeating
            // 
            this.cbTableHeating.AutoSize = true;
            this.cbTableHeating.Location = new System.Drawing.Point(20, 34);
            this.cbTableHeating.Name = "cbTableHeating";
            this.cbTableHeating.Size = new System.Drawing.Size(92, 21);
            this.cbTableHeating.TabIndex = 0;
            this.cbTableHeating.Text = "Подогрев";
            this.cbTableHeating.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edRetract);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.edFilamentRate);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.edExtruderTemperature);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.edExtruderDiameter);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(311, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 192);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Экструдер:";
            // 
            // edRetract
            // 
            this.edRetract.DecimalPlaces = 1;
            this.edRetract.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edRetract.Location = new System.Drawing.Point(177, 150);
            this.edRetract.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edRetract.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edRetract.Name = "edRetract";
            this.edRetract.Size = new System.Drawing.Size(78, 22);
            this.edRetract.TabIndex = 11;
            this.edRetract.Value = new decimal(new int[] {
            57,
            0,
            0,
            65536});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(17, 153);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 17);
            this.label28.TabIndex = 10;
            this.label28.Text = "Ретракт (мм):";
            // 
            // edFilamentRate
            // 
            this.edFilamentRate.DecimalPlaces = 3;
            this.edFilamentRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.edFilamentRate.Location = new System.Drawing.Point(177, 110);
            this.edFilamentRate.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.edFilamentRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.edFilamentRate.Name = "edFilamentRate";
            this.edFilamentRate.Size = new System.Drawing.Size(78, 22);
            this.edFilamentRate.TabIndex = 9;
            this.edFilamentRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(17, 113);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(118, 17);
            this.label27.TabIndex = 8;
            this.label27.Text = "Коэффициент E:";
            // 
            // edExtruderTemperature
            // 
            this.edExtruderTemperature.DecimalPlaces = 1;
            this.edExtruderTemperature.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.edExtruderTemperature.Location = new System.Drawing.Point(177, 71);
            this.edExtruderTemperature.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.edExtruderTemperature.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.edExtruderTemperature.Name = "edExtruderTemperature";
            this.edExtruderTemperature.Size = new System.Drawing.Size(78, 22);
            this.edExtruderTemperature.TabIndex = 7;
            this.edExtruderTemperature.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 17);
            this.label24.TabIndex = 6;
            this.label24.Text = "Температура:";
            // 
            // edExtruderDiameter
            // 
            this.edExtruderDiameter.DecimalPlaces = 2;
            this.edExtruderDiameter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edExtruderDiameter.Location = new System.Drawing.Point(177, 32);
            this.edExtruderDiameter.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.edExtruderDiameter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edExtruderDiameter.Name = "edExtruderDiameter";
            this.edExtruderDiameter.Size = new System.Drawing.Size(78, 22);
            this.edExtruderDiameter.TabIndex = 5;
            this.edExtruderDiameter.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Диаметр сопла (мм):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edHomePositionY);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.edHomePositionX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Домашняя позиция:";
            // 
            // edHomePositionY
            // 
            this.edHomePositionY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edHomePositionY.Location = new System.Drawing.Point(177, 71);
            this.edHomePositionY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edHomePositionY.Name = "edHomePositionY";
            this.edHomePositionY.Size = new System.Drawing.Size(78, 22);
            this.edHomePositionY.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y (мм):";
            // 
            // edHomePositionX
            // 
            this.edHomePositionX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edHomePositionX.Location = new System.Drawing.Point(177, 31);
            this.edHomePositionX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edHomePositionX.Name = "edHomePositionX";
            this.edHomePositionX.Size = new System.Drawing.Size(78, 22);
            this.edHomePositionX.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "X (мм):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edBuildAreaSizeZ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edBuildAreaSizeY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edBuildAreaSizeX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рабочая область принтера:";
            // 
            // edBuildAreaSizeZ
            // 
            this.edBuildAreaSizeZ.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edBuildAreaSizeZ.Location = new System.Drawing.Point(177, 113);
            this.edBuildAreaSizeZ.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edBuildAreaSizeZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edBuildAreaSizeZ.Name = "edBuildAreaSizeZ";
            this.edBuildAreaSizeZ.Size = new System.Drawing.Size(78, 22);
            this.edBuildAreaSizeZ.TabIndex = 5;
            this.edBuildAreaSizeZ.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Высота (мм):";
            // 
            // edBuildAreaSizeY
            // 
            this.edBuildAreaSizeY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edBuildAreaSizeY.Location = new System.Drawing.Point(177, 72);
            this.edBuildAreaSizeY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edBuildAreaSizeY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edBuildAreaSizeY.Name = "edBuildAreaSizeY";
            this.edBuildAreaSizeY.Size = new System.Drawing.Size(78, 22);
            this.edBuildAreaSizeY.TabIndex = 3;
            this.edBuildAreaSizeY.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Глубина (мм):";
            // 
            // edBuildAreaSizeX
            // 
            this.edBuildAreaSizeX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edBuildAreaSizeX.Location = new System.Drawing.Point(177, 30);
            this.edBuildAreaSizeX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edBuildAreaSizeX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edBuildAreaSizeX.Name = "edBuildAreaSizeX";
            this.edBuildAreaSizeX.Size = new System.Drawing.Size(78, 22);
            this.edBuildAreaSizeX.TabIndex = 1;
            this.edBuildAreaSizeX.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина (мм):";
            // 
            // tabPageSlice
            // 
            this.tabPageSlice.Controls.Add(this.edSliceOffset);
            this.tabPageSlice.Controls.Add(this.label38);
            this.tabPageSlice.Controls.Add(this.edFlattenTolerance);
            this.tabPageSlice.Controls.Add(this.label9);
            this.tabPageSlice.Controls.Add(this.cbFlatten);
            this.tabPageSlice.Controls.Add(this.edSimplifyDistance);
            this.tabPageSlice.Controls.Add(this.label8);
            this.tabPageSlice.Controls.Add(this.edSliceHeight);
            this.tabPageSlice.Controls.Add(this.label7);
            this.tabPageSlice.Location = new System.Drawing.Point(4, 25);
            this.tabPageSlice.Name = "tabPageSlice";
            this.tabPageSlice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSlice.Size = new System.Drawing.Size(898, 363);
            this.tabPageSlice.TabIndex = 1;
            this.tabPageSlice.Text = "Слой";
            this.tabPageSlice.UseVisualStyleBackColor = true;
            // 
            // edFlattenTolerance
            // 
            this.edFlattenTolerance.DecimalPlaces = 3;
            this.edFlattenTolerance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.edFlattenTolerance.Location = new System.Drawing.Point(268, 196);
            this.edFlattenTolerance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edFlattenTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.edFlattenTolerance.Name = "edFlattenTolerance";
            this.edFlattenTolerance.Size = new System.Drawing.Size(78, 22);
            this.edFlattenTolerance.TabIndex = 12;
            this.edFlattenTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Допуск исключения вершин (мм):";
            // 
            // cbFlatten
            // 
            this.cbFlatten.AutoSize = true;
            this.cbFlatten.Location = new System.Drawing.Point(24, 158);
            this.cbFlatten.Name = "cbFlatten";
            this.cbFlatten.Size = new System.Drawing.Size(166, 21);
            this.cbFlatten.TabIndex = 10;
            this.cbFlatten.Text = "Исключать вершины";
            this.cbFlatten.UseVisualStyleBackColor = true;
            // 
            // edSimplifyDistance
            // 
            this.edSimplifyDistance.DecimalPlaces = 4;
            this.edSimplifyDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.edSimplifyDistance.Location = new System.Drawing.Point(268, 112);
            this.edSimplifyDistance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edSimplifyDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.edSimplifyDistance.Name = "edSimplifyDistance";
            this.edSimplifyDistance.Size = new System.Drawing.Size(78, 22);
            this.edSimplifyDistance.TabIndex = 9;
            this.edSimplifyDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Допуск упрощения контура (мм):";
            // 
            // edSliceHeight
            // 
            this.edSliceHeight.DecimalPlaces = 2;
            this.edSliceHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edSliceHeight.Location = new System.Drawing.Point(268, 24);
            this.edSliceHeight.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edSliceHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edSliceHeight.Name = "edSliceHeight";
            this.edSliceHeight.Size = new System.Drawing.Size(78, 22);
            this.edSliceHeight.TabIndex = 7;
            this.edSliceHeight.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Толщина слоя (мм):";
            // 
            // tabPageFill
            // 
            this.tabPageFill.Controls.Add(this.edSolidLayerCount);
            this.tabPageFill.Controls.Add(this.label37);
            this.tabPageFill.Controls.Add(this.cbFillLocation);
            this.tabPageFill.Controls.Add(this.label36);
            this.tabPageFill.Controls.Add(this.edPercentage);
            this.tabPageFill.Controls.Add(this.label13);
            this.tabPageFill.Controls.Add(this.edCrossAngleInDegrees);
            this.tabPageFill.Controls.Add(this.label12);
            this.tabPageFill.Controls.Add(this.edAngleInDegrees);
            this.tabPageFill.Controls.Add(this.label11);
            this.tabPageFill.Controls.Add(this.cbLayerByLayer);
            this.tabPageFill.Controls.Add(this.cbFillType);
            this.tabPageFill.Controls.Add(this.label10);
            this.tabPageFill.Location = new System.Drawing.Point(4, 25);
            this.tabPageFill.Name = "tabPageFill";
            this.tabPageFill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFill.Size = new System.Drawing.Size(898, 363);
            this.tabPageFill.TabIndex = 2;
            this.tabPageFill.Text = "Заполнение";
            this.tabPageFill.UseVisualStyleBackColor = true;
            // 
            // edSolidLayerCount
            // 
            this.edSolidLayerCount.Location = new System.Drawing.Point(260, 300);
            this.edSolidLayerCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edSolidLayerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edSolidLayerCount.Name = "edSolidLayerCount";
            this.edSolidLayerCount.Size = new System.Drawing.Size(85, 22);
            this.edSolidLayerCount.TabIndex = 10;
            this.edSolidLayerCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(25, 300);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(122, 17);
            this.label37.TabIndex = 11;
            this.label37.Text = "Сплошных слоев:";
            // 
            // cbFillLocation
            // 
            this.cbFillLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillLocation.FormattingEnabled = true;
            this.cbFillLocation.Items.AddRange(new object[] {
            "Внешний периметр",
            "Внутренний периметр",
            "Внутри периметров"});
            this.cbFillLocation.Location = new System.Drawing.Point(260, 254);
            this.cbFillLocation.Name = "cbFillLocation";
            this.cbFillLocation.Size = new System.Drawing.Size(179, 24);
            this.cbFillLocation.TabIndex = 9;
            this.cbFillLocation.SelectedIndexChanged += new System.EventHandler(this.cbFillLocation_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(21, 257);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(192, 17);
            this.label36.TabIndex = 8;
            this.label36.Text = "Расположение заполнения:";
            // 
            // edPercentage
            // 
            this.edPercentage.Location = new System.Drawing.Point(260, 118);
            this.edPercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edPercentage.Name = "edPercentage";
            this.edPercentage.Size = new System.Drawing.Size(85, 22);
            this.edPercentage.TabIndex = 4;
            this.edPercentage.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Процент заполнения:";
            // 
            // edCrossAngleInDegrees
            // 
            this.edCrossAngleInDegrees.Location = new System.Drawing.Point(260, 209);
            this.edCrossAngleInDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.edCrossAngleInDegrees.Name = "edCrossAngleInDegrees";
            this.edCrossAngleInDegrees.Size = new System.Drawing.Size(85, 22);
            this.edCrossAngleInDegrees.TabIndex = 6;
            this.edCrossAngleInDegrees.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Угол пересечения (градусы):";
            // 
            // edAngleInDegrees
            // 
            this.edAngleInDegrees.Location = new System.Drawing.Point(260, 164);
            this.edAngleInDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.edAngleInDegrees.Name = "edAngleInDegrees";
            this.edAngleInDegrees.Size = new System.Drawing.Size(85, 22);
            this.edAngleInDegrees.TabIndex = 5;
            this.edAngleInDegrees.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Угол (градусы):";
            // 
            // cbLayerByLayer
            // 
            this.cbLayerByLayer.AutoSize = true;
            this.cbLayerByLayer.Location = new System.Drawing.Point(24, 76);
            this.cbLayerByLayer.Name = "cbLayerByLayer";
            this.cbLayerByLayer.Size = new System.Drawing.Size(92, 21);
            this.cbLayerByLayer.TabIndex = 2;
            this.cbLayerByLayer.Text = "По слоям";
            this.cbLayerByLayer.UseVisualStyleBackColor = true;
            // 
            // cbFillType
            // 
            this.cbFillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillType.FormattingEnabled = true;
            this.cbFillType.Items.AddRange(new object[] {
            "Линии",
            "Крест-на-крест",
            "Треугольники"});
            this.cbFillType.Location = new System.Drawing.Point(260, 30);
            this.cbFillType.Name = "cbFillType";
            this.cbFillType.Size = new System.Drawing.Size(179, 24);
            this.cbFillType.TabIndex = 1;
            this.cbFillType.SelectedIndexChanged += new System.EventHandler(this.cbFillType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Тип заполнения:";
            // 
            // tabPageSkirt
            // 
            this.tabPageSkirt.Controls.Add(this.edSkirtStep);
            this.tabPageSkirt.Controls.Add(this.label35);
            this.tabPageSkirt.Controls.Add(this.edSkirtCount);
            this.tabPageSkirt.Controls.Add(this.label34);
            this.tabPageSkirt.Controls.Add(this.edSkirtDistance);
            this.tabPageSkirt.Controls.Add(this.label33);
            this.tabPageSkirt.Controls.Add(this.cbPrintSkirt);
            this.tabPageSkirt.Location = new System.Drawing.Point(4, 25);
            this.tabPageSkirt.Name = "tabPageSkirt";
            this.tabPageSkirt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSkirt.Size = new System.Drawing.Size(898, 363);
            this.tabPageSkirt.TabIndex = 4;
            this.tabPageSkirt.Text = "Скирт";
            this.tabPageSkirt.UseVisualStyleBackColor = true;
            // 
            // edSkirtStep
            // 
            this.edSkirtStep.DecimalPlaces = 1;
            this.edSkirtStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edSkirtStep.Location = new System.Drawing.Point(273, 109);
            this.edSkirtStep.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edSkirtStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edSkirtStep.Name = "edSkirtStep";
            this.edSkirtStep.Size = new System.Drawing.Size(78, 22);
            this.edSkirtStep.TabIndex = 26;
            this.edSkirtStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(26, 111);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(68, 17);
            this.label35.TabIndex = 25;
            this.label35.Text = "Шаг (мм):";
            // 
            // edSkirtCount
            // 
            this.edSkirtCount.Location = new System.Drawing.Point(273, 149);
            this.edSkirtCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edSkirtCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edSkirtCount.Name = "edSkirtCount";
            this.edSkirtCount.Size = new System.Drawing.Size(78, 22);
            this.edSkirtCount.TabIndex = 24;
            this.edSkirtCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(26, 151);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(154, 17);
            this.label34.TabIndex = 23;
            this.label34.Text = "Количество контуров:";
            // 
            // edSkirtDistance
            // 
            this.edSkirtDistance.Location = new System.Drawing.Point(273, 71);
            this.edSkirtDistance.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.edSkirtDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edSkirtDistance.Name = "edSkirtDistance";
            this.edSkirtDistance.Size = new System.Drawing.Size(78, 22);
            this.edSkirtDistance.TabIndex = 22;
            this.edSkirtDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(26, 73);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(117, 17);
            this.label33.TabIndex = 21;
            this.label33.Text = "Дистанция (мм):";
            // 
            // cbPrintSkirt
            // 
            this.cbPrintSkirt.AutoSize = true;
            this.cbPrintSkirt.Location = new System.Drawing.Point(29, 31);
            this.cbPrintSkirt.Name = "cbPrintSkirt";
            this.cbPrintSkirt.Size = new System.Drawing.Size(134, 21);
            this.cbPrintSkirt.TabIndex = 20;
            this.cbPrintSkirt.Text = "Печатать скирт";
            this.cbPrintSkirt.UseVisualStyleBackColor = true;
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.colorModel);
            this.tabPageView.Controls.Add(this.label23);
            this.tabPageView.Controls.Add(this.groupBox6);
            this.tabPageView.Controls.Add(this.groupBox5);
            this.tabPageView.Controls.Add(this.groupBox4);
            this.tabPageView.Location = new System.Drawing.Point(4, 25);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(898, 363);
            this.tabPageView.TabIndex = 3;
            this.tabPageView.Text = "Вид";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // colorModel
            // 
            this.colorModel.Color = ((OpenTK.Graphics.Color4)(resources.GetObject("colorModel.Color")));
            this.colorModel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorModel.Location = new System.Drawing.Point(604, 296);
            this.colorModel.Name = "colorModel";
            this.colorModel.Size = new System.Drawing.Size(97, 25);
            this.colorModel.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(402, 299);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 17);
            this.label23.TabIndex = 4;
            this.label23.Text = "Цвет пластика:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.edFillLineWidth);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.colorFill);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Location = new System.Drawing.Point(381, 156);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(341, 125);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Заполнение:";
            // 
            // edFillLineWidth
            // 
            this.edFillLineWidth.Location = new System.Drawing.Point(225, 76);
            this.edFillLineWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edFillLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edFillLineWidth.Name = "edFillLineWidth";
            this.edFillLineWidth.Size = new System.Drawing.Size(95, 22);
            this.edFillLineWidth.TabIndex = 12;
            this.edFillLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "Ширина линии:";
            // 
            // colorFill
            // 
            this.colorFill.Color = ((OpenTK.Graphics.Color4)(resources.GetObject("colorFill.Color")));
            this.colorFill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorFill.Location = new System.Drawing.Point(225, 29);
            this.colorFill.Name = "colorFill";
            this.colorFill.Size = new System.Drawing.Size(97, 25);
            this.colorFill.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 17);
            this.label22.TabIndex = 2;
            this.label22.Text = "Цвет линии:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.edSliceLineWidth);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.colorSlice);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(381, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 125);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Слой:";
            // 
            // edSliceLineWidth
            // 
            this.edSliceLineWidth.Location = new System.Drawing.Point(225, 76);
            this.edSliceLineWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edSliceLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edSliceLineWidth.Name = "edSliceLineWidth";
            this.edSliceLineWidth.Size = new System.Drawing.Size(95, 22);
            this.edSliceLineWidth.TabIndex = 12;
            this.edSliceLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Ширина линии:";
            // 
            // colorSlice
            // 
            this.colorSlice.Color = ((OpenTK.Graphics.Color4)(resources.GetObject("colorSlice.Color")));
            this.colorSlice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorSlice.Location = new System.Drawing.Point(225, 29);
            this.colorSlice.Name = "colorSlice";
            this.colorSlice.Size = new System.Drawing.Size(97, 25);
            this.colorSlice.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 17);
            this.label19.TabIndex = 2;
            this.label19.Text = "Цвет линии:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.edMajorGridlineFactor);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cbShowAxes);
            this.groupBox4.Controls.Add(this.cbShowBuildArea);
            this.groupBox4.Controls.Add(this.colorAxes);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.colorMinorGridlines);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.colorMajorGridlines);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.colorBuildAreaLine);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(16, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 321);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рабочая область:";
            // 
            // edMajorGridlineFactor
            // 
            this.edMajorGridlineFactor.Location = new System.Drawing.Point(222, 279);
            this.edMajorGridlineFactor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edMajorGridlineFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edMajorGridlineFactor.Name = "edMajorGridlineFactor";
            this.edMajorGridlineFactor.Size = new System.Drawing.Size(95, 22);
            this.edMajorGridlineFactor.TabIndex = 10;
            this.edMajorGridlineFactor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 17);
            this.label18.TabIndex = 11;
            this.label18.Text = "Шаг основной сетки:";
            // 
            // cbShowAxes
            // 
            this.cbShowAxes.AutoSize = true;
            this.cbShowAxes.Location = new System.Drawing.Point(21, 243);
            this.cbShowAxes.Name = "cbShowAxes";
            this.cbShowAxes.Size = new System.Drawing.Size(136, 21);
            this.cbShowAxes.TabIndex = 9;
            this.cbShowAxes.Text = "Показывать оси";
            this.cbShowAxes.UseVisualStyleBackColor = true;
            // 
            // cbShowBuildArea
            // 
            this.cbShowBuildArea.AutoSize = true;
            this.cbShowBuildArea.Location = new System.Drawing.Point(21, 216);
            this.cbShowBuildArea.Name = "cbShowBuildArea";
            this.cbShowBuildArea.Size = new System.Drawing.Size(286, 21);
            this.cbShowBuildArea.TabIndex = 8;
            this.cbShowBuildArea.Text = "Показывать границы рабочей области";
            this.cbShowBuildArea.UseVisualStyleBackColor = true;
            // 
            // colorAxes
            // 
            this.colorAxes.Color = ((OpenTK.Graphics.Color4)(resources.GetObject("colorAxes.Color")));
            this.colorAxes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorAxes.Location = new System.Drawing.Point(220, 171);
            this.colorAxes.Name = "colorAxes";
            this.colorAxes.Size = new System.Drawing.Size(97, 25);
            this.colorAxes.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Цвет осей:";
            // 
            // colorMinorGridlines
            // 
            this.colorMinorGridlines.Color = ((OpenTK.Graphics.Color4)(resources.GetObject("colorMinorGridlines.Color")));
            this.colorMinorGridlines.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorMinorGridlines.Location = new System.Drawing.Point(220, 125);
            this.colorMinorGridlines.Name = "colorMinorGridlines";
            this.colorMinorGridlines.Size = new System.Drawing.Size(97, 25);
            this.colorMinorGridlines.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Цвет доп. сетки:";
            // 
            // colorMajorGridlines
            // 
            this.colorMajorGridlines.Color = ((OpenTK.Graphics.Color4)(resources.GetObject("colorMajorGridlines.Color")));
            this.colorMajorGridlines.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorMajorGridlines.Location = new System.Drawing.Point(220, 79);
            this.colorMajorGridlines.Name = "colorMajorGridlines";
            this.colorMajorGridlines.Size = new System.Drawing.Size(97, 25);
            this.colorMajorGridlines.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Цвет основной сетки:";
            // 
            // colorBuildAreaLine
            // 
            this.colorBuildAreaLine.Color = ((OpenTK.Graphics.Color4)(resources.GetObject("colorBuildAreaLine.Color")));
            this.colorBuildAreaLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorBuildAreaLine.Location = new System.Drawing.Point(220, 33);
            this.colorBuildAreaLine.Name = "colorBuildAreaLine";
            this.colorBuildAreaLine.Size = new System.Drawing.Size(97, 25);
            this.colorBuildAreaLine.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Цвет границ:";
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(733, 419);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(88, 28);
            this.butOk.TabIndex = 1;
            this.butOk.Text = "OK";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(827, 419);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(88, 28);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(16, 419);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(88, 28);
            this.butReset.TabIndex = 3;
            this.butReset.Text = "Сброс";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // edSliceOffset
            // 
            this.edSliceOffset.DecimalPlaces = 2;
            this.edSliceOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edSliceOffset.Location = new System.Drawing.Point(268, 66);
            this.edSliceOffset.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edSliceOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.edSliceOffset.Name = "edSliceOffset";
            this.edSliceOffset.Size = new System.Drawing.Size(78, 22);
            this.edSliceOffset.TabIndex = 14;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(21, 68);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(173, 17);
            this.label38.TabIndex = 13;
            this.label38.Text = "Смещение по оси Z (мм):";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(931, 461);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrinter.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeedE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeedZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeedXYSlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeedXYFast)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edFanSpeed)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTableTemperature)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRetract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFilamentRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edExtruderTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edExtruderDiameter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edHomePositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHomePositionX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edBuildAreaSizeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBuildAreaSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBuildAreaSizeX)).EndInit();
            this.tabPageSlice.ResumeLayout(false);
            this.tabPageSlice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edFlattenTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSimplifyDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSliceHeight)).EndInit();
            this.tabPageFill.ResumeLayout(false);
            this.tabPageFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSolidLayerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCrossAngleInDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngleInDegrees)).EndInit();
            this.tabPageSkirt.ResumeLayout(false);
            this.tabPageSkirt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSkirtStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSkirtCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSkirtDistance)).EndInit();
            this.tabPageView.ResumeLayout(false);
            this.tabPageView.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edFillLineWidth)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSliceLineWidth)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edMajorGridlineFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSliceOffset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePrinter;
        private System.Windows.Forms.TabPage tabPageSlice;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TabPage tabPageFill;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown edBuildAreaSizeZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edBuildAreaSizeY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edBuildAreaSizeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown edHomePositionY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edHomePositionX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown edExtruderDiameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edSliceHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown edSimplifyDistance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbFlatten;
        private System.Windows.Forms.NumericUpDown edFlattenTolerance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFillType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbLayerByLayer;
        private System.Windows.Forms.NumericUpDown edAngleInDegrees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown edCrossAngleInDegrees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown edPercentage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private ColorPicker colorBuildAreaLine;
        private ColorPicker colorMajorGridlines;
        private System.Windows.Forms.Label label15;
        private ColorPicker colorMinorGridlines;
        private System.Windows.Forms.Label label16;
        private ColorPicker colorAxes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbShowAxes;
        private System.Windows.Forms.CheckBox cbShowBuildArea;
        private System.Windows.Forms.NumericUpDown edMajorGridlineFactor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown edSliceLineWidth;
        private System.Windows.Forms.Label label20;
        private ColorPicker colorSlice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown edFillLineWidth;
        private System.Windows.Forms.Label label21;
        private ColorPicker colorFill;
        private System.Windows.Forms.Label label22;
        private ColorPicker colorModel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown edTableTemperature;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox cbTableHeating;
        private System.Windows.Forms.NumericUpDown edExtruderTemperature;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown edFanSpeed;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cbUseFan;
        private System.Windows.Forms.NumericUpDown edRetract;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown edFilamentRate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown edSpeedE;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown edSpeedZ;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown edSpeedXYSlow;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown edSpeedXYFast;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tabPageSkirt;
        private System.Windows.Forms.NumericUpDown edSkirtStep;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown edSkirtCount;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown edSkirtDistance;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox cbPrintSkirt;
        private System.Windows.Forms.ComboBox cbFillLocation;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown edSolidLayerCount;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown edSliceOffset;
        private System.Windows.Forms.Label label38;
    }
}