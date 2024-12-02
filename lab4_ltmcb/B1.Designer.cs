namespace lab4_ltmcb
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
            tbAddress = new TextBox();
            btnGet = new Button();
            rtbResponse = new RichTextBox();
            SuspendLayout();
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(22, 33);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(491, 27);
            tbAddress.TabIndex = 0;
            tbAddress.Text = "https://www.uit.edu.vn/";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(544, 25);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(112, 43);
            btnGet.TabIndex = 1;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // rtbResponse
            // 
            rtbResponse.Location = new Point(22, 90);
            rtbResponse.Name = "rtbResponse";
            rtbResponse.Size = new Size(634, 288);
            rtbResponse.TabIndex = 2;
            rtbResponse.Text = "";
            // 
            // B1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 390);
            Controls.Add(rtbResponse);
            Controls.Add(btnGet);
            Controls.Add(tbAddress);
            Name = "B1";
            Text = "B1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAddress;
        private Button btnGet;
        private RichTextBox rtbResponse;
    }
}