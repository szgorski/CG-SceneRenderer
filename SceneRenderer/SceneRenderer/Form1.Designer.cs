
namespace SceneRenderer
{
    partial class SceneRenderer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelCaptions = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonLoadSettings = new System.Windows.Forms.Button();
            this.buttonApplyFigure = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelYRotation = new System.Windows.Forms.Label();
            this.labelXRotation = new System.Windows.Forms.Label();
            this.labelScene = new System.Windows.Forms.Label();
            this.trackBarDistance = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownDensity = new System.Windows.Forms.NumericUpDown();
            this.labelDensity = new System.Windows.Forms.Label();
            this.numericUpDownRotationZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRotationY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRotationX = new System.Windows.Forms.NumericUpDown();
            this.labelRotationZ = new System.Windows.Forms.Label();
            this.labelRotationY = new System.Windows.Forms.Label();
            this.labelRotationX = new System.Windows.Forms.Label();
            this.numericUpDownPositionZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPositionY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPositionX = new System.Windows.Forms.NumericUpDown();
            this.labelPositionZ = new System.Windows.Forms.Label();
            this.labelPositionY = new System.Windows.Forms.Label();
            this.labelPositionX = new System.Windows.Forms.Label();
            this.labelRotation = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.labelRadius = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.radioButtonCone = new System.Windows.Forms.RadioButton();
            this.radioButtonCyllinder = new System.Windows.Forms.RadioButton();
            this.radioButtonSphere = new System.Windows.Forms.RadioButton();
            this.radioButtonCuboid = new System.Windows.Forms.RadioButton();
            this.labelFigure = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(472, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(900, 900);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelCaptions);
            this.groupBox.Controls.Add(this.buttonSaveSettings);
            this.groupBox.Controls.Add(this.buttonLoadSettings);
            this.groupBox.Controls.Add(this.buttonApplyFigure);
            this.groupBox.Controls.Add(this.labelDistance);
            this.groupBox.Controls.Add(this.labelYRotation);
            this.groupBox.Controls.Add(this.labelXRotation);
            this.groupBox.Controls.Add(this.labelScene);
            this.groupBox.Controls.Add(this.trackBarDistance);
            this.groupBox.Controls.Add(this.trackBarY);
            this.groupBox.Controls.Add(this.trackBarX);
            this.groupBox.Controls.Add(this.panel1);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox.Location = new System.Drawing.Point(13, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(453, 908);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Scene settings";
            // 
            // labelCaptions
            // 
            this.labelCaptions.AutoSize = true;
            this.labelCaptions.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCaptions.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCaptions.Location = new System.Drawing.Point(6, 863);
            this.labelCaptions.MaximumSize = new System.Drawing.Size(441, 0);
            this.labelCaptions.MinimumSize = new System.Drawing.Size(441, 0);
            this.labelCaptions.Name = "labelCaptions";
            this.labelCaptions.Size = new System.Drawing.Size(441, 26);
            this.labelCaptions.TabIndex = 24;
            this.labelCaptions.Text = "Published under Apache-2.0 license\r\nby Szymon Górski (https://github.com/szgorski" +
    ").\r\n";
            this.labelCaptions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(233, 799);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(171, 34);
            this.buttonSaveSettings.TabIndex = 12;
            this.buttonSaveSettings.Text = "Save Scene";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonLoadSettings
            // 
            this.buttonLoadSettings.Location = new System.Drawing.Point(49, 799);
            this.buttonLoadSettings.Name = "buttonLoadSettings";
            this.buttonLoadSettings.Size = new System.Drawing.Size(171, 34);
            this.buttonLoadSettings.TabIndex = 11;
            this.buttonLoadSettings.Text = "Load Scene";
            this.buttonLoadSettings.UseVisualStyleBackColor = true;
            this.buttonLoadSettings.Click += new System.EventHandler(this.buttonLoadSettings_Click);
            // 
            // buttonApplyFigure
            // 
            this.buttonApplyFigure.Location = new System.Drawing.Point(141, 515);
            this.buttonApplyFigure.Name = "buttonApplyFigure";
            this.buttonApplyFigure.Size = new System.Drawing.Size(171, 34);
            this.buttonApplyFigure.TabIndex = 10;
            this.buttonApplyFigure.Text = "Add Figure";
            this.buttonApplyFigure.UseVisualStyleBackColor = true;
            this.buttonApplyFigure.Click += new System.EventHandler(this.buttonApplyFigure_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(10, 729);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(146, 21);
            this.labelDistance.TabIndex = 8;
            this.labelDistance.Text = "Rendering distance:";
            // 
            // labelYRotation
            // 
            this.labelYRotation.AutoSize = true;
            this.labelYRotation.Location = new System.Drawing.Point(10, 678);
            this.labelYRotation.Name = "labelYRotation";
            this.labelYRotation.Size = new System.Drawing.Size(168, 21);
            this.labelYRotation.TabIndex = 7;
            this.labelYRotation.Text = "Y-axis camera rotation:";
            // 
            // labelXRotation
            // 
            this.labelXRotation.AutoSize = true;
            this.labelXRotation.Location = new System.Drawing.Point(10, 627);
            this.labelXRotation.Name = "labelXRotation";
            this.labelXRotation.Size = new System.Drawing.Size(168, 21);
            this.labelXRotation.TabIndex = 6;
            this.labelXRotation.Text = "X-axis camera rotation:";
            // 
            // labelScene
            // 
            this.labelScene.AutoSize = true;
            this.labelScene.Location = new System.Drawing.Point(10, 583);
            this.labelScene.Name = "labelScene";
            this.labelScene.Size = new System.Drawing.Size(191, 21);
            this.labelScene.TabIndex = 5;
            this.labelScene.Text = "Choose scene parameters:";
            // 
            // trackBarDistance
            // 
            this.trackBarDistance.Location = new System.Drawing.Point(189, 729);
            this.trackBarDistance.Maximum = 30;
            this.trackBarDistance.Minimum = 5;
            this.trackBarDistance.Name = "trackBarDistance";
            this.trackBarDistance.Size = new System.Drawing.Size(247, 45);
            this.trackBarDistance.TabIndex = 3;
            this.trackBarDistance.TickFrequency = 5;
            this.trackBarDistance.Value = 10;
            this.trackBarDistance.ValueChanged += new System.EventHandler(this.trackBarDistance_ValueChanged);
            // 
            // trackBarY
            // 
            this.trackBarY.LargeChange = 10;
            this.trackBarY.Location = new System.Drawing.Point(189, 678);
            this.trackBarY.Maximum = 60;
            this.trackBarY.Minimum = -60;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(247, 45);
            this.trackBarY.SmallChange = 5;
            this.trackBarY.TabIndex = 2;
            this.trackBarY.TickFrequency = 10;
            this.trackBarY.ValueChanged += new System.EventHandler(this.trackBarY_ValueChanged);
            // 
            // trackBarX
            // 
            this.trackBarX.LargeChange = 10;
            this.trackBarX.Location = new System.Drawing.Point(189, 627);
            this.trackBarX.Maximum = 60;
            this.trackBarX.Minimum = -60;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(247, 45);
            this.trackBarX.SmallChange = 5;
            this.trackBarX.TabIndex = 1;
            this.trackBarX.TickFrequency = 10;
            this.trackBarX.ValueChanged += new System.EventHandler(this.trackBarX_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownDensity);
            this.panel1.Controls.Add(this.labelDensity);
            this.panel1.Controls.Add(this.numericUpDownRotationZ);
            this.panel1.Controls.Add(this.numericUpDownRotationY);
            this.panel1.Controls.Add(this.numericUpDownRotationX);
            this.panel1.Controls.Add(this.labelRotationZ);
            this.panel1.Controls.Add(this.labelRotationY);
            this.panel1.Controls.Add(this.labelRotationX);
            this.panel1.Controls.Add(this.numericUpDownPositionZ);
            this.panel1.Controls.Add(this.numericUpDownPositionY);
            this.panel1.Controls.Add(this.numericUpDownPositionX);
            this.panel1.Controls.Add(this.labelPositionZ);
            this.panel1.Controls.Add(this.labelPositionY);
            this.panel1.Controls.Add(this.labelPositionX);
            this.panel1.Controls.Add(this.labelRotation);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Controls.Add(this.numericUpDownRadius);
            this.panel1.Controls.Add(this.labelRadius);
            this.panel1.Controls.Add(this.numericUpDownHeight);
            this.panel1.Controls.Add(this.numericUpDownDepth);
            this.panel1.Controls.Add(this.labelHeight);
            this.panel1.Controls.Add(this.labelDepth);
            this.panel1.Controls.Add(this.numericUpDownWidth);
            this.panel1.Controls.Add(this.labelWidth);
            this.panel1.Controls.Add(this.radioButtonCone);
            this.panel1.Controls.Add(this.radioButtonCyllinder);
            this.panel1.Controls.Add(this.radioButtonSphere);
            this.panel1.Controls.Add(this.radioButtonCuboid);
            this.panel1.Controls.Add(this.labelFigure);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(6, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 462);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDownDensity
            // 
            this.numericUpDownDensity.Location = new System.Drawing.Point(71, 417);
            this.numericUpDownDensity.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownDensity.Name = "numericUpDownDensity";
            this.numericUpDownDensity.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownDensity.TabIndex = 30;
            this.numericUpDownDensity.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDensity.Location = new System.Drawing.Point(13, 388);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(91, 17);
            this.labelDensity.TabIndex = 29;
            this.labelDensity.Text = "Circle density:";
            // 
            // numericUpDownRotationZ
            // 
            this.numericUpDownRotationZ.Location = new System.Drawing.Point(304, 326);
            this.numericUpDownRotationZ.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericUpDownRotationZ.Name = "numericUpDownRotationZ";
            this.numericUpDownRotationZ.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownRotationZ.TabIndex = 28;
            // 
            // numericUpDownRotationY
            // 
            this.numericUpDownRotationY.Location = new System.Drawing.Point(304, 290);
            this.numericUpDownRotationY.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericUpDownRotationY.Name = "numericUpDownRotationY";
            this.numericUpDownRotationY.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownRotationY.TabIndex = 27;
            // 
            // numericUpDownRotationX
            // 
            this.numericUpDownRotationX.Location = new System.Drawing.Point(304, 254);
            this.numericUpDownRotationX.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericUpDownRotationX.Name = "numericUpDownRotationX";
            this.numericUpDownRotationX.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownRotationX.TabIndex = 26;
            // 
            // labelRotationZ
            // 
            this.labelRotationZ.AutoSize = true;
            this.labelRotationZ.Location = new System.Drawing.Point(209, 328);
            this.labelRotationZ.Name = "labelRotationZ";
            this.labelRotationZ.Size = new System.Drawing.Size(22, 21);
            this.labelRotationZ.TabIndex = 25;
            this.labelRotationZ.Text = "Z:";
            // 
            // labelRotationY
            // 
            this.labelRotationY.AutoSize = true;
            this.labelRotationY.Location = new System.Drawing.Point(209, 292);
            this.labelRotationY.Name = "labelRotationY";
            this.labelRotationY.Size = new System.Drawing.Size(22, 21);
            this.labelRotationY.TabIndex = 24;
            this.labelRotationY.Text = "Y:";
            // 
            // labelRotationX
            // 
            this.labelRotationX.AutoSize = true;
            this.labelRotationX.Location = new System.Drawing.Point(209, 256);
            this.labelRotationX.Name = "labelRotationX";
            this.labelRotationX.Size = new System.Drawing.Size(22, 21);
            this.labelRotationX.TabIndex = 23;
            this.labelRotationX.Text = "X:";
            // 
            // numericUpDownPositionZ
            // 
            this.numericUpDownPositionZ.DecimalPlaces = 1;
            this.numericUpDownPositionZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPositionZ.Location = new System.Drawing.Point(71, 326);
            this.numericUpDownPositionZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownPositionZ.Name = "numericUpDownPositionZ";
            this.numericUpDownPositionZ.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownPositionZ.TabIndex = 22;
            // 
            // numericUpDownPositionY
            // 
            this.numericUpDownPositionY.DecimalPlaces = 1;
            this.numericUpDownPositionY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPositionY.Location = new System.Drawing.Point(71, 290);
            this.numericUpDownPositionY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownPositionY.Name = "numericUpDownPositionY";
            this.numericUpDownPositionY.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownPositionY.TabIndex = 21;
            // 
            // numericUpDownPositionX
            // 
            this.numericUpDownPositionX.DecimalPlaces = 1;
            this.numericUpDownPositionX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPositionX.Location = new System.Drawing.Point(71, 254);
            this.numericUpDownPositionX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownPositionX.Name = "numericUpDownPositionX";
            this.numericUpDownPositionX.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownPositionX.TabIndex = 20;
            // 
            // labelPositionZ
            // 
            this.labelPositionZ.AutoSize = true;
            this.labelPositionZ.Location = new System.Drawing.Point(13, 328);
            this.labelPositionZ.Name = "labelPositionZ";
            this.labelPositionZ.Size = new System.Drawing.Size(22, 21);
            this.labelPositionZ.TabIndex = 19;
            this.labelPositionZ.Text = "Z:";
            // 
            // labelPositionY
            // 
            this.labelPositionY.AutoSize = true;
            this.labelPositionY.Location = new System.Drawing.Point(13, 292);
            this.labelPositionY.Name = "labelPositionY";
            this.labelPositionY.Size = new System.Drawing.Size(22, 21);
            this.labelPositionY.TabIndex = 18;
            this.labelPositionY.Text = "Y:";
            // 
            // labelPositionX
            // 
            this.labelPositionX.AutoSize = true;
            this.labelPositionX.Location = new System.Drawing.Point(13, 256);
            this.labelPositionX.Name = "labelPositionX";
            this.labelPositionX.Size = new System.Drawing.Size(22, 21);
            this.labelPositionX.TabIndex = 17;
            this.labelPositionX.Text = "X:";
            // 
            // labelRotation
            // 
            this.labelRotation.AutoSize = true;
            this.labelRotation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRotation.Location = new System.Drawing.Point(209, 225);
            this.labelRotation.Name = "labelRotation";
            this.labelRotation.Size = new System.Drawing.Size(123, 17);
            this.labelRotation.TabIndex = 16;
            this.labelRotation.Text = "Rotation (degrees):";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPosition.Location = new System.Drawing.Point(13, 225);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(105, 17);
            this.labelPosition.TabIndex = 15;
            this.labelPosition.Text = "Corner position:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSize.Location = new System.Drawing.Point(209, 37);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(34, 17);
            this.labelSize.TabIndex = 14;
            this.labelSize.Text = "Size:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(13, 37);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(39, 17);
            this.labelType.TabIndex = 13;
            this.labelType.Text = "Type:";
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.DecimalPlaces = 1;
            this.numericUpDownRadius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownRadius.Location = new System.Drawing.Point(304, 173);
            this.numericUpDownRadius.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownRadius.TabIndex = 12;
            this.numericUpDownRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(209, 175);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(60, 21);
            this.labelRadius.TabIndex = 11;
            this.labelRadius.Text = "Radius:";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.DecimalPlaces = 1;
            this.numericUpDownHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHeight.Location = new System.Drawing.Point(304, 102);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownHeight.TabIndex = 10;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.DecimalPlaces = 1;
            this.numericUpDownDepth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDepth.Location = new System.Drawing.Point(304, 138);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownDepth.TabIndex = 9;
            this.numericUpDownDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(209, 104);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(59, 21);
            this.labelHeight.TabIndex = 8;
            this.labelHeight.Text = "Height:";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(209, 140);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(55, 21);
            this.labelDepth.TabIndex = 7;
            this.labelDepth.Text = "Depth:";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.DecimalPlaces = 1;
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWidth.Location = new System.Drawing.Point(304, 66);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownWidth.TabIndex = 6;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(209, 68);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(55, 21);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "Width:";
            // 
            // radioButtonCone
            // 
            this.radioButtonCone.AutoSize = true;
            this.radioButtonCone.Location = new System.Drawing.Point(25, 173);
            this.radioButtonCone.Name = "radioButtonCone";
            this.radioButtonCone.Size = new System.Drawing.Size(64, 25);
            this.radioButtonCone.TabIndex = 4;
            this.radioButtonCone.Text = "Cone";
            this.radioButtonCone.UseVisualStyleBackColor = true;
            this.radioButtonCone.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonCyllinder
            // 
            this.radioButtonCyllinder.AutoSize = true;
            this.radioButtonCyllinder.Location = new System.Drawing.Point(25, 138);
            this.radioButtonCyllinder.Name = "radioButtonCyllinder";
            this.radioButtonCyllinder.Size = new System.Drawing.Size(90, 25);
            this.radioButtonCyllinder.TabIndex = 3;
            this.radioButtonCyllinder.Text = "Cyllinder";
            this.radioButtonCyllinder.UseVisualStyleBackColor = true;
            this.radioButtonCyllinder.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSphere
            // 
            this.radioButtonSphere.AutoSize = true;
            this.radioButtonSphere.Location = new System.Drawing.Point(25, 102);
            this.radioButtonSphere.Name = "radioButtonSphere";
            this.radioButtonSphere.Size = new System.Drawing.Size(77, 25);
            this.radioButtonSphere.TabIndex = 2;
            this.radioButtonSphere.Text = "Sphere";
            this.radioButtonSphere.UseVisualStyleBackColor = true;
            this.radioButtonSphere.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonCuboid
            // 
            this.radioButtonCuboid.AutoSize = true;
            this.radioButtonCuboid.Checked = true;
            this.radioButtonCuboid.Location = new System.Drawing.Point(25, 66);
            this.radioButtonCuboid.Name = "radioButtonCuboid";
            this.radioButtonCuboid.Size = new System.Drawing.Size(78, 25);
            this.radioButtonCuboid.TabIndex = 1;
            this.radioButtonCuboid.TabStop = true;
            this.radioButtonCuboid.Text = "Cuboid";
            this.radioButtonCuboid.UseVisualStyleBackColor = true;
            this.radioButtonCuboid.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelFigure
            // 
            this.labelFigure.AutoSize = true;
            this.labelFigure.Location = new System.Drawing.Point(4, 4);
            this.labelFigure.Name = "labelFigure";
            this.labelFigure.Size = new System.Drawing.Size(190, 21);
            this.labelFigure.TabIndex = 0;
            this.labelFigure.Text = "Choose a figure to render:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "TXT files|*.txt|All files|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "TXT files|*.txt|All files|*.*";
            // 
            // SceneRenderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 932);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "SceneRenderer";
            this.Text = "SceneRenderer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonLoadSettings;
        private System.Windows.Forms.Button buttonApplyFigure;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelYRotation;
        private System.Windows.Forms.Label labelXRotation;
        private System.Windows.Forms.Label labelScene;
        private System.Windows.Forms.TrackBar trackBarDistance;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.RadioButton radioButtonCone;
        private System.Windows.Forms.RadioButton radioButtonCyllinder;
        private System.Windows.Forms.RadioButton radioButtonSphere;
        private System.Windows.Forms.RadioButton radioButtonCuboid;
        private System.Windows.Forms.Label labelFigure;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown numericUpDownDensity;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationZ;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationY;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationX;
        private System.Windows.Forms.Label labelRotationZ;
        private System.Windows.Forms.Label labelRotationY;
        private System.Windows.Forms.Label labelRotationX;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionZ;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionY;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionX;
        private System.Windows.Forms.Label labelPositionZ;
        private System.Windows.Forms.Label labelPositionY;
        private System.Windows.Forms.Label labelPositionX;
        private System.Windows.Forms.Label labelRotation;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCaptions;
    }
}

