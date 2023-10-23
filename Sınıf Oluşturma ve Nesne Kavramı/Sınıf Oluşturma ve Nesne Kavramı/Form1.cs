namespace Sınıf_Oluşturma_ve_Nesne_Kavramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba mstng1 = new Araba();

            mstng1.renk = "Gri";
            mstng1.hiz = 250;
            mstng1.motor = 1245.56;
            mstng1.durum = "2.El";
            mstng1.fiyat = 1123456;
            mstng1.YIL = 2018;
            mstng1.MARKA = "mustang";
            mstng1.muayene = 2022;
            mstng1.sahip = "MERT";
            mstng1.plaka = "55 BJK 1903";

            renk.Text = mstng1.renk;
            hiz.Text = mstng1.hiz.ToString();
            motor.Text = mstng1.motor.ToString();
            durum.Text = mstng1.durum.ToString();
            fiyat.Text = mstng1.fiyat.ToString();
            yil.Text = mstng1.YIL.ToString();
            marka.Text = mstng1.MARKA.ToString();
            muayeneYili.Text= mstng1.muayene.ToString();
            sahip.Text=mstng1.sahip;
            plakasi.Text=mstng1.plaka;

        }
    }
}