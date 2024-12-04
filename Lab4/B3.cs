using HtmlAgilityPack;
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
    public partial class B3 : Form
    {
        public B3()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack) webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward) webBrowser.GoForward();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text;

            if (url != null) webBrowser.Navigate(url);
        }

        HtmlAgilityPack.HtmlDocument htmlDocument;
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (webBrowser.Url == null) return;

            HtmlWeb web = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };
            htmlDocument = web.Load(webBrowser.Url);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (webBrowser.Url == null) return;
            HtmlNode node = htmlDocument.DocumentNode;
            MessageBox.Show(node.InnerHtml, "Html Document");
        }
    }
}
