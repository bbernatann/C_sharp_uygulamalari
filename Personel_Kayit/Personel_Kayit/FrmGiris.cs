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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JC5MMNJ\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True;");


        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yönetici Where KullaniciAd=@p1 And Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullanıcıAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ve Şifre!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}
