namespace Foreach_Dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sinavlar = { 100, 87, 56, 55, 47, 94 };

            foreach (int x in sinavlar)
            {
                listBox1.Items.Add(x);
                toplam = toplam + x;
            }

            label3.Text = toplam.ToString();
            double ortalama = (double)toplam / sinavlar.Length;
            label4.Text = ortalama.ToString();
        }
    }
}