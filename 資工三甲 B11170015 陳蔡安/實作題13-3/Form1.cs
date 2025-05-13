namespace 實作題13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void traffic_light_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                traffic_light.BackColor = Color.Yellow;
                timer1.Start();
            }
            else if (e.Button == MouseButtons.Right)
            {
                traffic_light.BackColor = Color.Green;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            traffic_light.BackColor = Color.Red;
            timer1.Stop();
        }
    }
}
