namespace Day9.Task3
{
    partial class FrmMsg
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
            txtInfo = new TextBox();
            SendBtn = new Button();
            SuspendLayout();
            // 
            // txtInfo
            // 
            txtInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInfo.Location = new Point(92, 182);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(337, 38);
            txtInfo.TabIndex = 0;
            // 
            // SendBtn
            // 
            SendBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBtn.Location = new Point(486, 175);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(143, 51);
            SendBtn.TabIndex = 3;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // FrmMsg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendBtn);
            Controls.Add(txtInfo);
            Name = "FrmMsg";
            Text = "FrmMsg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInfo;
        private Button SendBtn;
    }
}