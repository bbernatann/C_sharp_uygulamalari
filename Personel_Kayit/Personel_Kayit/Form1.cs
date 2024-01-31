using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JC5MMNJ\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True;");


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelDataSet4.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelDataSet4.Tbl_Personel);

        }
        void Listele()
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelDataSet4.Tbl_Personel);
        }
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelDataSet4.Tbl_Personel);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personel (Ad,Soyad,Sehir,Maas,Durum,Meslek) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtBox_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBox_Sehir.Text);
            komut.Parameters.AddWithValue("@p4",txtBox_Maas.Text);
            if (radioButton_Evli.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5",1);
            }
            else
            {
                komut.Parameters.AddWithValue("@p5", 0);
            }
            komut.Parameters.AddWithValue("@p6",txtBox_Meslek.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi.", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txtBox_Id.Text = " ";
            txtBox_Ad.Text = " ";
            txtBox_Soyad.Text = " ";
            comboBox_Sehir.Text = "";
            txtBox_Maas.Text = "";
            txtBox_Meslek.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBox_Id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBox_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBox_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox_Sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtBox_Maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString()=="True")
            {
                radioButton_Evli.Checked = true;
            }
            else
            {
                radioButton_Bekar.Checked = true;
            }
            txtBox_Meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Personel WHERE Id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBox_Id.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel silindi.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            Listele();
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Personel SET Ad=@p1, Soyad=@p2, Sehir=@p3, Maas=@p4, Durum=@p5, Meslek=@p6 WHERE Id=@p0", baglanti);
            komut.Parameters.AddWithValue("@p0", txtBox_Id.Text);
            komut.Parameters.AddWithValue("@p1", txtBox_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBox_Sehir.Text);
            komut.Parameters.AddWithValue("@p4", txtBox_Maas.Text);

            if (radioButton_Evli.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", 1);
            }
            else
            {
                komut.Parameters.AddWithValue("@p5", 0);
            }

            komut.Parameters.AddWithValue("@p6", txtBox_Meslek.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btn_Istatisitk_Click(object sender, EventArgs e)
        {
            FrmIstatisitik frmIstatisitik = new FrmIstatisitik();
            frmIstatisitik.Show();
        }

        private void btn_Grafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGarfikler = new FrmGrafikler();
            frmGarfikler.Show();
        }
    }
}
