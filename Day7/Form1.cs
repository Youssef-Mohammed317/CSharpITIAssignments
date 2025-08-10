namespace Day7
{
    public partial class Form1 : Form
    {
        private float result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radBtnMtKm_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radBtn_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = float.TryParse(this.valTxtBox.Text, out float val);

            //if(!flag)
            //{
            //    this.valTxtBox.Text = "0";
            //    this.result = 0;
            //    return;
            //}

            if(radBtnMiletMeter.Checked)
            {
                this.result = val * 1500f;
            }
            else if(radBtnMtKm.Checked)
            {
                this.result = val * 0.001f;
            }else if(radBtnMtMile.Checked)
            {
                this.result = val / 1500f;
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
           
            
            this.resultTxtBox.Text = this.result.ToString();
        }
    }
}
