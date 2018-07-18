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
            ((System.ComponentModel.ISupportInitialize)(this.fovSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperHightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerHeightSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lateralNearSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lateralFarSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // values
            // 
            this.values.Location = new System.Drawing.Point(12, 12);
            this.values.Name = "values";
            this.values.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.values.Size = new System.Drawing.Size(272, 277);
            this.values.TabIndex = 0;
            this.values.UseCompatibleStateImageBehavior = false;
            this.values.View = System.Windows.Forms.View.List;
            // 
            // fovSlider
            // 
            this.fovSlider.Location = new System.Drawing.Point(290, 12);
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
            this.label1.Location = new System.Drawing.Point(505, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera Distance";
            // 
            // distanceSlider
            // 
            this.distanceSlider.Location = new System.Drawing.Point(290, 63);
            this.distanceSlider.Maximum = 50;
            this.distanceSlider.Name = "distanceSlider";
            this.distanceSlider.Size = new System.Drawing.Size(209, 45);
            this.distanceSlider.TabIndex = 4;
            this.distanceSlider.Scroll += new System.EventHandler(this.distanceSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Upper Height";
            // 
            // upperHightSlider
            // 
            this.upperHightSlider.Location = new System.Drawing.Point(290, 114);
            this.upperHightSlider.Maximum = 50;
            this.upperHightSlider.Name = "upperHightSlider";
            this.upperHightSlider.Size = new System.Drawing.Size(209, 45);
            this.upperHightSlider.TabIndex = 6;
            this.upperHightSlider.Scroll += new System.EventHandler(this.upperHightSlider_Scroll);
            // 
            // lowerHeightSlider
            // 
            this.lowerHeightSlider.Location = new System.Drawing.Point(290, 165);
            this.lowerHeightSlider.Maximum = 50;
            this.lowerHeightSlider.Name = "lowerHeightSlider";
            this.lowerHeightSlider.Size = new System.Drawing.Size(209, 45);
            this.lowerHeightSlider.TabIndex = 8;
            this.lowerHeightSlider.Scroll += new System.EventHandler(this.lowerHeightSlider_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lower Height";
            // 
            // lateralNearSlider
            // 
            this.lateralNearSlider.Location = new System.Drawing.Point(290, 216);
            this.lateralNearSlider.Maximum = 50;
            this.lateralNearSlider.Name = "lateralNearSlider";
            this.lateralNearSlider.Size = new System.Drawing.Size(209, 45);
            this.lateralNearSlider.TabIndex = 10;
            this.lateralNearSlider.Scroll += new System.EventHandler(this.lateralNearSlider_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lateral Near";
            // 
            // nearLabel
            // 
            this.nearLabel.AutoSize = true;
            this.nearLabel.Location = new System.Drawing.Point(606, 227);
            this.nearLabel.Name = "nearLabel";
            this.nearLabel.Size = new System.Drawing.Size(0, 13);
            this.nearLabel.TabIndex = 16;
            // 
            // lowerLabel
            // 
            this.lowerLabel.AutoSize = true;
            this.lowerLabel.Location = new System.Drawing.Point(606, 174);
            this.lowerLabel.Name = "lowerLabel";
            this.lowerLabel.Size = new System.Drawing.Size(0, 13);
            this.lowerLabel.TabIndex = 15;
            // 
            // upperLabel
            // 
            this.upperLabel.AutoSize = true;
            this.upperLabel.Location = new System.Drawing.Point(606, 123);
            this.upperLabel.Name = "upperLabel";
            this.upperLabel.Size = new System.Drawing.Size(0, 13);
            this.upperLabel.TabIndex = 14;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(606, 72);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 13);
            this.distanceLabel.TabIndex = 13;
            // 
            // fovLabel
            // 
            this.fovLabel.AutoSize = true;
            this.fovLabel.Location = new System.Drawing.Point(606, 21);
            this.fovLabel.Name = "fovLabel";
            this.fovLabel.Size = new System.Drawing.Size(0, 13);
            this.fovLabel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lateral Far";
            // 
            // FarLabel
            // 
            this.FarLabel.AutoSize = true;
            this.FarLabel.Location = new System.Drawing.Point(606, 276);
            this.FarLabel.Name = "FarLabel";
            this.FarLabel.Size = new System.Drawing.Size(0, 13);
            this.FarLabel.TabIndex = 19;
            // 
            // lateralFarSlider
            // 
            this.lateralFarSlider.Location = new System.Drawing.Point(290, 267);
            this.lateralFarSlider.Maximum = 50;
            this.lateralFarSlider.Name = "lateralFarSlider";
            this.lateralFarSlider.Size = new System.Drawing.Size(209, 45);
            this.lateralFarSlider.TabIndex = 21;
            this.lateralFarSlider.Scroll += new System.EventHandler(this.lateralFarSlider_Scroll);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 295);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(272, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load File";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 329);
            this.Controls.Add(this.lateralFarSlider);
            this.Controls.Add(this.FarLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nearLabel);
            this.Controls.Add(this.lowerLabel);
            this.Controls.Add(this.upperLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.fovLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lateralNearSlider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lowerHeightSlider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upperHightSlider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distanceSlider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fovSlider);
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
    }
}

