namespace Alışveriş_İndirim_Tutarı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //0-20 -> %20 İNDİRİM
        //21-40 -> %40 İNDİRİM
        //41++ -> %50 İNDİRİM
        //KİTAP FİYATI ->55 TL
        private void button1_Click(object sender, EventArgs e)
        {
            int kitapAdedi;
            double ucret;

            kitapAdedi = Convert.ToInt16(textBox1.Text);

            if (kitapAdedi < 0)
            {
                MessageBox.Show("0'dan az kitap adedi girilemez.");
            }
            else if (kitapAdedi >= 0 && kitapAdedi <= 20)
            {
                ucret = (55 * kitapAdedi)-(55 * kitapAdedi*0.2);
                tutar.Text = ucret + " TL";
            }
            else if (kitapAdedi > 20 && kitapAdedi <= 40)
            {
                ucret = (55 * kitapAdedi) - (55 * kitapAdedi * 0.4);
                tutar.Text = ucret + " TL";
            }
            else
            {
                ucret = (55 * kitapAdedi) - (55 * kitapAdedi * 0.5);
                tutar.Text = ucret + " TL";
            }

        }
    }
}