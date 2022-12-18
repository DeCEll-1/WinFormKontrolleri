namespace WinFormKontrolleri
{
    partial class WebBrowserVeToolStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSTB_AramaMotoru = new System.Windows.Forms.ToolStripTextBox();
            this.TSB_Left = new System.Windows.Forms.ToolStripButton();
            this.TSB_Right = new System.Windows.Forms.ToolStripButton();
            this.TSB_Reflesh = new System.Windows.Forms.ToolStripButton();
            this.TSB_Home = new System.Windows.Forms.ToolStripButton();
            this.TSB_Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.WB_MainBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Left,
            this.TSB_Right,
            this.TSB_Reflesh,
            this.TSB_Home,
            this.TSTB_AramaMotoru,
            this.TSB_Settings,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSTB_AramaMotoru
            // 
            this.TSTB_AramaMotoru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTB_AramaMotoru.Name = "TSTB_AramaMotoru";
            this.TSTB_AramaMotoru.Size = new System.Drawing.Size(300, 25);
            this.TSTB_AramaMotoru.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSTB_AramaMotoru_KeyDown);
            // 
            // TSB_Left
            // 
            this.TSB_Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Left.Image = global::WinFormKontrolleri.Properties.Resources.angle_left;
            this.TSB_Left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Left.Name = "TSB_Left";
            this.TSB_Left.Size = new System.Drawing.Size(23, 22);
            // 
            // TSB_Right
            // 
            this.TSB_Right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Right.Image = global::WinFormKontrolleri.Properties.Resources.angle_right;
            this.TSB_Right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Right.Name = "TSB_Right";
            this.TSB_Right.Size = new System.Drawing.Size(23, 22);
            // 
            // TSB_Reflesh
            // 
            this.TSB_Reflesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Reflesh.Image = global::WinFormKontrolleri.Properties.Resources.refresh;
            this.TSB_Reflesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Reflesh.Name = "TSB_Reflesh";
            this.TSB_Reflesh.Size = new System.Drawing.Size(23, 22);
            // 
            // TSB_Home
            // 
            this.TSB_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Home.Image = global::WinFormKontrolleri.Properties.Resources.home;
            this.TSB_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Home.Name = "TSB_Home";
            this.TSB_Home.Size = new System.Drawing.Size(23, 22);
            // 
            // TSB_Settings
            // 
            this.TSB_Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSB_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Settings.Image = global::WinFormKontrolleri.Properties.Resources.menu_burger;
            this.TSB_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Settings.Name = "TSB_Settings";
            this.TSB_Settings.Size = new System.Drawing.Size(23, 22);
            this.TSB_Settings.Text = "toolStripButton5";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WinFormKontrolleri.Properties.Resources.next;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            // 
            // WB_MainBrowser
            // 
            this.WB_MainBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WB_MainBrowser.Location = new System.Drawing.Point(0, 49);
            this.WB_MainBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB_MainBrowser.Name = "WB_MainBrowser";
            this.WB_MainBrowser.Size = new System.Drawing.Size(584, 412);
            this.WB_MainBrowser.TabIndex = 2;
            // 
            // WebBrowserVeToolStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.WB_MainBrowser);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebBrowserVeToolStrip";
            this.Text = "Mahmut browser";
            this.Load += new System.EventHandler(this.WebBrowserVeToolStrip_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Left;
        private System.Windows.Forms.ToolStripButton TSB_Right;
        private System.Windows.Forms.ToolStripButton TSB_Reflesh;
        private System.Windows.Forms.ToolStripButton TSB_Home;
        private System.Windows.Forms.ToolStripTextBox TSTB_AramaMotoru;
        private System.Windows.Forms.ToolStripButton TSB_Settings;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.WebBrowser WB_MainBrowser;
    }
}