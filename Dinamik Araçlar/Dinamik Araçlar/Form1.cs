using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnKonum = new Point(20,10);
            btn.Location = btnKonum;
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.BlueViolet;
            btn.Height = 50;
            btn.Width = 75;
            this.Controls.Add(btn);

            Label lbl = new Label();
            Point lblKonum = new Point(20, 90);
            lbl.Location = lblKonum;
            lbl.Name = "Label1";
            lbl.Text = "Berna TAN";
            lbl.BackColor = Color.Bisque;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);

            for(int i = 0; i < 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtKonum = new Point(300, i * 30+15);
                txt.Location = txtKonum;
                this.Controls.Add(txt);
            }
        }
    }
}
