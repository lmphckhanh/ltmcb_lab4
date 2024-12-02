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
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string address = tbAddress.Text;

            // Send request
            WebRequest request = WebRequest.Create(address);

            // Get respond from request
            WebResponse response = request.GetResponse();

            // Get stream from Response
            Stream dataStream = response.GetResponseStream();

            // Read stream
            StreamReader reader = new StreamReader(dataStream);

            // Stream to string
            string string_responseFromServer = reader.ReadToEnd();

            response.Close();

            rtbResponse.Text = string_responseFromServer;
        }
    }
}
