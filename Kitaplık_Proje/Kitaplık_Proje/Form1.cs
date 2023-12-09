using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Kitaplık_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\BERNA TAN\\Desktop\\C#\\Access Veri Tabanı\\Kitaplık.accdb\"");
        
        void Listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);//Sütünu otomatik boyutlandırır.
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);//Satırı otomatik boyutlandırır.


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        string durum = ""; 
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kaydet = new OleDbCommand("INSERT INTO Kitaplar (KitapAdı, Yazar, Tur, SayfaSayisi, Durum) VALUES  (@p1,@p2,@p3,@p4,@p5)",baglanti );
            kaydet.Parameters.AddWithValue("@p1", kitapAdi.Text);
            kaydet.Parameters.AddWithValue("@p2", yazar.Text);
            kaydet.Parameters.AddWithValue("@p3", tur.Text);
            kaydet.Parameters.AddWithValue("@p4", sayfaSayisi.Text);
            kaydet.Parameters.AddWithValue("@p5",durum);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap sisteme kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void radioButtonKullanılmis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";//Kullanılmış olanın kutucuğunu işaretliyor.
        }

        private void radioButtonSifir_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        //Data Grid de seçilen kutucuğun bilgilerini textlere ve comboboxa aktarıyor.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            kitapID.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kitapAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            sayfaSayisi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButtonKullanılmis.Checked = true;
            }
            else
            {
                radioButtonSifir.Checked = true;
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete From Kitaplar Where kitapID=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",kitapID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap listeden silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kitaplar SET KitapAdı=@p1,Yazar=@p2,Tur=@p3,SayfaSayisi=@p4,Durum=@p5 WHERE KitapID=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", kitapAdi.Text);
            komut.Parameters.AddWithValue("@p2", yazar.Text);
            komut.Parameters.AddWithValue("@p3", tur.Text);
            komut.Parameters.AddWithValue("@p4", sayfaSayisi.Text);

            if (radioButtonKullanılmis.Checked == true)
            {
                durum = "1";
                komut.Parameters.AddWithValue("@p5", durum);
            }
            else
            {
                durum = "0";
                komut.Parameters.AddWithValue("@p5", durum);
            }

            
            komut.Parameters.AddWithValue("@p6", kitapID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void bul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitaplar WHERE KitapAdı=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", kitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitaplar WHERE KitapAdı like '%"+ kitapBul.Text +"%'",baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
// Project/Kitaplık_Proje Properties/Platform Target x64 yapınca çalışıyor.