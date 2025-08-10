using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7
{
    public partial class Form2 : Form
    {
        private User user;

        private bool registeredBefore = false;
        public Form2()
        {
            InitializeComponent();

            user = new User();

            this.HoppiesErrMsg.Visible = false;
            this.EmailErrMsg.Visible = false;
            this.NameErrMsg.Visible = false;
            this.SuccesResgisterMsg.Visible = false;
        }

        private void radBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemaleBtn.Checked == true)
            {
                user.Gender = GenderEnum.Female;
            }
            if (radMaleBtn.Checked == true)
            {
                user.Gender = GenderEnum.Male;
            }
        }

        private void checkHoppy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFootball.Checked == true)
            {
                user.Hoppies |= HoppiesEnum.Football;
            }
            else
            {
                user.Hoppies &= ~HoppiesEnum.Football;
            }
            if (checkTennis.Checked == true)
            {
                user.Hoppies |= HoppiesEnum.Tennis;
            }
            else
            {
                user.Hoppies &= ~HoppiesEnum.Tennis;
            }
            if (checkSwimming.Checked == true)
            {
                user.Hoppies |= HoppiesEnum.Swimming;
            }
            else
            {
                user.Hoppies &= ~HoppiesEnum.Swimming;
            }
            if(user.Hoppies != HoppiesEnum.None)
            {
                this.HoppiesErrMsg.Visible = false;
            }
            if (user.Hoppies == HoppiesEnum.None && registeredBefore)
            {
                this.HoppiesErrMsg.Visible = true;
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            bool flag = Check();
            this.Text = user.ToString();

            if(flag)
            {
                this.SuccesResgisterMsg.Visible = true;
            }
        }

        private void txtNameBox_TextChanged(object sender, EventArgs e)
        {
            if (txtNameBox.Text.Length >= 5)
            {
                user.Name = txtNameBox.Text;
                this.NameErrMsg.Visible = false;
            }
            else if (registeredBefore) this.NameErrMsg.Visible = true;    
        }

        private void txtEmailBox_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailBox.Text.Contains("@"))
            {
                user.Email = txtEmailBox.Text;
                this.EmailErrMsg.Visible = false;
            }
            else if (registeredBefore) this.EmailErrMsg.Visible = true;
        }

        private bool Check()
        {
            bool flag = true;
            if (user.Hoppies == HoppiesEnum.None)
            {
                this.HoppiesErrMsg.Visible = true;
                flag = false;
            }

            if (txtNameBox.Text.Length < 5)
            {
                this.NameErrMsg.Visible = true;
                flag = false;
            }
            if (!txtEmailBox.Text.Contains("@"))
            {
                this.EmailErrMsg.Visible = true;
                flag = false;
            }
        
            return flag;
        }

        private void Reset()
        {
            this.HoppiesErrMsg.Visible = false;
            this.EmailErrMsg.Visible = false;
            this.NameErrMsg.Visible = false;
            this.SuccesResgisterMsg.Visible = false;

            txtNameBox.Text = "";
            txtEmailBox.Text = "";
            radMaleBtn.Checked = true;
            radFemaleBtn.Checked = false;
            checkFootball.Checked = false;
            checkTennis.Checked = false;
            checkSwimming.Checked = false;
            registeredBefore = false;
        }
    }
}
