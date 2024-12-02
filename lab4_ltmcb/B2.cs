using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_ltmcb
{
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }

        private void btDOWNLOAD_Click(object sender, EventArgs e)
        {
            if (tbPath.Text == "" || tbURL.Text == " ")
                MessageBox.Show("Ô Path hoặc URL đang để trống!", "THÔNG BÁO", MessageBoxButtons.OK);

            WebClient client = new WebClient();
            client.DownloadFile(tbURL.Text, tbPath.Text);
            rtbContent.Text = client.DownloadString(tbURL.Text);
        }





       
        private void btOPEN_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML|*.html";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                tbPath.Text = openFileDialog.FileName;
            }
        }

        private void btDELETE_Click_1(object sender, EventArgs e)
        {

            rtbContent.Text = " ";
            tbPath.Text = " ";
            tbURL.Text = " ";
        }

        private void btCLOSE_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MessageBox.Show("Bạn có chắc muốn thoát!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
