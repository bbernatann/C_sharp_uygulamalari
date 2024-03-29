﻿using System;
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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JC5MMNJ\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True;");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //grafik1
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Sehir,Count(*) From Tbl_Personel Group By Sehir",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            //garfik2
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Meslek,Avg(Maas) From Tbl_Personel Group By Meslek",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }
    }
}
