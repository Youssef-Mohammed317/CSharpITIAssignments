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
    public partial class Form5 : Form
    {
        float x = 150;
        float y = 150;
        float width = 100;
        float height = 100;
        float regionLength = 10;
        Graphics gr;

        bool isHere = false;

        public Form5()
        {
            InitializeComponent();

            gr = this.CreateGraphics();

        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            gr.FillRectangle(Brushes.IndianRed, x, y, width, height);
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            if(e.X > x-regionLength && e.X < x+width+regionLength && e.Y > y-regionLength && e.Y < y+height+regionLength)
            {
                this.x += rand.Next(-1*(int)width,(int)width);
                this.y += rand.Next(-1*(int)height,(int)height);

                gr.Clear(BackColor);

                gr.FillRectangle(Brushes.Blue, x, y, width, height);
            }

        }
    }
}
