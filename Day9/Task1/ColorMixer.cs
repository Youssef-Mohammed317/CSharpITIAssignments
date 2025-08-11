using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day9
{
    public partial class ColorMixer : UserControl
    {
        Color color;

        public event EventHandler ColorChanged;

        public Color getColor { get
            {
                return color;
            } 
        }
        public ColorMixer()
        {
            InitializeComponent();
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            GetColor();
        }
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            GetColor();
        }

        void GetColor()
        {
            ColorChanged.Invoke(this, EventArgs.Empty);

            color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value,trackBarBlue.Value);

            lbTestColor.ForeColor = color;
        }
    }
}
