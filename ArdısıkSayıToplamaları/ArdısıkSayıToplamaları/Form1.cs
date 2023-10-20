namespace ArdısıkSayıToplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, num,result=0;
            num=Convert.ToInt16(textBox1.Text);

            for (i = 0; i <= num; i++)
            {
                result = result + i;
            }

            label3.Text=result.ToString();

        }
    }
}