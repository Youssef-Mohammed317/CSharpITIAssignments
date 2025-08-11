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
    public partial class FrmMsg : Form
    {
        public event EventHandler SendMsg;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TxtMsg
        {
            get
            {
                return this.txtInfo.Text;
            }
            set
            {
                this.txtInfo.Text = value;
            }
        }
        public FrmMsg()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            SendMsg.Invoke(this,EventArgs.Empty);
        }
    }
}
