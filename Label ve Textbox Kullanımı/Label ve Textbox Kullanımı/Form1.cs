namespace Label_ve_Textbox_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Yazdır_Click(object sender, EventArgs e)
        {
            label4.Text = "BERNA";
            label5.Text = "TAN";
            label6.Text = "OGRENCI";
        }

        private void aktar_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}