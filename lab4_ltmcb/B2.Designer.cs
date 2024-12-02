namespace lab4_ltmcb
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
            tbURL = new TextBox();
            tbPath = new TextBox();
            btDOWNLOAD = new Button();
            btOPEN = new Button();
            btDELETE = new Button();
            btCLOSE = new Button();
            rtbContent = new RichTextBox();
            SuspendLayout();
            // 
            // tbURL
            // 
            tbURL.Font = new Font("Segoe UI", 12F);
            tbURL.Location = new Point(38, 27);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(501, 34);
            tbURL.TabIndex = 0;
            // 
            // tbPath
            // 
            tbPath.Font = new Font("Segoe UI", 12F);
            tbPath.Location = new Point(38, 83);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(501, 34);
            tbPath.TabIndex = 1;
            // 
            // btDOWNLOAD
            // 
            btDOWNLOAD.Location = new Point(561, 12);
            btDOWNLOAD.Name = "btDOWNLOAD";
            btDOWNLOAD.Size = new Size(103, 49);
            btDOWNLOAD.TabIndex = 3;
            btDOWNLOAD.Text = "DOWNLOAD";
            btDOWNLOAD.UseVisualStyleBackColor = true;
            btDOWNLOAD.Click += btDOWNLOAD_Click;
            // 
            // btOPEN
            // 
            btOPEN.Location = new Point(561, 76);
            btOPEN.Name = "btOPEN";
            btOPEN.Size = new Size(103, 50);
            btOPEN.TabIndex = 4;
            btOPEN.Text = "OPEN";
            btOPEN.UseVisualStyleBackColor = true;
            btOPEN.Click += btOPEN_Click_1;
            // 
            // btDELETE
            // 
            btDELETE.Location = new Point(561, 136);
            btDELETE.Name = "btDELETE";
            btDELETE.Size = new Size(103, 51);
            btDELETE.TabIndex = 5;
            btDELETE.Text = "DELETE";
            btDELETE.UseVisualStyleBackColor = true;
            btDELETE.Click += btDELETE_Click_1;
            // 
            // btCLOSE
            // 
            btCLOSE.Location = new Point(561, 203);
            btCLOSE.Name = "btCLOSE";
            btCLOSE.Size = new Size(103, 49);
            btCLOSE.TabIndex = 6;
            btCLOSE.Text = "CLOSE";
            btCLOSE.UseVisualStyleBackColor = true;
            btCLOSE.Click += btCLOSE_Click_1;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(38, 148);
            rtbContent.Name = "rtbContent";
            rtbContent.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbContent.Size = new Size(501, 300);
            rtbContent.TabIndex = 7;
            rtbContent.Text = "";
            // 
            // B2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 463);
            Controls.Add(rtbContent);
            Controls.Add(btCLOSE);
            Controls.Add(btDELETE);
            Controls.Add(btOPEN);
            Controls.Add(btDOWNLOAD);
            Controls.Add(tbPath);
            Controls.Add(tbURL);
            Name = "B2";
            Text = "B2";
            ResumeLayout(false);
            PerformLayout();
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