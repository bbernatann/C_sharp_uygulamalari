namespace String_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sehir;
            sehir = textBox1.Text;
            label1.Text = sehir;
        }
    }
}