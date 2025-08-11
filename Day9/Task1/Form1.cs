namespace Day9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackColor_Load(object sender, EventArgs e)
        {
            BackColor = trackColor.getColor;
        }

        private void TrackColor_ColorChanged(object sender, EventArgs e)
        {
            BackColor = trackColor.getColor;
        }
    }
}
