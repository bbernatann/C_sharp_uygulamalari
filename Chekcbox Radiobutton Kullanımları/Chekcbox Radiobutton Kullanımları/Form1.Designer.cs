namespace Chekcbox_Radiobutton_Kullanımları
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
            mısır = new CheckBox();
            zeytin = new CheckBox();
            mantar = new CheckBox();
            small = new RadioButton();
            medium = new RadioButton();
            large = new RadioButton();
            sosis = new CheckBox();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            sec = new Button();
            groupBox2 = new GroupBox();
            ekle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mısır
            // 
            mısır.AutoSize = true;
            mısır.Location = new Point(7, 28);
            mısır.Margin = new Padding(4);
            mısır.Name = "mısır";
            mısır.Size = new Size(62, 23);
            mısır.TabIndex = 0;
            mısır.Text = "mısır";
            mısır.UseVisualStyleBackColor = true;
            // 
            // zeytin
            // 
            zeytin.AutoSize = true;
            zeytin.Location = new Point(7, 59);
            zeytin.Margin = new Padding(4);
            zeytin.Name = "zeytin";
            zeytin.Size = new Size(70, 23);
            zeytin.TabIndex = 1;
            zeytin.Text = "zeytin";
            zeytin.UseVisualStyleBackColor = true;
            // 
            // mantar
            // 
            mantar.AutoSize = true;
            mantar.Location = new Point(7, 90);
            mantar.Margin = new Padding(4);
            mantar.Name = "mantar";
            mantar.Size = new Size(78, 23);
            mantar.TabIndex = 2;
            mantar.Text = "mantar";
            mantar.UseVisualStyleBackColor = true;
            // 
            // small
            // 
            small.AutoSize = true;
            small.Location = new Point(15, 25);
            small.Name = "small";
            small.Size = new Size(64, 23);
            small.TabIndex = 4;
            small.TabStop = true;
            small.Text = "Small";
            small.UseVisualStyleBackColor = true;
            small.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // medium
            // 
            medium.AutoSize = true;
            medium.Location = new Point(15, 68);
            medium.Name = "medium";
            medium.Size = new Size(84, 23);
            medium.TabIndex = 5;
            medium.TabStop = true;
            medium.Text = "Medium";
            medium.UseVisualStyleBackColor = true;
            // 
            // large
            // 
            large.AutoSize = true;
            large.Location = new Point(15, 108);
            large.Name = "large";
            large.Size = new Size(66, 23);
            large.TabIndex = 6;
            large.TabStop = true;
            large.Text = "Large";
            large.UseVisualStyleBackColor = true;
            // 
            // sosis
            // 
            sosis.AutoSize = true;
            sosis.Location = new Point(7, 121);
            sosis.Margin = new Padding(4);
            sosis.Name = "sosis";
            sosis.Size = new Size(62, 23);
            sosis.TabIndex = 7;
            sosis.Text = "sosis";
            sosis.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(663, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(223, 239);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(sec);
            groupBox1.Controls.Add(large);
            groupBox1.Controls.Add(medium);
            groupBox1.Controls.Add(small);
            groupBox1.Location = new Point(361, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 239);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boyut";
            // 
            // sec
            // 
            sec.Location = new Point(15, 151);
            sec.Name = "sec";
            sec.Size = new Size(130, 35);
            sec.TabIndex = 12;
            sec.Text = "Seç";
            sec.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(ekle);
            groupBox2.Controls.Add(mısır);
            groupBox2.Controls.Add(zeytin);
            groupBox2.Controls.Add(sosis);
            groupBox2.Controls.Add(mantar);
            groupBox2.Location = new Point(24, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 217);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Malzemeler";
            // 
            // ekle
            // 
            ekle.Location = new Point(7, 151);
            ekle.Name = "ekle";
            ekle.Size = new Size(130, 35);
            ekle.TabIndex = 11;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox mısır;
        private CheckBox zeytin;
        private CheckBox mantar;
        private RadioButton small;
        private RadioButton medium;
        private RadioButton large;
        private CheckBox sosis;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button sec;
        private Button ekle;
    }
}