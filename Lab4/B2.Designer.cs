using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab4
{
    partial class B2
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btDOWNLOAD = new System.Windows.Forms.Button();
            this.btOPEN = new System.Windows.Forms.Button();
            this.btDELETE = new System.Windows.Forms.Button();
            this.btCLOSE = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbURL.Location = new System.Drawing.Point(43, 27);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(563, 39);
            this.tbURL.TabIndex = 0;
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPath.Location = new System.Drawing.Point(43, 83);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(563, 39);
            this.tbPath.TabIndex = 1;
            // 
            // btDOWNLOAD
            // 
            this.btDOWNLOAD.Location = new System.Drawing.Point(631, 12);
            this.btDOWNLOAD.Name = "btDOWNLOAD";
            this.btDOWNLOAD.Size = new System.Drawing.Size(116, 49);
            this.btDOWNLOAD.TabIndex = 3;
            this.btDOWNLOAD.Text = "DOWNLOAD";
            this.btDOWNLOAD.UseVisualStyleBackColor = true;
            this.btDOWNLOAD.Click += new System.EventHandler(this.btDOWNLOAD_Click);
            // 
            // btOPEN
            // 
            this.btOPEN.Location = new System.Drawing.Point(631, 76);
            this.btOPEN.Name = "btOPEN";
            this.btOPEN.Size = new System.Drawing.Size(116, 50);
            this.btOPEN.TabIndex = 4;
            this.btOPEN.Text = "OPEN";
            this.btOPEN.UseVisualStyleBackColor = true;
            this.btOPEN.Click += new System.EventHandler(this.btOPEN_Click_1);
            // 
            // btDELETE
            // 
            this.btDELETE.Location = new System.Drawing.Point(631, 136);
            this.btDELETE.Name = "btDELETE";
            this.btDELETE.Size = new System.Drawing.Size(116, 51);
            this.btDELETE.TabIndex = 5;
            this.btDELETE.Text = "DELETE";
            this.btDELETE.UseVisualStyleBackColor = true;
            this.btDELETE.Click += new System.EventHandler(this.btDELETE_Click_1);
            // 
            // btCLOSE
            // 
            this.btCLOSE.Location = new System.Drawing.Point(631, 203);
            this.btCLOSE.Name = "btCLOSE";
            this.btCLOSE.Size = new System.Drawing.Size(116, 49);
            this.btCLOSE.TabIndex = 6;
            this.btCLOSE.Text = "CLOSE";
            this.btCLOSE.UseVisualStyleBackColor = true;
            this.btCLOSE.Click += new System.EventHandler(this.btCLOSE_Click_1);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(43, 148);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbContent.Size = new System.Drawing.Size(563, 300);
            this.rtbContent.TabIndex = 7;
            this.rtbContent.Text = "";
            // 
            // B2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 463);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.btCLOSE);
            this.Controls.Add(this.btDELETE);
            this.Controls.Add(this.btOPEN);
            this.Controls.Add(this.btDOWNLOAD);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbURL);
            this.Name = "B2";
            this.Text = "B2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbURL;
        private TextBox tbPath;
        private Button btDOWNLOAD;
        private Button btOPEN;
        private Button btDELETE;
        private Button btCLOSE;
        private RichTextBox rtbContent;
    }
}