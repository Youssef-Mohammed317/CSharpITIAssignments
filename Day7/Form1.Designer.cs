namespace Day7
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            valTxtBox = new TextBox();
            resultTxtBox = new TextBox();
            label3 = new Label();
            radBtnMtKm = new RadioButton();
            radBtnMtMile = new RadioButton();
            radBtnMiletMeter = new RadioButton();
            Convert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 155);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 1;
            label1.Text = "Value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 239);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 2;
            label2.Text = "Result:";
            // 
            // valTxtBox
            // 
            valTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valTxtBox.Location = new Point(175, 155);
            valTxtBox.Name = "valTxtBox";
            valTxtBox.Size = new Size(145, 34);
            valTxtBox.TabIndex = 3;
            // 
            // resultTxtBox
            // 
            resultTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTxtBox.Location = new Point(175, 236);
            resultTxtBox.Name = "resultTxtBox";
            resultTxtBox.Size = new Size(145, 34);
            resultTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(466, 101);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 5;
            label3.Text = "Choose Unit";
            label3.Click += label3_Click;
            // 
            // radBtnMtKm
            // 
            radBtnMtKm.AutoSize = true;
            radBtnMtKm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radBtnMtKm.Location = new Point(440, 155);
            radBtnMtKm.Name = "radBtnMtKm";
            radBtnMtKm.Size = new Size(199, 32);
            radBtnMtKm.TabIndex = 6;
            radBtnMtKm.TabStop = true;
            radBtnMtKm.Text = "Meter to Kilometer";
            radBtnMtKm.UseVisualStyleBackColor = true;
            radBtnMtKm.CheckedChanged += radBtn_CheckedChanged;
            // 
            // radBtnMtMile
            // 
            radBtnMtMile.AutoSize = true;
            radBtnMtMile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radBtnMtMile.Location = new Point(440, 215);
            radBtnMtMile.Name = "radBtnMtMile";
            radBtnMtMile.Size = new Size(152, 32);
            radBtnMtMile.TabIndex = 7;
            radBtnMtMile.TabStop = true;
            radBtnMtMile.Text = "Meter to Mile";
            radBtnMtMile.UseVisualStyleBackColor = true;
            radBtnMtMile.CheckedChanged += radBtn_CheckedChanged;
            // 
            // radBtnMiletMeter
            // 
            radBtnMiletMeter.AutoSize = true;
            radBtnMiletMeter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radBtnMiletMeter.Location = new Point(440, 273);
            radBtnMiletMeter.Name = "radBtnMiletMeter";
            radBtnMiletMeter.Size = new Size(152, 32);
            radBtnMiletMeter.TabIndex = 8;
            radBtnMiletMeter.TabStop = true;
            radBtnMiletMeter.Text = "Mile to Meter";
            radBtnMiletMeter.UseVisualStyleBackColor = true;
            radBtnMiletMeter.CheckedChanged += radBtn_CheckedChanged;
            // 
            // Convert
            // 
            Convert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Convert.Location = new Point(254, 351);
            Convert.Name = "Convert";
            Convert.Size = new Size(203, 52);
            Convert.TabIndex = 9;
            Convert.Text = "Convert";
            Convert.UseVisualStyleBackColor = true;
            Convert.Click += Convert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(Convert);
            Controls.Add(radBtnMiletMeter);
            Controls.Add(radBtnMtMile);
            Controls.Add(radBtnMtKm);
            Controls.Add(label3);
            Controls.Add(resultTxtBox);
            Controls.Add(valTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox valTxtBox;
        private TextBox resultTxtBox;
        private Label label3;
        private RadioButton radBtnMtKm;
        private RadioButton radBtnMtMile;
        private RadioButton radBtnMiletMeter;
        private Button Convert;
    }
}
