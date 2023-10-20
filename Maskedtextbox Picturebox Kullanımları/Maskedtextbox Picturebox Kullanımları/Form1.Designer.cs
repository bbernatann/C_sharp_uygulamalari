namespace Maskedtextbox_Picturebox_Kullanımları
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
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            telefon = new Label();
            tc = new Label();
            tarih = new Label();
            saat = new Label();
            panel1 = new Panel();
            listBox1 = new ListBox();
            ekle = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            tarihEkle = new Button();
            panel2 = new Panel();
            listBox2 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(94, 24);
            maskedTextBox1.Margin = new Padding(4);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(187, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(94, 73);
            maskedTextBox2.Margin = new Padding(4);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(187, 27);
            maskedTextBox2.TabIndex = 1;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(94, 162);
            maskedTextBox3.Margin = new Padding(4);
            maskedTextBox3.Mask = "00:00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(187, 27);
            maskedTextBox3.TabIndex = 2;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(94, 118);
            maskedTextBox4.Margin = new Padding(4);
            maskedTextBox4.Mask = "00/00/0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(187, 27);
            maskedTextBox4.TabIndex = 3;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // telefon
            // 
            telefon.AutoSize = true;
            telefon.BackColor = Color.FromArgb(255, 192, 128);
            telefon.ForeColor = Color.Red;
            telefon.Location = new Point(14, 32);
            telefon.Margin = new Padding(4, 0, 4, 0);
            telefon.Name = "telefon";
            telefon.Size = new Size(64, 19);
            telefon.TabIndex = 4;
            telefon.Text = "Telefon:";
            // 
            // tc
            // 
            tc.AutoSize = true;
            tc.BackColor = Color.FromArgb(255, 192, 128);
            tc.ForeColor = Color.Red;
            tc.Location = new Point(14, 81);
            tc.Margin = new Padding(4, 0, 4, 0);
            tc.Name = "tc";
            tc.Size = new Size(30, 19);
            tc.TabIndex = 5;
            tc.Text = "TC:";
            // 
            // tarih
            // 
            tarih.AutoSize = true;
            tarih.BackColor = Color.FromArgb(255, 192, 128);
            tarih.ForeColor = Color.Red;
            tarih.Location = new Point(14, 126);
            tarih.Margin = new Padding(4, 0, 4, 0);
            tarih.Name = "tarih";
            tarih.Size = new Size(47, 19);
            tarih.TabIndex = 6;
            tarih.Text = "Tarih:";
            // 
            // saat
            // 
            saat.AutoSize = true;
            saat.BackColor = Color.FromArgb(255, 192, 128);
            saat.ForeColor = Color.Red;
            saat.Location = new Point(14, 170);
            saat.Margin = new Padding(4, 0, 4, 0);
            saat.Name = "saat";
            saat.Size = new Size(43, 19);
            saat.TabIndex = 7;
            saat.Text = "Saat:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(ekle);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(saat);
            panel1.Controls.Add(telefon);
            panel1.Controls.Add(maskedTextBox4);
            panel1.Controls.Add(tarih);
            panel1.Controls.Add(tc);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Location = new Point(12, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 507);
            panel1.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(23, 239);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(438, 251);
            listBox1.TabIndex = 12;
            // 
            // ekle
            // 
            ekle.BackColor = Color.DodgerBlue;
            ekle.Location = new Point(115, 196);
            ekle.Name = "ekle";
            ekle.Size = new Size(119, 37);
            ekle.TabIndex = 9;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = false;
            ekle.Click += ekle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(126, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 93);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(48, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // tarihEkle
            // 
            tarihEkle.BackColor = Color.DodgerBlue;
            tarihEkle.Location = new Point(143, 152);
            tarihEkle.Name = "tarihEkle";
            tarihEkle.Size = new Size(119, 37);
            tarihEkle.TabIndex = 11;
            tarihEkle.Text = "Tarih Ekle";
            tarihEkle.UseVisualStyleBackColor = false;
            tarihEkle.Click += tarihEkle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(tarihEkle);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(519, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 386);
            panel2.TabIndex = 13;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 19;
            listBox2.Location = new Point(48, 213);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(296, 156);
            listBox2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(916, 545);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label telefon;
        private Label tc;
        private Label tarih;
        private Label saat;
        private Panel panel1;
        private Button ekle;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button tarihEkle;
        private ListBox listBox1;
        private Panel panel2;
        private ListBox listBox2;
    }
}