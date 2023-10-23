namespace _10_dan_buyuk_ve_cift_sayilari_listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sayilar = new int[5];
            label1.Text = "Dizinin 1. elemanýný giriniz:";
        }

        int[] sayilar;
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            if (i < 5)
            {
                label1.Text = "Dizinin " + (i + 2).ToString() + ". elemanýný giriniz:";
                sayilar[i] = Convert.ToInt16(textBox1.Text);
                i++;
                textBox1.Text = "";
            }
            if (i >= 5)
            {
                label1.Text = "Dizinin 10'dan büyük ve çift elemanlarýný listeleyin:";
                button1.Visible = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] >= 10 && sayilar[j] % 2 == 0)
                {
                    listBox1.Items.Add(sayilar[j]);
                }

            }
        }


    }
}