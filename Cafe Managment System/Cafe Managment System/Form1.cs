namespace Cafe_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGeust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard ds = new DashBoard("Guest");
            ds.Show();
            this.Hide();
        }
    }
}