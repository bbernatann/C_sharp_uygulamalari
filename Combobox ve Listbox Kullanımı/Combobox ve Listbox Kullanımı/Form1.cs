namespace Combobox_ve_Listbox_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(ad.Text + "\t" + soyad.Text + "\t  " + sehir.Text + "\t" + meslek.Text + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(sehir.Text);
        }
    }
}