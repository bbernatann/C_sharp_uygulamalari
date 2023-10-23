namespace Geriye_Deger_Döndürmeyen_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void renklendir()
        {
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.Bisque;
            textBox3.BackColor = Color.LightSteelBlue;
            textBox4.BackColor = Color.YellowGreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}