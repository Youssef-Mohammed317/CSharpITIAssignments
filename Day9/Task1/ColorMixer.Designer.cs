namespace Day9
{
    partial class ColorMixer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            trackBarRed = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbTestColor = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            SuspendLayout();
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(118, 93);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Orientation = Orientation.Vertical;
            trackBarGreen.Size = new Size(56, 217);
            trackBarGreen.TabIndex = 0;
            trackBarGreen.Scroll += trackBar_Scroll;
            trackBarGreen.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(201, 93);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Orientation = Orientation.Vertical;
            trackBarBlue.Size = new Size(56, 217);
            trackBarBlue.TabIndex = 1;
            trackBarBlue.Scroll += trackBar_Scroll;
            trackBarBlue.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(34, 93);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Orientation = Orientation.Vertical;
            trackBarRed.Size = new Size(56, 217);
            trackBarRed.TabIndex = 2;
            trackBarRed.Scroll += trackBar_Scroll;
            trackBarRed.ValueChanged += trackBar_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 324);
            label1.Name = "label1";
            label1.Size = new Size(28, 31);
            label1.TabIndex = 3;
            label1.Text = "B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(118, 324);
            label2.Name = "label2";
            label2.Size = new Size(30, 31);
            label2.TabIndex = 4;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 324);
            label3.Name = "label3";
            label3.Size = new Size(28, 31);
            label3.TabIndex = 5;
            label3.Text = "R";
            // 
            // lbTestColor
            // 
            lbTestColor.AutoSize = true;
            lbTestColor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTestColor.Location = new Point(35, 34);
            lbTestColor.Name = "lbTestColor";
            lbTestColor.Size = new Size(207, 31);
            lbTestColor.TabIndex = 6;
            lbTestColor.Text = "RGB Color Tracker";
            // 
            // TrackColor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbTestColor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBarRed);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Name = "TrackColor";
            Size = new Size(293, 383);
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private TrackBar trackBarRed;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbTestColor;
    }
}
