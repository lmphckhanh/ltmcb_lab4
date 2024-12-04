using System.Drawing;
using System.Windows.Forms;
namespace Lab4
{
    partial class menu
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
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(63, 49);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(133, 44);
            this.btnB1.TabIndex = 0;
            this.btnB1.Text = "BÀI 1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(63, 124);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(133, 49);
            this.btnB2.TabIndex = 1;
            this.btnB2.Text = "BÀI 2";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(262, 49);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(130, 44);
            this.btnB3.TabIndex = 2;
            this.btnB3.Text = "BÀI 3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 283);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Name = "menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnB1;
        private Button btnB2;
        private Button btnB3;
    }
}
