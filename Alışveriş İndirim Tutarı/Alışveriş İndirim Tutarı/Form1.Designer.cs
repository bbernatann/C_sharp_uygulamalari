namespace Alışveriş_İndirim_Tutarı
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
            label1 = new Label();
            label2 = new Label();
            tutar = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adedi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 194);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Tutar:";
            // 
            // tutar
            // 
            tutar.AutoSize = true;
            tutar.Location = new Point(323, 194);
            tutar.Margin = new Padding(4, 0, 4, 0);
            tutar.Name = "tutar";
            tutar.Size = new Size(53, 21);
            tutar.TabIndex = 2;
            tutar.Text = "00 TL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 130);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 29);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(299, 252);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 4;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(735, 471);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tutar);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label tutar;
        private TextBox textBox1;
        private Button button1;
    }
}