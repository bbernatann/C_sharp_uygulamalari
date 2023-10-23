namespace Diziler
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
            String[] kisiler = { "Sema","Berna","Ahmet","Ceyda","Mert"};
            for(i = 0;i < kisiler.Length; i++)
            {
                listBox1.Items.Add((i+1)+"."+kisiler[i]);
            }

        }
    }
}