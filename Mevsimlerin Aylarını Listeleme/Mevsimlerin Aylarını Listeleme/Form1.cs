namespace Mevsimlerin_Aylarını_Listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim;
            mevsim = textBox1.Text;

            switch (mevsim)
            {
                case "İLKBAHAR": label2.Text = "MART \nNİSAN \nMAYIS"; break;
                case "YAZ": label2.Text = "HAZİRAN \nTEMMUZ \nAĞUSTOS"; break;
                case "SONBAHAR": label2.Text = "EYLÜL \nEKİM \nKASIM"; break;
                case "KIŞ": label2.Text = "ARALIK \nOCAK \nŞUBAT"; break;
                default: label2.Text = "MEVSİM GİRİNİZ!"; break;
            }
        }
    }
}