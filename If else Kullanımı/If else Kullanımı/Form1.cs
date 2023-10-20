namespace If_else_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);

            if (sayi % 2 == 0)
            {
                label2.Text = "Çift sayıdır.";
            }
            else
            {
                label2.Text = "Tek sayıdır.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}