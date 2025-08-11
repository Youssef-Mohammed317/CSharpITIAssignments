

namespace Day9.Task3
{
    partial class Form3
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
            lbInfo = new Label();
            txtInfo = new TextBox();
            SendBtn = new Button();
            OpenFrmMsg = new Button();
            SuspendLayout();
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInfo.Location = new Point(142, 59);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(79, 31);
            lbInfo.TabIndex = 0;
            lbInfo.Text = "label1";
            // 
            // txtInfo
            // 
            txtInfo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInfo.Location = new Point(142, 162);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(319, 38);
            txtInfo.TabIndex = 1;
            txtInfo.TextChanged += txtInfo_TextChanged;
            // 
            // SendBtn
            // 
            SendBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBtn.Location = new Point(500, 156);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(143, 51);
            SendBtn.TabIndex = 2;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // OpenFrmMsg
            // 
            OpenFrmMsg.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OpenFrmMsg.Location = new Point(411, 39);
            OpenFrmMsg.Name = "OpenFrmMsg";
            OpenFrmMsg.Size = new Size(232, 51);
            OpenFrmMsg.TabIndex = 3;
            OpenFrmMsg.Text = "Open Form Msg";
            OpenFrmMsg.UseVisualStyleBackColor = true;
            OpenFrmMsg.Click += OpenFrmMsg_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OpenFrmMsg);
            Controls.Add(SendBtn);
            Controls.Add(txtInfo);
            Controls.Add(lbInfo);
            Name = "Form3";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Label lbInfo;
        private TextBox txtInfo;
        private Button SendBtn;
        private Button OpenFrmMsg;
    }
}