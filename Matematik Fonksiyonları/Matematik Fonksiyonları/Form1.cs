using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            mutlakDeger.Text=Math.Abs(sayi).ToString();
            usteYuvarlama.Text=Math.Ceiling(sayi).ToString();
            altaYuvarlama.Text = Math.Floor(sayi).ToString();
            usAlma.Text = Math.Pow(sayi, 3).ToString();
            karekokAlma.Text = Math.Sqrt(sayi).ToString();
        }
    }
}
// Math.Abs->Sayının mutlak değerini alır.
// Math.Ceiling->Üste yuvarlama.
// Math.Floor->Alta yuvarlama.
// Math.Pow->Üs alma.
// Math.Sqrt->Karekök alma.