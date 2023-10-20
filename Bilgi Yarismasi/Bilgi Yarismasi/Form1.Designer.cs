namespace Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            buttonA = new Button();
            buttonC = new Button();
            buttonB = new Button();
            buttonD = new Button();
            labelSoruNo = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSonraki = new Button();
            labelD = new Label();
            labelY = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(100, -1);
            richTextBox1.Margin = new Padding(5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(415, 239);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // buttonA
            // 
            buttonA.Location = new Point(100, 250);
            buttonA.Margin = new Padding(3, 4, 3, 4);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(196, 64);
            buttonA.TabIndex = 1;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonA_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(100, 335);
            buttonC.Margin = new Padding(3, 4, 3, 4);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(196, 64);
            buttonC.TabIndex = 2;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(320, 250);
            buttonB.Margin = new Padding(3, 4, 3, 4);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(195, 64);
            buttonB.TabIndex = 3;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += buttonB_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(320, 335);
            buttonD.Margin = new Padding(3, 4, 3, 4);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(195, 64);
            buttonD.TabIndex = 4;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // labelSoruNo
            // 
            labelSoruNo.AutoSize = true;
            labelSoruNo.Location = new Point(66, -1);
            labelSoruNo.Name = "labelSoruNo";
            labelSoruNo.Size = new Size(24, 26);
            labelSoruNo.TabIndex = 5;
            labelSoruNo.Text = "0";
            labelSoruNo.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 34);
            label2.Name = "label2";
            label2.Size = new Size(77, 26);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 96);
            label3.Name = "label3";
            label3.Size = new Size(73, 26);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // buttonSonraki
            // 
            buttonSonraki.Location = new Point(578, 164);
            buttonSonraki.Margin = new Padding(3, 4, 3, 4);
            buttonSonraki.Name = "buttonSonraki";
            buttonSonraki.Size = new Size(146, 64);
            buttonSonraki.TabIndex = 8;
            buttonSonraki.Text = "Sonraki";
            buttonSonraki.UseVisualStyleBackColor = true;
            buttonSonraki.Click += buttonSonraki_Click;
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Location = new Point(626, 34);
            labelD.Name = "labelD";
            labelD.Size = new Size(24, 26);
            labelD.TabIndex = 9;
            labelD.Text = "0";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(626, 96);
            labelY.Name = "labelY";
            labelY.Size = new Size(24, 26);
            labelY.TabIndex = 10;
            labelY.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(609, 273);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(609, 273);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(578, 417);
            label4.Name = "label4";
            label4.Size = new Size(71, 26);
            label4.TabIndex = 13;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(689, 417);
            label5.Name = "label5";
            label5.Size = new Size(71, 26);
            label5.TabIndex = 14;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(820, 523);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelY);
            Controls.Add(labelD);
            Controls.Add(buttonSonraki);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelSoruNo);
            Controls.Add(buttonD);
            Controls.Add(buttonB);
            Controls.Add(buttonC);
            Controls.Add(buttonA);
            Controls.Add(richTextBox1);
            Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonA;
        private Button buttonC;
        private Button buttonB;
        private Button buttonD;
        private Label labelSoruNo;
        private Label label2;
        private Label label3;
        private Button buttonSonraki;
        private Label labelD;
        private Label labelY;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}