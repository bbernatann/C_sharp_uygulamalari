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
            int sayi1, sayi2, toplam, fark, carp�m;
            double bolum;

            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carp�m = sayi1 * sayi2;
            bolum = (double)sayi1 / (double)sayi2;

            MessageBox.Show("Toplam:"+toplam+"\n"+"Fark:"+fark+"\n"+"�arp�m:"+carp�m+"\n"+"B�l�m:"+bolum);
        }
    }
}