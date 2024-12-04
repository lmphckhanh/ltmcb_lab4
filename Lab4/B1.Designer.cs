using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab4
{
    partial class B1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(25, 33);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(552, 26);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.Text = "https://www.uit.edu.vn/";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(612, 25);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(126, 43);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // rtbResponse
            // 
            this.rtbResponse.Location = new System.Drawing.Point(25, 90);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(713, 288);
            this.rtbResponse.TabIndex = 2;
            this.rtbResponse.Text = "";
            // 
            // B1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 390);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.tbAddress);
            this.Name = "B1";
            this.Text = "B1";
            this.Click += new System.EventHandler(this.btnGet_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbAddress;
        private Button btnGet;
        private RichTextBox rtbResponse;
    }
}