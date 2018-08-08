namespace CameraUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.values = new System.Windows.Forms.ListView();
            this.fovSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distanceSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.upperHightSlider = new System.Windows.Forms.TrackBar();
            this.lowerHeightSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lateralNearSlider = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.nearLabel = new System.Windows.Forms.Label();
            this.lowerLabel = new System.Windows.Forms.Label();
            this.upperLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.fovLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FarLabel = new System.Windows.Forms.Label();
            this.lateralFarSlider = new System.Windows.Forms.TrackBar();
            this.loadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cSpeedSlider = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.fPredictionSlider = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.igCameraCB = new System.Windows.Forms.CheckBox();
            this.SwayCB = new System.Windows.Forms.CheckBox();
            this.thirdPersonCB = new System.Windows.Forms.CheckBox();
            this.wallsCB = new System.Windows.Forms.CheckBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.forwardLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.posSmoothSlider = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.rotationSmoothSlider = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.rotationSmoothLabel = new System.Windows.Forms.Label();
            this.posSmoothLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.posXSlider = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.lookYLabel = new System.Windows.Forms.Label();
            this.lookXLabel = new System.Windows.Forms.Label();
            this.posZSlider = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.lookZLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maxSwaySlider = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.swaySpeedSlider = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.swaySpeedLabel = new System.Windows.Forms.Label();
            this.maxSwayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fovSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperHightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerHeightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lateralNearSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lateralFarSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPredictionSlider)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posSmoothSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSmoothSlider)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posXSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posZSlider)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSwaySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swaySpeedSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // values
            // 
            this.values.Location = new System.Drawing.Point(12, 12);
            this.values.Name = "values";
            this.values.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.values.Size = new System.Drawing.Size(272, 547);
            this.values.TabIndex = 0;
            this.values.UseCompatibleStateImageBehavior = false;
            this.values.View = System.Windows.Forms.View.List;
            // 
            // fovSlider
            // 
            this.fovSlider.Location = new System.Drawing.Point(6, 19);
            this.fovSlider.Maximum = 140;
            this.fovSlider.Minimum = 20;
            this.fovSlider.Name = "fovSlider";
            this.fovSlider.Size = new System.Drawing.Size(209, 45);
            this.fovSlider.TabIndex = 2;
            this.fovSlider.Value = 20;
            this.fovSlider.Scroll += new System.EventHandler(this.fovSlider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera distance";
            // 
            // distanceSlider
            // 
            this.distanceSlider.Location = new System.Drawing.Point(6, 70);
            this.distanceSlider.Maximum = 200;
            this.distanceSlider.Name = "distanceSlider";
            this.distanceSlider.Size = new System.Drawing.Size(209, 45);
            this.distanceSlider.TabIndex = 4;
            this.distanceSlider.Scroll += new System.EventHandler(this.distanceSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Upper height";
            // 
            // upperHightSlider
            // 
            this.upperHightSlider.Location = new System.Drawing.Point(6, 121);
            this.upperHightSlider.Maximum = 200;
            this.upperHightSlider.Name = "upperHightSlider";
            this.upperHightSlider.Size = new System.Drawing.Size(209, 45);
            this.upperHightSlider.TabIndex = 6;
            this.upperHightSlider.Scroll += new System.EventHandler(this.upperHightSlider_Scroll);
            // 
            // lowerHeightSlider
            // 
            this.lowerHeightSlider.Location = new System.Drawing.Point(6, 172);
            this.lowerHeightSlider.Maximum = 200;
            this.lowerHeightSlider.Name = "lowerHeightSlider";
            this.lowerHeightSlider.Size = new System.Drawing.Size(209, 45);
            this.lowerHeightSlider.TabIndex = 8;
            this.lowerHeightSlider.Scroll += new System.EventHandler(this.lowerHeightSlider_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lower height";
            // 
            // lateralNearSlider
            // 
            this.lateralNearSlider.Location = new System.Drawing.Point(6, 223);
            this.lateralNearSlider.Maximum = 200;
            this.lateralNearSlider.Name = "lateralNearSlider";
            this.lateralNearSlider.Size = new System.Drawing.Size(209, 45);
            this.lateralNearSlider.TabIndex = 10;
            this.lateralNearSlider.Scroll += new System.EventHandler(this.lateralNearSlider_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lateral near";
            // 
            // nearLabel
            // 
            this.nearLabel.AutoSize = true;
            this.nearLabel.Location = new System.Drawing.Point(315, 232);
            this.nearLabel.Name = "nearLabel";
            this.nearLabel.Size = new System.Drawing.Size(0, 13);
            this.nearLabel.TabIndex = 16;
            // 
            // lowerLabel
            // 
            this.lowerLabel.AutoSize = true;
            this.lowerLabel.Location = new System.Drawing.Point(322, 181);
            this.lowerLabel.Name = "lowerLabel";
            this.lowerLabel.Size = new System.Drawing.Size(0, 13);
            this.lowerLabel.TabIndex = 15;
            // 
            // upperLabel
            // 
            this.upperLabel.AutoSize = true;
            this.upperLabel.Location = new System.Drawing.Point(322, 130);
            this.upperLabel.Name = "upperLabel";
            this.upperLabel.Size = new System.Drawing.Size(0, 13);
            this.upperLabel.TabIndex = 14;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(322, 79);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 13);
            this.distanceLabel.TabIndex = 13;
            // 
            // fovLabel
            // 
            this.fovLabel.AutoSize = true;
            this.fovLabel.Location = new System.Drawing.Point(322, 28);
            this.fovLabel.Name = "fovLabel";
            this.fovLabel.Size = new System.Drawing.Size(0, 13);
            this.fovLabel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lateral far";
            // 
            // FarLabel
            // 
            this.FarLabel.AutoSize = true;
            this.FarLabel.Location = new System.Drawing.Point(322, 283);
            this.FarLabel.Name = "FarLabel";
            this.FarLabel.Size = new System.Drawing.Size(0, 13);
            this.FarLabel.TabIndex = 19;
            // 
            // lateralFarSlider
            // 
            this.lateralFarSlider.Location = new System.Drawing.Point(6, 274);
            this.lateralFarSlider.Maximum = 200;
            this.lateralFarSlider.Name = "lateralFarSlider";
            this.lateralFarSlider.Size = new System.Drawing.Size(209, 45);
            this.lateralFarSlider.TabIndex = 21;
            this.lateralFarSlider.Scroll += new System.EventHandler(this.lateralFarSlider_Scroll);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(290, 536);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(804, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load File";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Controls.Add(this.forwardLabel);
            this.groupBox1.Controls.Add(this.cSpeedSlider);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fPredictionSlider);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.fovSlider);
            this.groupBox1.Controls.Add(this.lateralFarSlider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FarLabel);
            this.groupBox1.Controls.Add(this.distanceSlider);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nearLabel);
            this.groupBox1.Controls.Add(this.upperHightSlider);
            this.groupBox1.Controls.Add(this.lowerLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.upperLabel);
            this.groupBox1.Controls.Add(this.lowerHeightSlider);
            this.groupBox1.Controls.Add(this.distanceLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fovLabel);
            this.groupBox1.Controls.Add(this.lateralNearSlider);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 423);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Settings";
            // 
            // cSpeedSlider
            // 
            this.cSpeedSlider.Location = new System.Drawing.Point(6, 376);
            this.cSpeedSlider.Maximum = 200;
            this.cSpeedSlider.Name = "cSpeedSlider";
            this.cSpeedSlider.Size = new System.Drawing.Size(209, 45);
            this.cSpeedSlider.TabIndex = 25;
            this.cSpeedSlider.Scroll += new System.EventHandler(this.cSpeedSlider_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Camera speed";
            // 
            // fPredictionSlider
            // 
            this.fPredictionSlider.Location = new System.Drawing.Point(6, 325);
            this.fPredictionSlider.Maximum = 200;
            this.fPredictionSlider.Name = "fPredictionSlider";
            this.fPredictionSlider.Size = new System.Drawing.Size(209, 45);
            this.fPredictionSlider.TabIndex = 22;
            this.fPredictionSlider.Scroll += new System.EventHandler(this.fPredictionSlider_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Forward prediction";
            // 
            // igCameraCB
            // 
            this.igCameraCB.AutoSize = true;
            this.igCameraCB.Location = new System.Drawing.Point(296, 441);
            this.igCameraCB.Name = "igCameraCB";
            this.igCameraCB.Size = new System.Drawing.Size(139, 17);
            this.igCameraCB.TabIndex = 23;
            this.igCameraCB.Text = "Ingame camera preview";
            this.igCameraCB.UseVisualStyleBackColor = true;
            this.igCameraCB.CheckedChanged += new System.EventHandler(this.igCameraCB_CheckedChanged);
            // 
            // SwayCB
            // 
            this.SwayCB.AutoSize = true;
            this.SwayCB.Location = new System.Drawing.Point(296, 464);
            this.SwayCB.Name = "SwayCB";
            this.SwayCB.Size = new System.Drawing.Size(90, 17);
            this.SwayCB.TabIndex = 24;
            this.SwayCB.Text = "Sway camera";
            this.SwayCB.UseVisualStyleBackColor = true;
            this.SwayCB.CheckedChanged += new System.EventHandler(this.SwayCB_CheckedChanged);
            // 
            // thirdPersonCB
            // 
            this.thirdPersonCB.AutoSize = true;
            this.thirdPersonCB.Location = new System.Drawing.Point(514, 441);
            this.thirdPersonCB.Name = "thirdPersonCB";
            this.thirdPersonCB.Size = new System.Drawing.Size(85, 17);
            this.thirdPersonCB.TabIndex = 25;
            this.thirdPersonCB.Text = "Third person";
            this.thirdPersonCB.UseVisualStyleBackColor = true;
            this.thirdPersonCB.CheckedChanged += new System.EventHandler(this.thirdPersonCB_CheckedChanged);
            // 
            // wallsCB
            // 
            this.wallsCB.AutoSize = true;
            this.wallsCB.Location = new System.Drawing.Point(514, 464);
            this.wallsCB.Name = "wallsCB";
            this.wallsCB.Size = new System.Drawing.Size(79, 17);
            this.wallsCB.TabIndex = 26;
            this.wallsCB.Text = "Avoid walls";
            this.wallsCB.UseVisualStyleBackColor = true;
            this.wallsCB.CheckedChanged += new System.EventHandler(this.wallsCB_CheckedChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(331, 385);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 13);
            this.speedLabel.TabIndex = 27;
            // 
            // forwardLabel
            // 
            this.forwardLabel.AutoSize = true;
            this.forwardLabel.Location = new System.Drawing.Point(331, 336);
            this.forwardLabel.Name = "forwardLabel";
            this.forwardLabel.Size = new System.Drawing.Size(0, 13);
            this.forwardLabel.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.posSmoothSlider);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.rotationSmoothSlider);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.rotationSmoothLabel);
            this.groupBox2.Controls.Add(this.posSmoothLabel);
            this.groupBox2.Location = new System.Drawing.Point(715, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 124);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Smoothing";
            // 
            // posSmoothSlider
            // 
            this.posSmoothSlider.Location = new System.Drawing.Point(6, 19);
            this.posSmoothSlider.Maximum = 200;
            this.posSmoothSlider.Name = "posSmoothSlider";
            this.posSmoothSlider.Size = new System.Drawing.Size(209, 45);
            this.posSmoothSlider.TabIndex = 2;
            this.posSmoothSlider.Value = 20;
            this.posSmoothSlider.Scroll += new System.EventHandler(this.posSmoothSlider_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(221, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Position Smoothing";
            // 
            // rotationSmoothSlider
            // 
            this.rotationSmoothSlider.Location = new System.Drawing.Point(6, 70);
            this.rotationSmoothSlider.Maximum = 200;
            this.rotationSmoothSlider.Name = "rotationSmoothSlider";
            this.rotationSmoothSlider.Size = new System.Drawing.Size(209, 45);
            this.rotationSmoothSlider.TabIndex = 4;
            this.rotationSmoothSlider.Scroll += new System.EventHandler(this.rotationSmoothSlider_Scroll);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(221, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Rotation Smoothing";
            // 
            // rotationSmoothLabel
            // 
            this.rotationSmoothLabel.AutoSize = true;
            this.rotationSmoothLabel.Location = new System.Drawing.Point(338, 79);
            this.rotationSmoothLabel.Name = "rotationSmoothLabel";
            this.rotationSmoothLabel.Size = new System.Drawing.Size(0, 13);
            this.rotationSmoothLabel.TabIndex = 13;
            // 
            // posSmoothLabel
            // 
            this.posSmoothLabel.AutoSize = true;
            this.posSmoothLabel.Location = new System.Drawing.Point(338, 28);
            this.posSmoothLabel.Name = "posSmoothLabel";
            this.posSmoothLabel.Size = new System.Drawing.Size(0, 13);
            this.posSmoothLabel.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.posZSlider);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lookZLabel);
            this.groupBox3.Controls.Add(this.posXSlider);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.trackBar2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lookYLabel);
            this.groupBox3.Controls.Add(this.lookXLabel);
            this.groupBox3.Location = new System.Drawing.Point(715, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 175);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera View";
            // 
            // posXSlider
            // 
            this.posXSlider.Location = new System.Drawing.Point(6, 19);
            this.posXSlider.Maximum = 200;
            this.posXSlider.Name = "posXSlider";
            this.posXSlider.Size = new System.Drawing.Size(209, 45);
            this.posXSlider.TabIndex = 2;
            this.posXSlider.Scroll += new System.EventHandler(this.posXSlider_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Look at X";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 70);
            this.trackBar2.Maximum = 200;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(209, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Look at Y";
            // 
            // lookYLabel
            // 
            this.lookYLabel.AutoSize = true;
            this.lookYLabel.Location = new System.Drawing.Point(338, 79);
            this.lookYLabel.Name = "lookYLabel";
            this.lookYLabel.Size = new System.Drawing.Size(0, 13);
            this.lookYLabel.TabIndex = 13;
            // 
            // lookXLabel
            // 
            this.lookXLabel.AutoSize = true;
            this.lookXLabel.Location = new System.Drawing.Point(338, 28);
            this.lookXLabel.Name = "lookXLabel";
            this.lookXLabel.Size = new System.Drawing.Size(0, 13);
            this.lookXLabel.TabIndex = 12;
            // 
            // posZSlider
            // 
            this.posZSlider.Location = new System.Drawing.Point(6, 121);
            this.posZSlider.Maximum = 200;
            this.posZSlider.Name = "posZSlider";
            this.posZSlider.Size = new System.Drawing.Size(209, 45);
            this.posZSlider.TabIndex = 14;
            this.posZSlider.Scroll += new System.EventHandler(this.posZSlider_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Look at Z";
            // 
            // lookZLabel
            // 
            this.lookZLabel.AutoSize = true;
            this.lookZLabel.Location = new System.Drawing.Point(338, 130);
            this.lookZLabel.Name = "lookZLabel";
            this.lookZLabel.Size = new System.Drawing.Size(0, 13);
            this.lookZLabel.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maxSwaySlider);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.swaySpeedSlider);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.swaySpeedLabel);
            this.groupBox4.Controls.Add(this.maxSwayLabel);
            this.groupBox4.Location = new System.Drawing.Point(715, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 112);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sway Settings";
            // 
            // maxSwaySlider
            // 
            this.maxSwaySlider.Location = new System.Drawing.Point(6, 19);
            this.maxSwaySlider.Maximum = 200;
            this.maxSwaySlider.Name = "maxSwaySlider";
            this.maxSwaySlider.Size = new System.Drawing.Size(209, 45);
            this.maxSwaySlider.TabIndex = 2;
            this.maxSwaySlider.Scroll += new System.EventHandler(this.maxSwaySlider_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Max sway";
            // 
            // swaySpeedSlider
            // 
            this.swaySpeedSlider.Location = new System.Drawing.Point(6, 61);
            this.swaySpeedSlider.Maximum = 200;
            this.swaySpeedSlider.Name = "swaySpeedSlider";
            this.swaySpeedSlider.Size = new System.Drawing.Size(209, 45);
            this.swaySpeedSlider.TabIndex = 4;
            this.swaySpeedSlider.Scroll += new System.EventHandler(this.swaySpeedSlider_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(221, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Sway speed";
            // 
            // swaySpeedLabel
            // 
            this.swaySpeedLabel.AutoSize = true;
            this.swaySpeedLabel.Location = new System.Drawing.Point(338, 79);
            this.swaySpeedLabel.Name = "swaySpeedLabel";
            this.swaySpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.swaySpeedLabel.TabIndex = 13;
            // 
            // maxSwayLabel
            // 
            this.maxSwayLabel.AutoSize = true;
            this.maxSwayLabel.Location = new System.Drawing.Point(338, 28);
            this.maxSwayLabel.Name = "maxSwayLabel";
            this.maxSwayLabel.Size = new System.Drawing.Size(0, 13);
            this.maxSwayLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.wallsCB);
            this.Controls.Add(this.thirdPersonCB);
            this.Controls.Add(this.SwayCB);
            this.Controls.Add(this.igCameraCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.values);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Camera Interface";
            ((System.ComponentModel.ISupportInitialize)(this.fovSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperHightSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerHeightSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lateralNearSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lateralFarSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPredictionSlider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posSmoothSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSmoothSlider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posXSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posZSlider)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSwaySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swaySpeedSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView values;
        private System.Windows.Forms.TrackBar fovSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar distanceSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar upperHightSlider;
        private System.Windows.Forms.TrackBar lowerHeightSlider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar lateralNearSlider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nearLabel;
        private System.Windows.Forms.Label lowerLabel;
        private System.Windows.Forms.Label upperLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label fovLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FarLabel;
        private System.Windows.Forms.TrackBar lateralFarSlider;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar cSpeedSlider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar fPredictionSlider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox igCameraCB;
        private System.Windows.Forms.CheckBox SwayCB;
        private System.Windows.Forms.CheckBox thirdPersonCB;
        private System.Windows.Forms.CheckBox wallsCB;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label forwardLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar posSmoothSlider;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar rotationSmoothSlider;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label rotationSmoothLabel;
        private System.Windows.Forms.Label posSmoothLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar posZSlider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lookZLabel;
        private System.Windows.Forms.TrackBar posXSlider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lookYLabel;
        private System.Windows.Forms.Label lookXLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar maxSwaySlider;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar swaySpeedSlider;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label swaySpeedLabel;
        private System.Windows.Forms.Label maxSwayLabel;
    }
}

