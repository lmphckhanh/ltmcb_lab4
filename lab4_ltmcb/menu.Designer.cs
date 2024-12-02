namespace lab4_ltmcb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnB1 = new Button();
            btnB2 = new Button();
            btnB3 = new Button();
            SuspendLayout();
            // 
            // btnB1
            // 
            btnB1.Location = new Point(56, 49);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(118, 44);
            btnB1.TabIndex = 0;
            btnB1.Text = "BÀI 1";
            btnB1.UseVisualStyleBackColor = true;
            btnB1.Click += btnB1_Click;
            // 
            // btnB2
            // 
            btnB2.Location = new Point(56, 124);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(118, 49);
            btnB2.TabIndex = 1;
            btnB2.Text = "BÀI 2";
            btnB2.UseVisualStyleBackColor = true;
            btnB2.Click += btnB2_Click;
            // 
            // btnB3
            // 
            btnB3.Location = new Point(233, 49);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(116, 44);
            btnB3.TabIndex = 2;
            btnB3.Text = "BÀI 3";
            btnB3.UseVisualStyleBackColor = true;
            btnB3.Click += btnB3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 283);
            Controls.Add(btnB3);
            Controls.Add(btnB2);
            Controls.Add(btnB1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnB1;
        private Button btnB2;
        private Button btnB3;
    }
}
