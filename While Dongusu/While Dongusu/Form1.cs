namespace While_Dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Girilen say�ya kadar olan say�lar� toplay�p ekrana yazd�rmaya yarayan kod.
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, sayi, toplam = 0;

            sayi = Convert.ToInt16(textBox1.Text);

            while (i <= sayi)
            {
                toplam = toplam + i;
                i++;
            }

            lblSonuc.Text = toplam.ToString();
        }
    }
}