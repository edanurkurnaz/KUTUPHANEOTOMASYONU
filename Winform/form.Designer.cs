namespace KutuphaneOtomasyonWinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PERSONELGİRİŞBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ADGİRİSTXT = new System.Windows.Forms.TextBox();
            this.SİFREGİRİSTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // PERSONELGİRİŞBTN
            // 
            this.PERSONELGİRİŞBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PERSONELGİRİŞBTN.Location = new System.Drawing.Point(80, 250);
            this.PERSONELGİRİŞBTN.Name = "PERSONELGİRİŞBTN";
            this.PERSONELGİRİŞBTN.Size = new System.Drawing.Size(144, 23);
            this.PERSONELGİRİŞBTN.TabIndex = 4;
            this.PERSONELGİRİŞBTN.Text = "Giriş";
            this.PERSONELGİRİŞBTN.UseVisualStyleBackColor = false;
            this.PERSONELGİRİŞBTN.Click += new System.EventHandler(this.PERSONELGİRİSBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ADGİRİSTXT
            // 
            this.ADGİRİSTXT.Location = new System.Drawing.Point(80, 175);
            this.ADGİRİSTXT.Name = "ADGİRİSTXT";
            this.ADGİRİSTXT.Size = new System.Drawing.Size(144, 20);
            this.ADGİRİSTXT.TabIndex = 6;
          
            // 
            // SİFREGİRİSTXT
            // 
            this.SİFREGİRİSTXT.Location = new System.Drawing.Point(80, 212);
            this.SİFREGİRİSTXT.Name = "SİFREGİRİSTXT";
            this.SİFREGİRİSTXT.Size = new System.Drawing.Size(144, 20);
            this.SİFREGİRİSTXT.TabIndex = 7;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(293, 324);
            this.Controls.Add(this.SİFREGİRİSTXT);
            this.Controls.Add(this.ADGİRİSTXT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PERSONELGİRİŞBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
        
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PERSONELGİRİŞBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ADGİRİSTXT;
        private System.Windows.Forms.TextBox SİFREGİRİSTXT;
    }
}

