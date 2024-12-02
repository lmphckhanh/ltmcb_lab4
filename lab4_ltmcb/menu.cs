namespace lab4_ltmcb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            Form bai01 = new B1();
            bai01.ShowDialog();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            Form bai02 = new B2();
            bai02.ShowDialog();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            Form bai03 = new B3();
            bai03.ShowDialog();
        }
    }
}
