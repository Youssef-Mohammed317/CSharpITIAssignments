namespace ChatServer
{
    partial class ChatServerForm
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
            StartServerBtn = new Button();
            txtMsg = new TextBox();
            SendAllBtn = new Button();
            txtMsgReceived = new TextBox();
            SendSelected = new Button();
            usernamesList = new CheckedListBox();
            SuspendLayout();
            // 
            // StartServerBtn
            // 
            StartServerBtn.Dock = DockStyle.Top;
            StartServerBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartServerBtn.Location = new Point(0, 0);
            StartServerBtn.Name = "StartServerBtn";
            StartServerBtn.Size = new Size(679, 54);
            StartServerBtn.TabIndex = 0;
            StartServerBtn.Text = "Start Server";
            StartServerBtn.UseVisualStyleBackColor = true;
            StartServerBtn.Click += StartServerBtn_Click;
            // 
            // txtMsg
            // 
            txtMsg.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMsg.Location = new Point(12, 418);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(476, 131);
            txtMsg.TabIndex = 1;
            // 
            // SendAllBtn
            // 
            SendAllBtn.BackgroundImageLayout = ImageLayout.None;
            SendAllBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendAllBtn.Location = new Point(494, 499);
            SendAllBtn.Name = "SendAllBtn";
            SendAllBtn.Size = new Size(173, 50);
            SendAllBtn.TabIndex = 2;
            SendAllBtn.Text = "Send All";
            SendAllBtn.UseVisualStyleBackColor = true;
            SendAllBtn.Click += SendAllBtn_Click;
            // 
            // txtMsgReceived
            // 
            txtMsgReceived.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMsgReceived.Location = new Point(12, 58);
            txtMsgReceived.Multiline = true;
            txtMsgReceived.Name = "txtMsgReceived";
            txtMsgReceived.ReadOnly = true;
            txtMsgReceived.Size = new Size(476, 354);
            txtMsgReceived.TabIndex = 3;
            // 
            // SendSelected
            // 
            SendSelected.BackgroundImageLayout = ImageLayout.None;
            SendSelected.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendSelected.Location = new Point(494, 418);
            SendSelected.Name = "SendSelected";
            SendSelected.Size = new Size(173, 75);
            SendSelected.TabIndex = 4;
            SendSelected.Text = "Send Selected";
            SendSelected.UseVisualStyleBackColor = true;
            SendSelected.Click += SendSelected_Click;
            // 
            // usernamesList
            // 
            usernamesList.CheckOnClick = true;
            usernamesList.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamesList.FormattingEnabled = true;
            usernamesList.Location = new Point(494, 58);
            usernamesList.Name = "usernamesList";
            usernamesList.Size = new Size(173, 354);
            usernamesList.TabIndex = 6;
            // 
            // ChatServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 558);
            Controls.Add(usernamesList);
            Controls.Add(SendSelected);
            Controls.Add(txtMsgReceived);
            Controls.Add(SendAllBtn);
            Controls.Add(txtMsg);
            Controls.Add(StartServerBtn);
            Name = "ChatServerForm";
            Text = "ChatServerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartServerBtn;
        private TextBox txtMsg;
        private Button SendAllBtn;
        private TextBox txtMsgReceived;
        private Button SendSelected;
        private CheckedListBox usernamesList;
    }
}