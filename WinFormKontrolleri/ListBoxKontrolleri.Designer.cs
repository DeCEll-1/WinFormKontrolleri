namespace WinFormKontrolleri
{
    partial class ListBoxKontrolleri
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
            this.lb_Text = new System.Windows.Forms.ListBox();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.tb_Text = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Goster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Text
            // 
            this.lb_Text.FormattingEnabled = true;
            this.lb_Text.Location = new System.Drawing.Point(12, 12);
            this.lb_Text.Name = "lb_Text";
            this.lb_Text.Size = new System.Drawing.Size(150, 316);
            this.lb_Text.TabIndex = 0;
            this.lb_Text.DoubleClick += new System.EventHandler(this.lb_Text_DoubleClick);
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Location = new System.Drawing.Point(168, 24);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(28, 13);
            this.lbl_Text.TabIndex = 1;
            this.lbl_Text.Text = "Text";
            // 
            // tb_Text
            // 
            this.tb_Text.Location = new System.Drawing.Point(168, 40);
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.Size = new System.Drawing.Size(123, 20);
            this.tb_Text.TabIndex = 2;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(168, 66);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(121, 20);
            this.btn_Ekle.TabIndex = 3;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Goster
            // 
            this.btn_Goster.Location = new System.Drawing.Point(168, 92);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(121, 20);
            this.btn_Goster.TabIndex = 3;
            this.btn_Goster.Text = "Göster";
            this.btn_Goster.UseVisualStyleBackColor = true;
            this.btn_Goster.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // ListBoxKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 341);
            this.Controls.Add(this.btn_Goster);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tb_Text);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.lb_Text);
            this.Name = "ListBoxKontrolleri";
            this.Text = "ListBoxKontrolleri";
            this.Load += new System.EventHandler(this.ListBoxKontrolleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Text;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.TextBox tb_Text;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Goster;
    }
}