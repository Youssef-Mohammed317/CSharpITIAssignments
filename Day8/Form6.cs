using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Day8
{
    public partial class Form6 : Form
    {
        Graphics gr;

        float x = 150;
        float y = 150;
        float radius = 30;
        bool isCrashedX = false;
        bool isCrashedY = false;
        Timer timer;
        public Form6()
        {
            InitializeComponent();

            gr = this.CreateGraphics();

            timer = new Timer();

            timer.Interval = 10;

            timer.Tick += OnTimerTick;

            timer.Start();

            this.Text = this.ClientSize.Width.ToString() + " + " + this.ClientSize.Height.ToString();
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            this.Validate();
            gr.Clear(BackColor);

            if (!isCrashedX) MoveRight();
            else MoveLeft();

            if (!isCrashedY) MoveDown();
            else MoveUp();

            gr.FillEllipse(Brushes.DarkCyan, x, y, radius * 2, radius * 2);
        }

        void MoveRight()
        {
            if (x + radius * 2 <= this.ClientSize.Width) x += 10;

            if (x + radius * 2 > this.ClientSize.Width) isCrashedX = true;
        }
        void MoveLeft()
        {
            if (x > 0) x -= 10;

            if (x <= 0) isCrashedX = false;     
        }
        void MoveDown()
        {
            if (y + radius * 2 <= this.ClientSize.Height) y += 10;

            if (y + radius * 2 > this.ClientSize.Height) isCrashedY = true;
        }
        void MoveUp()
        {
            if (y > 0) y -= 10;

            if (y <= 0) isCrashedY = false;     
        }


        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            gr.FillEllipse(Brushes.DarkCyan, x, y, radius * 2, radius * 2);
        }
        
    }
}
