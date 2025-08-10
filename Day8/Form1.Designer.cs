namespace Day8
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
            traineesList = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            cmbLabBx = new ComboBox();
            labList = new CheckedListBox();
            MoveToLabBtn = new Button();
            button2 = new Button();
            MoveFromLab = new Button();
            MoveAllFromLab = new Button();
            SuspendLayout();
            // 
            // traineesList
            // 
            traineesList.CheckOnClick = true;
            traineesList.FormattingEnabled = true;
            traineesList.Location = new Point(12, 120);
            traineesList.Name = "traineesList";
            traineesList.Size = new Size(308, 378);
            traineesList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 52);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 1;
            label1.Text = "Trainees";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(618, 59);
            label2.Name = "label2";
            label2.Size = new Size(57, 31);
            label2.TabIndex = 2;
            label2.Text = "Lab:";
            // 
            // cmbLabBx
            // 
            cmbLabBx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbLabBx.FormattingEnabled = true;
            cmbLabBx.Location = new Point(686, 58);
            cmbLabBx.Name = "cmbLabBx";
            cmbLabBx.Size = new Size(193, 36);
            cmbLabBx.TabIndex = 3;
            cmbLabBx.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labList
            // 
            labList.CheckOnClick = true;
            labList.FormattingEnabled = true;
            labList.Location = new Point(618, 120);
            labList.Name = "labList";
            labList.Size = new Size(315, 378);
            labList.TabIndex = 4;
            // 
            // MoveToLabBtn
            // 
            MoveToLabBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoveToLabBtn.Location = new Point(415, 138);
            MoveToLabBtn.Name = "MoveToLabBtn";
            MoveToLabBtn.Size = new Size(101, 59);
            MoveToLabBtn.TabIndex = 5;
            MoveToLabBtn.Text = ">";
            MoveToLabBtn.UseVisualStyleBackColor = true;
            MoveToLabBtn.Click += MoveToLabBtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(415, 227);
            button2.Name = "button2";
            button2.Size = new Size(101, 59);
            button2.TabIndex = 6;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += MoveAllToLab_Click;
            // 
            // MoveFromLab
            // 
            MoveFromLab.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoveFromLab.Location = new Point(415, 318);
            MoveFromLab.Name = "MoveFromLab";
            MoveFromLab.Size = new Size(101, 59);
            MoveFromLab.TabIndex = 7;
            MoveFromLab.Text = "<";
            MoveFromLab.UseVisualStyleBackColor = true;
            MoveFromLab.Click += MoveFromLab_Click;
            // 
            // MoveAllFromLab
            // 
            MoveAllFromLab.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoveAllFromLab.Location = new Point(415, 413);
            MoveAllFromLab.Name = "MoveAllFromLab";
            MoveAllFromLab.Size = new Size(101, 59);
            MoveAllFromLab.TabIndex = 8;
            MoveAllFromLab.Text = "<<";
            MoveAllFromLab.UseVisualStyleBackColor = true;
            MoveAllFromLab.Click += MoveAllFromLab_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 517);
            Controls.Add(MoveAllFromLab);
            Controls.Add(MoveFromLab);
            Controls.Add(button2);
            Controls.Add(MoveToLabBtn);
            Controls.Add(labList);
            Controls.Add(cmbLabBx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(traineesList);
            Name = "Form1";
            Text = "Trainees";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox traineesList;
        private Label label1;
        private Label label2;
        private ComboBox cmbLabBx;
        private CheckedListBox labList;
        private Button MoveToLabBtn;
        private Button button2;
        private Button MoveFromLab;
        private Button MoveAllFromLab;
    }
}
