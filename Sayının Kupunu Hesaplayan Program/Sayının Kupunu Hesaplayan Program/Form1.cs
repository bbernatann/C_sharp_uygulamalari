namespace Sayının_Kupunu_Hesaplayan_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kupHesaplama(int num)
        {
            textBox1.Text = "";
            
            int result;
            result = num * num * num;
            
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(textBox1.Text);

            label3.Text = kupHesaplama(num).ToString();
        
        }
    }
}