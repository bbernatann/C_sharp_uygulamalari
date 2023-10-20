namespace Timer_ile_Dijital_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            saniye++;
            label1.Text = saniye.ToString();

            if (saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                label1.Text = "0";

                if (dakika == 60)
                {
                    saat++;
                    label3.Text = saat.ToString();
                    dakika = 0;
                    label2.Text = "0";
                }

            }
        }


    }
}