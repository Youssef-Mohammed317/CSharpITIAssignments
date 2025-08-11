using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day9.Task3
{
    public partial class Form3 : Form
    {
        bool isOpened = false;
        FrmMsg frmMsg;
        public Form3()
        {
            InitializeComponent();
        }

        private void OpenFrmMsg_Click(object? sender,EventArgs e)
        {
            frmMsg = new FrmMsg();

            //frmMsg.ShowDialog();

            frmMsg.Show();

            frmMsg.SendMsg += FrmMsg_SendMsg;

            isOpened = true;
        }

        private void FrmMsg_SendMsg(object? sender, EventArgs e)
        {
            this.txtInfo.Text = frmMsg.TxtMsg;
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            this.lbInfo.Text = txtInfo.Text;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if(isOpened)
            {
                frmMsg.TxtMsg = txtInfo.Text;
            }
        }
    }
}
