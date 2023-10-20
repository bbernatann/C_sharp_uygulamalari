namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            buttonSonraki.Text = "BAÞLA";

            richTextBox1.Text = "Yarýþmaya baþlamak için lütfen'BAÞLA' tuþuna basýnýz.";

        }
        int soruNo = 0, dogru = 0, yanlýs = 0;


        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            buttonSonraki.Text = "SONRAKÝ";
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            labelSoruNo.Enabled = true;

            soruNo++;
            labelSoruNo.Text = soruNo.ToString();


            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgesindedir?";
                buttonA.Text = "BALIKESÝR";
                buttonB.Text = "SAMSUN";
                buttonC.Text = "ÝSTANBUL";
                buttonD.Text = "ANKARA";
                label4.Text = "BALIKESÝR";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Kadýn milli takýmýmýzýn kaptaný kimdir?";
                buttonA.Text = "HANDE BALADIN";
                buttonB.Text = "ZEHRA GÜNEÞ";
                buttonC.Text = "EDA ERDEM";
                buttonD.Text = "MELÝSSA VARGAS";
                label4.Text = "EDA ERDEM";
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Tehlikeli Oyunlar kitabýmýzýn yazarý kimdir?";
                buttonA.Text = "MATT HAIG";
                buttonB.Text = "REÞAT NURÝ GÜNTEKÝN";
                buttonC.Text = "OÐUZ ATAY";
                buttonD.Text = "SABAHATTÝN ALÝ";
                label4.Text = "OÐUZ ATAY";
                buttonSonraki.Text = "SONUÇLAR";
            }
            if (soruNo == 5)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonSonraki.Enabled = false;

                soruNo = 0;

                MessageBox.Show("Doðru:" + dogru + "\nYanlýþ:" + yanlýs);
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlýs++;
                labelY.Text = yanlýs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlýs++;
                labelY.Text = yanlýs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlýs++;
                labelY.Text = yanlýs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlýs++;
                labelY.Text = yanlýs.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}