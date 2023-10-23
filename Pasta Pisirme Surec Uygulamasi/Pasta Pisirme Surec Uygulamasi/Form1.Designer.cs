namespace Pasta_Pisirme_Surec_Uygulamasi
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            label5 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.Location = new Point(0, 51);
            progressBar1.Margin = new Padding(4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(737, 52);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(347, 20);
            label1.TabIndex = 1;
            label1.Text = "ŞEKER ve yumurta karıştırılıyor...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(253, 20);
            label2.TabIndex = 2;
            label2.Text = "ÇIRPMA İŞLEMİ YAPILIYOR...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 219);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 329);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 20);
            label4.TabIndex = 4;
            label4.Text = "PASTA PİŞİRİLİYOR...";
            // 
            // progressBar2
            // 
            progressBar2.BackColor = Color.White;
            progressBar2.Location = new Point(0, 154);
            progressBar2.Margin = new Padding(4);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(737, 52);
            progressBar2.TabIndex = 5;
            // 
            // progressBar3
            // 
            progressBar3.BackColor = Color.White;
            progressBar3.Location = new Point(0, 262);
            progressBar3.Margin = new Padding(4);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(737, 52);
            progressBar3.TabIndex = 6;
            // 
            // progressBar4
            // 
            progressBar4.BackColor = Color.White;
            progressBar4.Location = new Point(0, 364);
            progressBar4.Margin = new Padding(4);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(737, 52);
            progressBar4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 219);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(418, 20);
            label5.TabIndex = 8;
            label5.Text = "MALZEMELER EKLENİYOR VE KARIŞTIRILIYOR...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(736, 454);
            Controls.Add(label5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private Label label5;
    }
}