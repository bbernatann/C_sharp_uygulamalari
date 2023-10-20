namespace Ogrenci_Sınav_Durumu_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int vize, final, proje;
            double ortalama;

            ad = txtAd.Text;
            soyad = txtSoyad.Text;

            vize = Convert.ToInt16(txtVize.Text);
            final = Convert.ToInt16(txtFinal.Text);
            proje = Convert.ToInt16(txtProje.Text);

            ortalama = (double)vize * 0.4 + (double)final * 0.5 + (double)proje * 0.1;

            if (ortalama >= 50)
            {
                listBox1.Items.Add ( ad + "\t" + soyad + "\t" + ortalama + "\tGEÇTİ\n");
            }
            else
            {
                listBox1.Items.Add (ad + "\t" + soyad + "\t" + ortalama + "\tKALDI\n");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtVize.Text = "";
            txtFinal.Text = "";
            txtProje.Text = "";
        }
    }
}