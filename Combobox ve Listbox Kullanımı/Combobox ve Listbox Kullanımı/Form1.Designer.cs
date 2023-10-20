namespace Combobox_ve_Listbox_Kullanımı
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ad = new TextBox();
            soyad = new TextBox();
            sehir = new TextBox();
            meslek = new TextBox();
            panel1 = new Panel();
            listBox1 = new ListBox();
            ekle = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(32, 19);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(34, 133);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 2;
            label3.Text = "Şehir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(34, 185);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 3;
            label4.Text = "Meslek:";
            // 
            // ad
            // 
            ad.BackColor = Color.White;
            ad.Location = new Point(109, 22);
            ad.Name = "ad";
            ad.Size = new Size(148, 27);
            ad.TabIndex = 4;
            // 
            // soyad
            // 
            soyad.Location = new Point(109, 71);
            soyad.Name = "soyad";
            soyad.Size = new Size(148, 27);
            soyad.TabIndex = 5;
            // 
            // sehir
            // 
            sehir.Location = new Point(109, 125);
            sehir.Name = "sehir";
            sehir.Size = new Size(148, 27);
            sehir.TabIndex = 6;
            // 
            // meslek
            // 
            meslek.BackColor = Color.White;
            meslek.Location = new Point(109, 177);
            meslek.Name = "meslek";
            meslek.Size = new Size(148, 27);
            meslek.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(ekle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(meslek);
            panel1.Controls.Add(soyad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(sehir);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ad);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 313);
            panel1.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(273, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(418, 289);
            listBox1.TabIndex = 10;
            // 
            // ekle
            // 
            ekle.BackColor = Color.FromArgb(255, 192, 128);
            ekle.Location = new Point(72, 233);
            ekle.Name = "ekle";
            ekle.Size = new Size(134, 37);
            ekle.TabIndex = 9;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = false;
            ekle.Click += ekle_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(762, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 27);
            comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(762, 28);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 10;
            label5.Text = "Şehirler:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Location = new Point(762, 113);
            button1.Name = "button1";
            button1.Size = new Size(134, 37);
            button1.TabIndex = 11;
            button1.Text = "Şehir Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(939, 493);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ad;
        private TextBox soyad;
        private TextBox sehir;
        private TextBox meslek;
        private Panel panel1;
        private ListBox listBox1;
        private Button ekle;
        private ComboBox comboBox1;
        private Label label5;
        private Button button1;
    }
}