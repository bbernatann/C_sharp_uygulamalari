namespace Öğrenci_Sınav_Notları_Hesaplama_Uygulaması
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
            int not1, not2, proje;
            double ortalama;

            ad = textBox1.Text;
            soyad = textBox2.Text;

            not1 = Convert.ToInt32(textBox3.Text);
            not2 = Convert.ToInt32(textBox4.Text);
            proje = Convert.ToInt32(textBox5.Text);

            ortalama = (double)not1 * 0.4 + (double)not2 * 0.5 + (double)proje * 0.1;

            listBox1.Items.Add(ad + "\t" + soyad + "\t" + "Ortalama:" + ortalama);

        }
    }
}