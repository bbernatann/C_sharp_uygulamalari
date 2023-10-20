namespace Maskedtextbox_Picturebox_Kullanımları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text+"\t"+maskedTextBox2.Text + "\t" + maskedTextBox3.Text+ "\t" + maskedTextBox4.Text+"\n");
        }

        private void tarihEkle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(dateTimePicker1.Text+"\n");
        }
    }
}