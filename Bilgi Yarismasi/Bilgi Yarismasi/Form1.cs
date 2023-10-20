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

            buttonSonraki.Text = "BA�LA";

            richTextBox1.Text = "Yar��maya ba�lamak i�in l�tfen'BA�LA' tu�una bas�n�z.";

        }
        int soruNo = 0, dogru = 0, yanl�s = 0;


        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            buttonSonraki.Text = "SONRAK�";
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
                richTextBox1.Text = "Cumhuriyet ka� y�l�nda ilan edilmi�tir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege b�lgesindedir?";
                buttonA.Text = "BALIKES�R";
                buttonB.Text = "SAMSUN";
                buttonC.Text = "�STANBUL";
                buttonD.Text = "ANKARA";
                label4.Text = "BALIKES�R";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Kad�n milli tak�m�m�z�n kaptan� kimdir?";
                buttonA.Text = "HANDE BALADIN";
                buttonB.Text = "ZEHRA G�NE�";
                buttonC.Text = "EDA ERDEM";
                buttonD.Text = "MEL�SSA VARGAS";
                label4.Text = "EDA ERDEM";
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Tehlikeli Oyunlar kitab�m�z�n yazar� kimdir?";
                buttonA.Text = "MATT HAIG";
                buttonB.Text = "RE�AT NUR� G�NTEK�N";
                buttonC.Text = "O�UZ ATAY";
                buttonD.Text = "SABAHATT�N AL�";
                label4.Text = "O�UZ ATAY";
                buttonSonraki.Text = "SONU�LAR";
            }
            if (soruNo == 5)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonSonraki.Enabled = false;

                soruNo = 0;

                MessageBox.Show("Do�ru:" + dogru + "\nYanl��:" + yanl�s);
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
                yanl�s++;
                labelY.Text = yanl�s.ToString();
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
                yanl�s++;
                labelY.Text = yanl�s.ToString();
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
                yanl�s++;
                labelY.Text = yanl�s.ToString();
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
                yanl�s++;
                labelY.Text = yanl�s.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}