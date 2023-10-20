namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, su, cay, bilet, toplam;

            mısır = Convert.ToInt16(txtMısır.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);
            bilet = Convert.ToInt16(txtBilet.Text);

            toplam = mısır * 50 + su * 5 + cay * 15 + bilet * 70;

            lblToplamTutar.Text = toplam.ToString() + "TL";

            kasa = kasa + toplam;
            lblKasa.Text = kasa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = " ";
            txtSu.Text = " ";
            txtCay.Text= "";
            txtMısır.Text = "";

        }
    }
}