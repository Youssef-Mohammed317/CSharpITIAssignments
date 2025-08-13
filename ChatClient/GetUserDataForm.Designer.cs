namespace ChatClient
{
    partial class GetUserDataForm
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
            okBtn = new Button();
            txtName = new TextBox();
            cancelBtn = new Button();
            lbName = new Label();
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            okBtn.Location = new Point(196, 112);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(170, 62);
            okBtn.TabIndex = 0;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(100, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(266, 38);
            txtName.TabIndex = 1;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(12, 112);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(178, 62);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(12, 36);
            lbName.Name = "lbName";
            lbName.Size = new Size(82, 31);
            lbName.TabIndex = 3;
            lbName.Text = "Name:";
            // 
            // GetUserDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 201);
            Controls.Add(lbName);
            Controls.Add(cancelBtn);
            Controls.Add(txtName);
            Controls.Add(okBtn);
            Name = "GetUserDataForm";
            Text = "GetUserDataForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okBtn;
        private TextBox txtName;
        private Button cancelBtn;
        private Label lbName;
    }
}