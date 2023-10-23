namespace _4_e_bölünen_sayilari_listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0, toplam = 0;
            int[] sayilar = { 12, 24, 38, 45, 4, 23, 58, 95, 65, 68 };

            label2.Visible = true;
            label4.Visible = true;

            foreach (int i in sayilar)
            {
                if (i % 4 == 0)
                {
                    listBox1.Items.Add(i);
                    toplam = toplam + i;
                    j++;
                }
            }

            label2.Text = j.ToString();
            label4.Text = toplam.ToString();

        }
    }
}