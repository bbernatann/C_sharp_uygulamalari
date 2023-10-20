namespace Karar_Yapıları_ile_Dongu_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, i;

            sayi=Convert.ToInt16(textBox1.Text);

            for(i=1;i<=sayi;i++)
            {
                if(sayi%i==0)
                {
                    listBox1.Items.Add(i);
                }
            }

        }
    }
}