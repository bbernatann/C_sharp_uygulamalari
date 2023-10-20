namespace Timer_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Visible = false;
            sayac++;

            if (sayac <= 30)
            {
                this.BackColor = Color.Red;
            }
            if(sayac>30 && sayac <= 60)
            {
                this.BackColor= Color.Green;
            }
            if (sayac > 60)
            {
                this.BackColor=Color.Blue;
                if (sayac == 90)
                {
                    sayac = 0;
                }
            }

        }
    }
}