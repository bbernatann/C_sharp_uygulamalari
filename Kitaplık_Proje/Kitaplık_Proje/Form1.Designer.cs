namespace Kitaplık_Proje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapID = new System.Windows.Forms.TextBox();
            this.yazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sayfaSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonKullanılmis = new System.Windows.Forms.RadioButton();
            this.radioButtonSifir = new System.Windows.Forms.RadioButton();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.kitapAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kitapBul = new System.Windows.Forms.TextBox();
            this.KitapAdiBul = new System.Windows.Forms.Label();
            this.bul = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID:";
            // 
            // kitapID
            // 
            this.kitapID.Enabled = false;
            this.kitapID.Location = new System.Drawing.Point(152, 25);
            this.kitapID.Name = "kitapID";
            this.kitapID.Size = new System.Drawing.Size(158, 29);
            this.kitapID.TabIndex = 2;
            // 
            // yazar
            // 
            this.yazar.Location = new System.Drawing.Point(152, 94);
            this.yazar.Name = "yazar";
            this.yazar.Size = new System.Drawing.Size(158, 29);
            this.yazar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar:";
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.Location = new System.Drawing.Point(152, 169);
            this.sayfaSayisi.Name = "sayfaSayisi";
            this.sayfaSayisi.Size = new System.Drawing.Size(158, 29);
            this.sayfaSayisi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tür:";
            // 
            // tur
            // 
            this.tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tur.FormattingEnabled = true;
            this.tur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.tur.Location = new System.Drawing.Point(152, 131);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(158, 32);
            this.tur.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Durum:";
            // 
            // radioButtonKullanılmis
            // 
            this.radioButtonKullanılmis.AutoSize = true;
            this.radioButtonKullanılmis.Location = new System.Drawing.Point(152, 209);
            this.radioButtonKullanılmis.Name = "radioButtonKullanılmis";
            this.radioButtonKullanılmis.Size = new System.Drawing.Size(128, 28);
            this.radioButtonKullanılmis.TabIndex = 10;
            this.radioButtonKullanılmis.TabStop = true;
            this.radioButtonKullanılmis.Text = "Kullanılmış";
            this.radioButtonKullanılmis.UseVisualStyleBackColor = true;
            this.radioButtonKullanılmis.CheckedChanged += new System.EventHandler(this.radioButtonKullanılmis_CheckedChanged);
            // 
            // radioButtonSifir
            // 
            this.radioButtonSifir.AutoSize = true;
            this.radioButtonSifir.Location = new System.Drawing.Point(286, 209);
            this.radioButtonSifir.Name = "radioButtonSifir";
            this.radioButtonSifir.Size = new System.Drawing.Size(63, 28);
            this.radioButtonSifir.TabIndex = 11;
            this.radioButtonSifir.TabStop = true;
            this.radioButtonSifir.Text = "Sıfır";
            this.radioButtonSifir.UseVisualStyleBackColor = true;
            this.radioButtonSifir.CheckedChanged += new System.EventHandler(this.radioButtonSifir_CheckedChanged);
            // 
            // buttonListele
            // 
            this.buttonListele.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonListele.Location = new System.Drawing.Point(453, 15);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(132, 44);
            this.buttonListele.TabIndex = 12;
            this.buttonListele.Text = "Listele";
            this.buttonListele.UseVisualStyleBackColor = false;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonKaydet.Location = new System.Drawing.Point(453, 65);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(132, 44);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuncelle.Location = new System.Drawing.Point(453, 165);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(132, 44);
            this.buttonGuncelle.TabIndex = 14;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(453, 115);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(132, 44);
            this.buttonSil.TabIndex = 15;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // kitapAdi
            // 
            this.kitapAdi.Location = new System.Drawing.Point(152, 60);
            this.kitapAdi.Name = "kitapAdi";
            this.kitapAdi.Size = new System.Drawing.Size(158, 29);
            this.kitapAdi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kitap Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // kitapBul
            // 
            this.kitapBul.Location = new System.Drawing.Point(769, 220);
            this.kitapBul.Name = "kitapBul";
            this.kitapBul.Size = new System.Drawing.Size(158, 29);
            this.kitapBul.TabIndex = 20;
            // 
            // KitapAdiBul
            // 
            this.KitapAdiBul.AutoSize = true;
            this.KitapAdiBul.Location = new System.Drawing.Point(664, 225);
            this.KitapAdiBul.Name = "KitapAdiBul";
            this.KitapAdiBul.Size = new System.Drawing.Size(99, 24);
            this.KitapAdiBul.TabIndex = 19;
            this.KitapAdiBul.Text = "Kitap Adı:";
            // 
            // bul
            // 
            this.bul.BackColor = System.Drawing.Color.BlueViolet;
            this.bul.Location = new System.Drawing.Point(780, 255);
            this.bul.Name = "bul";
            this.bul.Size = new System.Drawing.Size(64, 33);
            this.bul.TabIndex = 21;
            this.bul.Text = "Bul";
            this.bul.UseVisualStyleBackColor = false;
            this.bul.Click += new System.EventHandler(this.bul_Click);
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.Green;
            this.ara.Location = new System.Drawing.Point(850, 255);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(64, 33);
            this.ara.TabIndex = 22;
            this.ara.Text = "Ara";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1098, 526);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.bul);
            this.Controls.Add(this.kitapBul);
            this.Controls.Add(this.KitapAdiBul);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kitapAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.radioButtonSifir);
            this.Controls.Add(this.radioButtonKullanılmis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.sayfaSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitapID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitapID;
        private System.Windows.Forms.TextBox yazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sayfaSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonKullanılmis;
        private System.Windows.Forms.RadioButton radioButtonSifir;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.TextBox kitapAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox kitapBul;
        private System.Windows.Forms.Label KitapAdiBul;
        private System.Windows.Forms.Button bul;
        private System.Windows.Forms.Button ara;
    }
}

