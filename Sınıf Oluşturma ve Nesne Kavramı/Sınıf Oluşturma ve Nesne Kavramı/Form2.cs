using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_Oluşturma_ve_Nesne_Kavramı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba mstng2 = new Araba();

            mstng2.renk = "Siyah";
            mstng2.hiz = 300;
            mstng2.motor = 1567.94;
            mstng2.durum = "0";
            mstng2.fiyat = 1545645;
            mstng2.YIL = 2020;
            mstng2.MARKA = "mustang";
            mstng2.muayene = 2023;
            mstng2.sahip = "BERNA";
            mstng2.plaka = "55 BT 0002";

            renk.Text = mstng2.renk;
            hiz.Text = mstng2.hiz.ToString();
            motor.Text = mstng2.motor.ToString();
            durum.Text = mstng2.durum.ToString();
            fiyat.Text = mstng2.fiyat.ToString();
            yil.Text = mstng2.YIL.ToString();
            marka.Text = mstng2.MARKA.ToString();
            muayeneYili.Text=mstng2.muayene.ToString();
            sahip.Text=mstng2.sahip;
            plakasi.Text=mstng2.plaka;
        }
    }
}
