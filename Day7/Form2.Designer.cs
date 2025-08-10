namespace Day7
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameErrMsg = new Label();
            txtNameBox = new TextBox();
            txtEmailBox = new TextBox();
            EmailErrMsg = new Label();
            HoppiesErrMsg = new Label();
            SuccesResgisterMsg = new Label();
            radMaleBtn = new RadioButton();
            radFemaleBtn = new RadioButton();
            checkFootball = new CheckBox();
            checkTennis = new CheckBox();
            checkSwimming = new CheckBox();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 40);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 127);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 214);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 290);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 3;
            label4.Text = "Hoppies:";
            // 
            // NameErrMsg
            // 
            NameErrMsg.AutoSize = true;
            NameErrMsg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameErrMsg.ForeColor = Color.Red;
            NameErrMsg.Location = new Point(397, 40);
            NameErrMsg.Name = "NameErrMsg";
            NameErrMsg.Size = new Size(376, 28);
            NameErrMsg.TabIndex = 4;
            NameErrMsg.Text = "Name must contain at least 5 characters";
            // 
            // txtNameBox
            // 
            txtNameBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameBox.Location = new Point(172, 40);
            txtNameBox.Name = "txtNameBox";
            txtNameBox.Size = new Size(197, 34);
            txtNameBox.TabIndex = 5;
            txtNameBox.TextChanged += txtNameBox_TextChanged;
            // 
            // txtEmailBox
            // 
            txtEmailBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmailBox.Location = new Point(172, 127);
            txtEmailBox.Name = "txtEmailBox";
            txtEmailBox.Size = new Size(197, 34);
            txtEmailBox.TabIndex = 6;
            txtEmailBox.TextChanged += txtEmailBox_TextChanged;
            // 
            // EmailErrMsg
            // 
            EmailErrMsg.AutoSize = true;
            EmailErrMsg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailErrMsg.ForeColor = Color.Red;
            EmailErrMsg.Location = new Point(397, 133);
            EmailErrMsg.Name = "EmailErrMsg";
            EmailErrMsg.Size = new Size(204, 28);
            EmailErrMsg.TabIndex = 7;
            EmailErrMsg.Text = "Email nust contain @";
            // 
            // HoppiesErrMsg
            // 
            HoppiesErrMsg.AutoSize = true;
            HoppiesErrMsg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HoppiesErrMsg.ForeColor = Color.Red;
            HoppiesErrMsg.Location = new Point(556, 291);
            HoppiesErrMsg.Name = "HoppiesErrMsg";
            HoppiesErrMsg.Size = new Size(256, 28);
            HoppiesErrMsg.TabIndex = 8;
            HoppiesErrMsg.Text = "Choose at least one hoppy";
            // 
            // SuccesResgisterMsg
            // 
            SuccesResgisterMsg.AutoSize = true;
            SuccesResgisterMsg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuccesResgisterMsg.ForeColor = Color.Green;
            SuccesResgisterMsg.Location = new Point(252, 443);
            SuccesResgisterMsg.Name = "SuccesResgisterMsg";
            SuccesResgisterMsg.Size = new Size(349, 28);
            SuccesResgisterMsg.TabIndex = 9;
            SuccesResgisterMsg.Text = "Thank you, Your registeration is valid";
            // 
            // radMaleBtn
            // 
            radMaleBtn.AutoSize = true;
            radMaleBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radMaleBtn.Location = new Point(186, 214);
            radMaleBtn.Name = "radMaleBtn";
            radMaleBtn.Size = new Size(77, 32);
            radMaleBtn.TabIndex = 10;
            radMaleBtn.Text = "Male";
            radMaleBtn.UseVisualStyleBackColor = true;
            radMaleBtn.CheckedChanged += radBtn_CheckedChanged;
            // 
            // radFemaleBtn
            // 
            radFemaleBtn.AutoSize = true;
            radFemaleBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radFemaleBtn.Location = new Point(297, 214);
            radFemaleBtn.Name = "radFemaleBtn";
            radFemaleBtn.Size = new Size(98, 32);
            radFemaleBtn.TabIndex = 11;
            radFemaleBtn.Text = "Female";
            radFemaleBtn.UseVisualStyleBackColor = true;
            radFemaleBtn.CheckedChanged += radBtn_CheckedChanged;
            // 
            // checkFootball
            // 
            checkFootball.AutoSize = true;
            checkFootball.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkFootball.Location = new Point(186, 293);
            checkFootball.Name = "checkFootball";
            checkFootball.Size = new Size(107, 32);
            checkFootball.TabIndex = 12;
            checkFootball.Text = "Football";
            checkFootball.UseVisualStyleBackColor = true;
            checkFootball.CheckedChanged += checkHoppy_CheckedChanged;
            // 
            // checkTennis
            // 
            checkTennis.AutoSize = true;
            checkTennis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkTennis.Location = new Point(297, 290);
            checkTennis.Name = "checkTennis";
            checkTennis.Size = new Size(92, 32);
            checkTennis.TabIndex = 13;
            checkTennis.Text = "Tennis";
            checkTennis.UseVisualStyleBackColor = true;
            checkTennis.CheckedChanged += checkHoppy_CheckedChanged;
            // 
            // checkSwimming
            // 
            checkSwimming.AutoSize = true;
            checkSwimming.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkSwimming.Location = new Point(397, 289);
            checkSwimming.Name = "checkSwimming";
            checkSwimming.Size = new Size(130, 32);
            checkSwimming.TabIndex = 14;
            checkSwimming.Text = "Swimming";
            checkSwimming.UseVisualStyleBackColor = true;
            checkSwimming.CheckedChanged += checkHoppy_CheckedChanged;
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.Location = new Point(327, 371);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(170, 39);
            registerBtn.TabIndex = 15;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 497);
            Controls.Add(registerBtn);
            Controls.Add(checkSwimming);
            Controls.Add(checkTennis);
            Controls.Add(checkFootball);
            Controls.Add(radFemaleBtn);
            Controls.Add(radMaleBtn);
            Controls.Add(SuccesResgisterMsg);
            Controls.Add(HoppiesErrMsg);
            Controls.Add(EmailErrMsg);
            Controls.Add(txtEmailBox);
            Controls.Add(txtNameBox);
            Controls.Add(NameErrMsg);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label NameErrMsg;
        private TextBox txtNameBox;
        private TextBox txtEmailBox;
        private Label EmailErrMsg;
        private Label HoppiesErrMsg;
        private Label SuccesResgisterMsg;
        private RadioButton radMaleBtn;
        private RadioButton radFemaleBtn;
        private CheckBox checkFootball;
        private CheckBox checkTennis;
        private CheckBox checkSwimming;
        private Button registerBtn;
    }
}