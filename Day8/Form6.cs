using Microsoft.VisualBasic;
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

        float XRect = 0;
        float YRect = 0;
        float width = 250;
        float height = 40;
        bool isCrashRectangle = false;

        public Form6()
        {
            InitializeComponent();



            gr = this.CreateGraphics();


            timer = new Timer();

            timer.Interval = 20;

            timer.Tick += OnTimerTick;

            timer.Start();
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            if (!isCrashedX) MoveRight();
            else MoveLeft();

            if (!isCrashedY) MoveDown();
            else MoveUp();

            ReDrawGame();
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

            if (y + radius * 2 > this.ClientSize.Height - height - 20)
            {
                if (x > XRect && x < XRect + width)
                {
                    isCrashedY = true;
                }
                else
                {
                    timer.Stop();
                    DialogResult result = MessageBox.Show(
                            "Game Over",
                            "OK",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                    );
                }
            }
        }
            void MoveUp()
        {
            if (y > 0) y -= 10;

            if (y <= 0) isCrashedY = false;
        }


        private void Form6_Paint(object sender, PaintEventArgs e)
        {

            //gr.FillEllipse(Brushes.DarkCyan, x, y, radius * 2, radius * 2);

            XRect = this.ClientSize.Width / 2 - width / 2;
            YRect = this.ClientSize.Height - height - 20;

            gr.FillRectangle(Brushes.IndianRed, XRect, YRect, width, height);
        }

        private void Form6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                if(XRect + width + 20 < this.ClientSize.Width) XRect += 25;
                ReDrawGame();
            }
            if(e.KeyCode == Keys.Left)
            {
                if (XRect > 20) XRect -= 25;
                ReDrawGame();
            }

        }

        void ReDrawGame()
        {
            this.Validate();
            gr.Clear(BackColor);
            gr.FillEllipse(Brushes.DarkCyan, x, y, radius * 2, radius * 2);
            gr.FillRectangle(Brushes.IndianRed, XRect, YRect, width, height);
        }
    }
}
