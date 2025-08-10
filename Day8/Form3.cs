using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
                Graphics gr = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                // paint

                //gr.FillRectangle(Brushes.IndianRed, e.X, e.Y, 1, 1);
                //gr.DrawRectangle(Pens.IndianRed, e.X, e.Y, 1, 1);

                gr.FillEllipse(Brushes.IndianRed, e.X, e.Y, 5f, 5f);

            }
            if (e.Button == MouseButtons.Right)
            {
                // erase
                SolidBrush brush = new SolidBrush(this.BackColor);
                gr.FillEllipse(brush, e.X, e.Y, 25f, 25f);
                
            }
        }

        private void Form3_Move(object sender, EventArgs e)
        {

        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            Form3_MouseClick(sender, e);
        }
    }
}
