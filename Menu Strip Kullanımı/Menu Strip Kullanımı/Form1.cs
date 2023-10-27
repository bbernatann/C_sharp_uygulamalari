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

namespace Menu_Strip_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.LightGreen;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Berna TAN tarafından yapıldı.","Bilgi",MessageBoxButtons.OK);
        }

        private void hızlıVeÖfkeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "HIZLI VE ÖFKELİ 10";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=RnJbSIqOQCE&t=7s");
        }

        private void labirentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "LABİRENT";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=2uBWdfvKpjc");
        }

        private void kalplerimizBirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "KALPLERİMİZ BİR";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=WTLgg8oRSBE");
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "AYNI YILDIZIN ALTINDA";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aQnlngjZG48");
        }

        private void gerçekKahramanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "GERÇEK KAHRAMAN";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=svat1CFNxdw");
        }

        private void yarınınSavaşıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "YARININ SAVAŞI";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=3TzN1vZ_a6M");
        }

        private void sessizBirYerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "SESSİZ BİR YER";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7QFMIPRs2Lc");
        }
    }
}
