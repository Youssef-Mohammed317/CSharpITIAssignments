namespace Day8
{
    partial class Form2
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtStdName = new TextBox();
            txtStdPhone = new TextBox();
            StdBirthDate = new DateTimePicker();
            addStd = new Button();
            SaveStdBtn = new Button();
            stdView = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 50);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(513, 255);
            label3.Name = "label3";
            label3.Size = new Size(0, 31);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 131);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 3;
            label2.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 218);
            label4.Name = "label4";
            label4.Size = new Size(117, 31);
            label4.TabIndex = 4;
            label4.Text = "Birthdate:";
            // 
            // txtStdName
            // 
            txtStdName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStdName.Location = new Point(145, 47);
            txtStdName.Name = "txtStdName";
            txtStdName.Size = new Size(254, 38);
            txtStdName.TabIndex = 5;
            // 
            // txtStdPhone
            // 
            txtStdPhone.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStdPhone.Location = new Point(145, 131);
            txtStdPhone.Name = "txtStdPhone";
            txtStdPhone.Size = new Size(254, 38);
            txtStdPhone.TabIndex = 6;
            // 
            // StdBirthDate
            // 
            StdBirthDate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StdBirthDate.Location = new Point(145, 218);
            StdBirthDate.Name = "StdBirthDate";
            StdBirthDate.Size = new Size(436, 38);
            StdBirthDate.TabIndex = 7;
            // 
            // addStd
            // 
            addStd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStd.Location = new Point(86, 399);
            addStd.Name = "addStd";
            addStd.Size = new Size(130, 56);
            addStd.TabIndex = 8;
            addStd.Text = "Add";
            addStd.UseVisualStyleBackColor = true;
            addStd.Click += addStd_Click;
            // 
            // SaveStdBtn
            // 
            SaveStdBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveStdBtn.ForeColor = Color.Red;
            SaveStdBtn.Location = new Point(296, 399);
            SaveStdBtn.Name = "SaveStdBtn";
            SaveStdBtn.Size = new Size(130, 56);
            SaveStdBtn.TabIndex = 9;
            SaveStdBtn.Text = "Save";
            SaveStdBtn.UseVisualStyleBackColor = true;
            SaveStdBtn.Click += SaveStdBtn_Click;
            // 
            // stdView
            // 
            stdView.Location = new Point(627, 47);
            stdView.Name = "stdView";
            stdView.Size = new Size(422, 301);
            stdView.TabIndex = 11;
            stdView.UseCompatibleStateImageBehavior = false;
            stdView.View = View.Details;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 540);
            Controls.Add(stdView);
            Controls.Add(SaveStdBtn);
            Controls.Add(addStd);
            Controls.Add(StdBirthDate);
            Controls.Add(txtStdPhone);
            Controls.Add(txtStdName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtStdName;
        private TextBox txtStdPhone;
        private DateTimePicker StdBirthDate;
        private Button addStd;
        private Button SaveStdBtn;
        private ListView stdView;
    }
}