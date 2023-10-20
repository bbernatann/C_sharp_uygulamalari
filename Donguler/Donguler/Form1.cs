namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for(i= 1; i <= 10;i+=5)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}