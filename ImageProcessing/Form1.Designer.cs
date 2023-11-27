namespace ImageProcessing
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorManipulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.scaleBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputHeight = new System.Windows.Forms.TextBox();
            this.inputWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMakeBaseImg = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBaseImg = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadBg = new System.Windows.Forms.Button();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.scaleBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBaseImg.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.colorManipulationToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.flipToolStripMenuItem,
            this.cameraToolStripMenuItem,
            this.subtractToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.colorToolStripMenuItem.Text = "Image";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // colorManipulationToolStripMenuItem
            // 
            this.colorManipulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScalingToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.colorManipulationToolStripMenuItem.Name = "colorManipulationToolStripMenuItem";
            this.colorManipulationToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorManipulationToolStripMenuItem.Text = "Color";
            // 
            // grayScalingToolStripMenuItem
            // 
            this.grayScalingToolStripMenuItem.Name = "grayScalingToolStripMenuItem";
            this.grayScalingToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.grayScalingToolStripMenuItem.Text = "Gray Scaling";
            this.grayScalingToolStripMenuItem.Click += new System.EventHandler(this.grayScalingToolStripMenuItem_Click);
            // 
            // colorInversionToolStripMenuItem
            // 
            this.colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            this.colorInversionToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem1,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.rotateToolStripMenuItem1,
            this.scaleToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.histogramToolStripMenuItem.Text = "Edit";
            // 
            // histogramToolStripMenuItem1
            // 
            this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.histogramToolStripMenuItem1.Text = "Histogram";
            this.histogramToolStripMenuItem1.Click += new System.EventHandler(this.histogramToolStripMenuItem1_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem1
            // 
            this.rotateToolStripMenuItem1.Name = "rotateToolStripMenuItem1";
            this.rotateToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.rotateToolStripMenuItem1.Text = "Rotate";
            this.rotateToolStripMenuItem1.Click += new System.EventHandler(this.rotateToolStripMenuItem1_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // flipToolStripMenuItem
            // 
            this.flipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.flipToolStripMenuItem.Text = "Flip";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(20, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 286);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(361, 231);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 32);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(304, 553);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(179, 30);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(304, 594);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(179, 30);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(61, 42);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(475, 56);
            this.trackBar1.TabIndex = 6;
            // 
            // scaleBox
            // 
            this.scaleBox.Controls.Add(this.label4);
            this.scaleBox.Controls.Add(this.label3);
            this.scaleBox.Controls.Add(this.inputHeight);
            this.scaleBox.Controls.Add(this.inputWidth);
            this.scaleBox.Controls.Add(this.label2);
            this.scaleBox.Location = new System.Drawing.Point(295, 422);
            this.scaleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleBox.Size = new System.Drawing.Size(200, 116);
            this.scaleBox.TabIndex = 8;
            this.scaleBox.TabStop = false;
            this.scaleBox.Text = "Scale";
            this.scaleBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Height -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Width -";
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(101, 73);
            this.inputHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(53, 22);
            this.inputHeight.TabIndex = 2;
            // 
            // inputWidth
            // 
            this.inputWidth.Location = new System.Drawing.Point(101, 44);
            this.inputWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(53, 22);
            this.inputWidth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Dimensions";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(99, 422);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(600, 123);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // btnMakeBaseImg
            // 
            this.btnMakeBaseImg.AutoSize = true;
            this.btnMakeBaseImg.Enabled = false;
            this.btnMakeBaseImg.Location = new System.Drawing.Point(105, 315);
            this.btnMakeBaseImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnMakeBaseImg.Name = "btnMakeBaseImg";
            this.btnMakeBaseImg.Size = new System.Drawing.Size(107, 16);
            this.btnMakeBaseImg.TabIndex = 10;
            this.btnMakeBaseImg.TabStop = true;
            this.btnMakeBaseImg.Text = "Use this as base";
            this.btnMakeBaseImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnMakeBaseImg_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbBaseImg
            // 
            this.gbBaseImg.Controls.Add(this.btnLoadImg);
            this.gbBaseImg.Controls.Add(this.pictureBox1);
            this.gbBaseImg.Location = new System.Drawing.Point(16, 53);
            this.gbBaseImg.Margin = new System.Windows.Forms.Padding(4);
            this.gbBaseImg.Name = "gbBaseImg";
            this.gbBaseImg.Padding = new System.Windows.Forms.Padding(4);
            this.gbBaseImg.Size = new System.Drawing.Size(321, 345);
            this.gbBaseImg.TabIndex = 11;
            this.gbBaseImg.TabStop = false;
            this.gbBaseImg.Text = "Base Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadBg);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnMakeBaseImg);
            this.groupBox2.Location = new System.Drawing.Point(463, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(321, 345);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processed Image";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveResult);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(242, 406);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(321, 346);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processed Image";
            this.groupBox3.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(20, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(286, 286);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.subtractToolStripMenuItem.Text = "Subtract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.subtractToolStripMenuItem_Click);
            // 
            // btnLoadBg
            // 
            this.btnLoadBg.Location = new System.Drawing.Point(102, 309);
            this.btnLoadBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadBg.Name = "btnLoadBg";
            this.btnLoadBg.Size = new System.Drawing.Size(134, 29);
            this.btnLoadBg.TabIndex = 14;
            this.btnLoadBg.Text = "Load Background";
            this.btnLoadBg.UseVisualStyleBackColor = true;
            this.btnLoadBg.Visible = false;
            this.btnLoadBg.Click += new System.EventHandler(this.btnLoadBg_Click);
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(83, 310);
            this.btnLoadImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(134, 29);
            this.btnLoadImg.TabIndex = 15;
            this.btnLoadImg.Text = "Load Image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Visible = false;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(99, 311);
            this.btnSaveResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(134, 29);
            this.btnSaveResult.TabIndex = 15;
            this.btnSaveResult.Text = "Save Image";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(361, 306);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 32);
            this.btnSubtract.TabIndex = 14;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Visible = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbBaseImg);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.scaleBox.ResumeLayout(false);
            this.scaleBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBaseImg.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorManipulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScalingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorInversionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.GroupBox scaleBox;
        private System.Windows.Forms.TextBox inputHeight;
        private System.Windows.Forms.TextBox inputWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.LinkLabel btnMakeBaseImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbBaseImg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnLoadBg;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Button btnSubtract;
    }
}

