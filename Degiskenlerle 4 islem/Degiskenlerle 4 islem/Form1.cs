namespace Degiskenlerle_4_islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, fark, carpým;
            double bolum;

            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpým = sayi1 * sayi2;
            bolum = (double)sayi1 / (double)sayi2;

            MessageBox.Show("Toplam:"+toplam+"\n"+"Fark:"+fark+"\n"+"Çarpým:"+carpým+"\n"+"Bölüm:"+bolum);
        }
    }
}