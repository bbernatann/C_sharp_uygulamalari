namespace Label_ve_Textbox_Kullanımı
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
            Yazdır = new Button();
            ad = new Label();
            soyad = new Label();
            meslek = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            aktar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Yazdır
            // 
            Yazdır.BackColor = Color.FromArgb(128, 255, 255);
            Yazdır.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Yazdır.ForeColor = SystemColors.ControlText;
            Yazdır.Location = new Point(65, 136);
            Yazdır.Name = "Yazdır";
            Yazdır.Size = new Size(124, 42);
            Yazdır.TabIndex = 0;
            Yazdır.Text = "Yazdır";
            Yazdır.UseVisualStyleBackColor = false;
            Yazdır.Click += Yazdır_Click;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ad.ForeColor = Color.Red;
            ad.Location = new Point(65, 31);
            ad.Name = "ad";
            ad.Size = new Size(56, 19);
            ad.TabIndex = 1;
            ad.Text = "Adınız:";
            // 
            // soyad
            // 
            soyad.AutoSize = true;
            soyad.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            soyad.ForeColor = Color.Red;
            soyad.Location = new Point(65, 58);
            soyad.Name = "soyad";
            soyad.Size = new Size(79, 19);
            soyad.TabIndex = 2;
            soyad.Text = "Soyadınız:";
            // 
            // meslek
            // 
            meslek.AutoSize = true;
            meslek.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            meslek.ForeColor = Color.Red;
            meslek.Location = new Point(65, 90);
            meslek.Name = "meslek";
            meslek.Size = new Size(62, 19);
            meslek.TabIndex = 3;
            meslek.Text = "Meslek:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(150, 31);
            label4.Name = "label4";
            label4.Size = new Size(47, 18);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(150, 59);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(150, 90);
            label6.Name = "label6";
            label6.Size = new Size(47, 18);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(ad);
            panel1.Controls.Add(Yazdır);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(soyad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(meslek);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(25, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 244);
            panel1.TabIndex = 7;
            // 
            // aktar
            // 
            aktar.BackColor = Color.FromArgb(128, 255, 255);
            aktar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aktar.ForeColor = SystemColors.ControlText;
            aktar.Location = new Point(149, 79);
            aktar.Name = "aktar";
            aktar.Size = new Size(124, 42);
            aktar.TabIndex = 8;
            aktar.Text = "Aktar";
            aktar.UseVisualStyleBackColor = false;
            aktar.Click += aktar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(129, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 149);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(aktar);
            panel2.Location = new Point(387, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 305);
            panel2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(888, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Yazdır;
        private Label ad;
        private Label soyad;
        private Label meslek;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Button aktar;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
    }
}