using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class GetUserDataForm : Form
    {
        public event Action<string> UserDataOkay;
        public GetUserDataForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null || txtName.Text != "")
            {
                UserDataOkay.Invoke(txtName.Text ?? "Unknown");
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
