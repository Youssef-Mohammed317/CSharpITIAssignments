using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Day9.Task2
{
    public partial class DigitalClock : Control
    {
        public DigitalClock()
        {
            InitializeComponent();

            Timer timer = new Timer();

            timer.Interval = 1000;

            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Repaint();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Repaint();
        }
        void Repaint()
        {
            Graphics gr = this.CreateGraphics();

            gr.FillRectangle(Brushes.Yellow, 0, 0, this.Width, this.Height);

            string timer = DateTime.Now.ToString("hh:mm:ss");

            SizeF sizeF = gr.MeasureString(timer, this.Font);

            gr.DrawString(timer, this.Font, Brushes.Black, (this.Width - sizeF.Width) / 2, (this.Height - sizeF.Height) / 2);
        }
    }
}
