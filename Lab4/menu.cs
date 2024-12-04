using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class menu : Form
    {
        public menu()
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
