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
    public partial class Form4 : Form
    {
        private bool isDragging = false;

        private float x = 100;
        private float y = 100;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = this.CreateGraphics();

            gr.FillRectangle(Brushes.IndianRed, x - 50,y - 50, 100, 100);

        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = this.CreateGraphics();


            if (e.X >= x - 50 && e.X <= 100 + x - 50 && e.Y >= y - 50 && e.Y <= 100 + y - 50)
            {
                gr.FillRectangle(Brushes.Blue, x - 50, y - 50, 100, 100);
                this.Cursor = Cursors.Hand;
            }
            else
            {
                gr.FillRectangle(Brushes.IndianRed, x - 50, y - 50, 100, 100);
                this.Cursor = Cursors.Arrow;
            }


            if (isDragging)
            {
                x = e.X; y = e.Y;
                gr.FillRectangle(Brushes.IndianRed, x - 50, y - 50, 100, 100);
                this.Cursor = Cursors.Hand;
                this.Invalidate();
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics gr = this.CreateGraphics();

            if (e.Button == MouseButtons.Left)
            {
                this.isDragging = true;
            }

            if (e.X >= x - 50 && e.X <= 100 + x - 50 && e.Y >= y - 50 && e.Y <= 100 + y - 50)
            {
                gr.FillRectangle(Brushes.IndianRed, x - 50, y - 50, 100, 100);
                this.Cursor = Cursors.Hand;
            }
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDragging = false;
        }
    }
}
