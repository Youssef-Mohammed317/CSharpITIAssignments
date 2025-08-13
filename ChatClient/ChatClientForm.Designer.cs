namespace ChatClient
{
    partial class ChatClientForm
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
            ConnectBtn = new Button();
            txtMsg = new TextBox();
            SendBtn = new Button();
            txtMsgReceived = new TextBox();
            usernamesList = new CheckedListBox();
            lbConnecting = new Label();
            SuspendLayout();
            // 
            // ConnectBtn
            // 
            ConnectBtn.Dock = DockStyle.Top;
            ConnectBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConnectBtn.Location = new Point(0, 0);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(653, 64);
            ConnectBtn.TabIndex = 0;
            ConnectBtn.Text = "Connect";
            ConnectBtn.UseVisualStyleBackColor = true;
            ConnectBtn.Click += ConnectBtn_Click;
            // 
            // txtMsg
            // 
            txtMsg.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMsg.ImeMode = ImeMode.Off;
            txtMsg.Location = new Point(12, 430);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(474, 72);
            txtMsg.TabIndex = 1;
            // 
            // SendBtn
            // 
            SendBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBtn.Location = new Point(492, 430);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(149, 72);
            SendBtn.TabIndex = 2;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // txtMsgReceived
            // 
            txtMsgReceived.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMsgReceived.Location = new Point(12, 108);
            txtMsgReceived.Multiline = true;
            txtMsgReceived.Name = "txtMsgReceived";
            txtMsgReceived.ReadOnly = true;
            txtMsgReceived.Size = new Size(474, 316);
            txtMsgReceived.TabIndex = 4;
            // 
            // usernamesList
            // 
            usernamesList.CheckOnClick = true;
            usernamesList.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamesList.FormattingEnabled = true;
            usernamesList.Location = new Point(492, 70);
            usernamesList.Name = "usernamesList";
            usernamesList.Size = new Size(149, 354);
            usernamesList.TabIndex = 5;
            usernamesList.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lbConnecting
            // 
            lbConnecting.AutoSize = true;
            lbConnecting.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbConnecting.Location = new Point(12, 67);
            lbConnecting.Name = "lbConnecting";
            lbConnecting.Size = new Size(132, 31);
            lbConnecting.TabIndex = 6;
            lbConnecting.Text = "Connecting";
            // 
            // ChatClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 514);
            Controls.Add(lbConnecting);
            Controls.Add(usernamesList);
            Controls.Add(txtMsgReceived);
            Controls.Add(SendBtn);
            Controls.Add(txtMsg);
            Controls.Add(ConnectBtn);
            Name = "ChatClientForm";
            Text = "ChatClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConnectBtn;
        private TextBox txtMsg;
        private Button SendBtn;
        private TextBox txtMsgReceived;
        private CheckedListBox usernamesList;
        private Label lbConnecting;
    }
}