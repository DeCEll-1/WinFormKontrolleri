namespace WinFormKontrolleri
{
    partial class TextBoxKontrolleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Standart1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Enabled = new System.Windows.Forms.TextBox();
            this.lbl_Enabled = new System.Windows.Forms.Label();
            this.tb_maxlenght = new System.Windows.Forms.TextBox();
            this.lbl_Maxlenght = new System.Windows.Forms.Label();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.tb_ReadOnly = new System.Windows.Forms.TextBox();
            this.lbl_ReadOnly = new System.Windows.Forms.Label();
            this.tb_BuyukKarakter = new System.Windows.Forms.TextBox();
            this.lbl_BuyukKarakter = new System.Windows.Forms.Label();
            this.tb_RightToLeft = new System.Windows.Forms.TextBox();
            this.lbl_RıghtToLeft = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_Maskedtb = new System.Windows.Forms.Label();
            this.lbl_Numbertb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Standart1
            // 
            this.TB_Standart1.Location = new System.Drawing.Point(213, 29);
            this.TB_Standart1.Name = "TB_Standart1";
            this.TB_Standart1.Size = new System.Drawing.Size(100, 20);
            this.TB_Standart1.TabIndex = 0;
            this.TB_Standart1.TextChanged += new System.EventHandler(this.TB_Standart1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Standart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(12, 58);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_Mail.TabIndex = 1;
            this.lbl_Mail.Text = "Mail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = 'O';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(12, 84);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(28, 13);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = 'O';
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // tb_Enabled
            // 
            this.tb_Enabled.Enabled = false;
            this.tb_Enabled.Location = new System.Drawing.Point(213, 107);
            this.tb_Enabled.Name = "tb_Enabled";
            this.tb_Enabled.Size = new System.Drawing.Size(100, 20);
            this.tb_Enabled.TabIndex = 3;
            this.tb_Enabled.Text = "texttexttext";
            // 
            // lbl_Enabled
            // 
            this.lbl_Enabled.AutoSize = true;
            this.lbl_Enabled.Location = new System.Drawing.Point(12, 110);
            this.lbl_Enabled.Name = "lbl_Enabled";
            this.lbl_Enabled.Size = new System.Drawing.Size(46, 13);
            this.lbl_Enabled.TabIndex = 1;
            this.lbl_Enabled.Text = "Enabled";
            // 
            // tb_maxlenght
            // 
            this.tb_maxlenght.Location = new System.Drawing.Point(213, 133);
            this.tb_maxlenght.MaxLength = 16;
            this.tb_maxlenght.Name = "tb_maxlenght";
            this.tb_maxlenght.Size = new System.Drawing.Size(100, 20);
            this.tb_maxlenght.TabIndex = 4;
            // 
            // lbl_Maxlenght
            // 
            this.lbl_Maxlenght.AutoSize = true;
            this.lbl_Maxlenght.Location = new System.Drawing.Point(12, 136);
            this.lbl_Maxlenght.Name = "lbl_Maxlenght";
            this.lbl_Maxlenght.Size = new System.Drawing.Size(56, 13);
            this.lbl_Maxlenght.TabIndex = 1;
            this.lbl_Maxlenght.Text = "Maxlenght";
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(213, 159);
            this.tb_Adres.Multiline = true;
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Adres.Size = new System.Drawing.Size(183, 115);
            this.tb_Adres.TabIndex = 5;
            this.tb_Adres.WordWrap = false;
            this.tb_Adres.TextChanged += new System.EventHandler(this.TB_Standart1_TextChanged);
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Location = new System.Drawing.Point(12, 162);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(34, 13);
            this.lbl_Adres.TabIndex = 1;
            this.lbl_Adres.Text = "Adres";
            this.lbl_Adres.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_ReadOnly
            // 
            this.tb_ReadOnly.Location = new System.Drawing.Point(213, 280);
            this.tb_ReadOnly.Name = "tb_ReadOnly";
            this.tb_ReadOnly.ReadOnly = true;
            this.tb_ReadOnly.Size = new System.Drawing.Size(100, 20);
            this.tb_ReadOnly.TabIndex = 6;
            this.tb_ReadOnly.Text = "asdf";
            this.tb_ReadOnly.TextChanged += new System.EventHandler(this.TB_Standart1_TextChanged);
            // 
            // lbl_ReadOnly
            // 
            this.lbl_ReadOnly.AutoSize = true;
            this.lbl_ReadOnly.Location = new System.Drawing.Point(12, 283);
            this.lbl_ReadOnly.Name = "lbl_ReadOnly";
            this.lbl_ReadOnly.Size = new System.Drawing.Size(54, 13);
            this.lbl_ReadOnly.TabIndex = 1;
            this.lbl_ReadOnly.Text = "ReadOnly";
            this.lbl_ReadOnly.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_BuyukKarakter
            // 
            this.tb_BuyukKarakter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_BuyukKarakter.Location = new System.Drawing.Point(213, 306);
            this.tb_BuyukKarakter.Name = "tb_BuyukKarakter";
            this.tb_BuyukKarakter.Size = new System.Drawing.Size(100, 20);
            this.tb_BuyukKarakter.TabIndex = 7;
            this.tb_BuyukKarakter.TextChanged += new System.EventHandler(this.TB_Standart1_TextChanged);
            // 
            // lbl_BuyukKarakter
            // 
            this.lbl_BuyukKarakter.AutoSize = true;
            this.lbl_BuyukKarakter.Location = new System.Drawing.Point(12, 309);
            this.lbl_BuyukKarakter.Name = "lbl_BuyukKarakter";
            this.lbl_BuyukKarakter.Size = new System.Drawing.Size(80, 13);
            this.lbl_BuyukKarakter.TabIndex = 1;
            this.lbl_BuyukKarakter.Text = "Büyük Karakter";
            this.lbl_BuyukKarakter.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_RightToLeft
            // 
            this.tb_RightToLeft.Location = new System.Drawing.Point(213, 332);
            this.tb_RightToLeft.Name = "tb_RightToLeft";
            this.tb_RightToLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_RightToLeft.Size = new System.Drawing.Size(100, 20);
            this.tb_RightToLeft.TabIndex = 8;
            this.tb_RightToLeft.TextChanged += new System.EventHandler(this.TB_Standart1_TextChanged);
            // 
            // lbl_RıghtToLeft
            // 
            this.lbl_RıghtToLeft.AutoSize = true;
            this.lbl_RıghtToLeft.Location = new System.Drawing.Point(12, 335);
            this.lbl_RıghtToLeft.Name = "lbl_RıghtToLeft";
            this.lbl_RıghtToLeft.Size = new System.Drawing.Size(69, 13);
            this.lbl_RıghtToLeft.TabIndex = 1;
            this.lbl_RıghtToLeft.Text = "Right To Left";
            this.lbl_RıghtToLeft.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(213, 358);
            this.maskedTextBox1.Mask = "99999999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(99, 20);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(213, 384);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_Maskedtb
            // 
            this.lbl_Maskedtb.AutoSize = true;
            this.lbl_Maskedtb.Location = new System.Drawing.Point(12, 358);
            this.lbl_Maskedtb.Name = "lbl_Maskedtb";
            this.lbl_Maskedtb.Size = new System.Drawing.Size(54, 13);
            this.lbl_Maskedtb.TabIndex = 1;
            this.lbl_Maskedtb.Text = "Maskedtb";
            this.lbl_Maskedtb.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Numbertb
            // 
            this.lbl_Numbertb.AutoSize = true;
            this.lbl_Numbertb.Location = new System.Drawing.Point(12, 384);
            this.lbl_Numbertb.Name = "lbl_Numbertb";
            this.lbl_Numbertb.Size = new System.Drawing.Size(53, 13);
            this.lbl_Numbertb.TabIndex = 1;
            this.lbl_Numbertb.Text = "Numbertb";
            this.lbl_Numbertb.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.lbl_Enabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Maxlenght);
            this.Controls.Add(this.lbl_Adres);
            this.Controls.Add(this.lbl_ReadOnly);
            this.Controls.Add(this.lbl_Numbertb);
            this.Controls.Add(this.lbl_Maskedtb);
            this.Controls.Add(this.lbl_RıghtToLeft);
            this.Controls.Add(this.lbl_BuyukKarakter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_Enabled);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_maxlenght);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.tb_ReadOnly);
            this.Controls.Add(this.tb_RightToLeft);
            this.Controls.Add(this.tb_BuyukKarakter);
            this.Controls.Add(this.TB_Standart1);
            this.Name = "TextBoxKontrolleri";
            this.Text = "TextBoxKontrolleri";
            this.Load += new System.EventHandler(this.TextBoxKontrolleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Standart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Enabled;
        private System.Windows.Forms.Label lbl_Enabled;
        private System.Windows.Forms.TextBox tb_maxlenght;
        private System.Windows.Forms.Label lbl_Maxlenght;
        private System.Windows.Forms.TextBox tb_Adres;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.TextBox tb_ReadOnly;
        private System.Windows.Forms.Label lbl_ReadOnly;
        private System.Windows.Forms.TextBox tb_BuyukKarakter;
        private System.Windows.Forms.Label lbl_BuyukKarakter;
        private System.Windows.Forms.TextBox tb_RightToLeft;
        private System.Windows.Forms.Label lbl_RıghtToLeft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_Maskedtb;
        private System.Windows.Forms.Label lbl_Numbertb;
    }
}