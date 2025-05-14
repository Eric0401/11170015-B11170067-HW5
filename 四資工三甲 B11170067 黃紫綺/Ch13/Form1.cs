namespace Ch13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.MouseDown += new MouseEventHandler(label1_MouseDown);
            label1.MouseLeave += new EventHandler(label1_MouseLeave);
            label1.BackColor = Color.Red; // �w�]����
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.BackColor = Color.Yellow; // ��������
            }
            else if (e.Button == MouseButtons.Right)
            {
                label1.BackColor = Color.Green; // �k�����
            }
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red; // �ƹ����}���ܦ^����
        }
    }
}
