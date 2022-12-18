using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormKontrolleri
{

    public partial class RichTextEditorZortu : Form
    {
        public string Yol { get; set; }

        public RichTextEditorZortu()
        {
            InitializeComponent();
            OFD_1.Filter = "Text File|*.txt|Rich Text File|*.rtf|No Limits|*.*";

            SFD_1.Filter = "Text File|*.txt|Rich Text File|*.rtf|No Limits|*.*";
            
            this.Text = "Better Word";

            TSCB_Size.Text = RTF_1.Font.Size.ToString();

            FontFamily[] fonts = FontFamily.Families;
            foreach (FontFamily item in fonts)
            {
                TSCB_FontFamily.Items.Add(item.Name);
            }
            TSCB_FontFamily.SelectedIndex = 0;
        }

        private void Kaydet(object sender, EventArgs e)
        {
            if (Yol == null)
            {
                FarkliKaydet(null,null);
            }
            else
            {
                RTF_1.SaveFile(Yol);
                MessageBox.Show("saved");
            }
            FileInfo fi = new FileInfo(Yol);
            this.Text += "-" + fi.Name;
        }

        private void Ac(object sender, EventArgs e)
        {
            if (OFD_1.ShowDialog() == DialogResult.OK)
            {
                if (OFD_1.FileName.EndsWith(".txt"))
                {
                    StreamReader sr = new StreamReader(OFD_1.FileName);
                    RTF_1.Text = sr.ReadToEnd();
                }
                else if (OFD_1.FileName.EndsWith(".rtf"))
                {
                    RTF_1.LoadFile(OFD_1.FileName);
                }
                Yol = OFD_1.FileName;
            }
            MessageBox.Show(Yol);
            FileInfo fi = new FileInfo(Yol);
            this.Text = "Better Word";
            this.Text += "-" + fi.Name;
        }
        private void FarkliKaydet(object sender, EventArgs e)
        {

            if (SFD_1.ShowDialog() == DialogResult.OK)
            {
                Yol = SFD_1.FileName;
                RTF_1.SaveFile(SFD_1.FileName);
            }
            FileInfo fi = new FileInfo(Yol);
            this.Text = "Better Word";
            this.Text += "-" + fi.Name;
        }

        private void Yeni(object sender, EventArgs e)
        {
            RTF_1.Text = "";
            Yol = "";
            this.Text = "Better Word";
        }

        private void TSCB_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float size = float.Parse(TSCB_Size.Text);
                Font fnt = new Font(RTF_1.Font.FontFamily, size);
                RTF_1.Font = fnt;
            }
        }

        private void TSCB_Size_SelectedIndexChanged(object sender, EventArgs e)
        {

            float size = float.Parse(TSCB_Size.Text);
            Font fnt = new Font(RTF_1.Font.FontFamily, size);
            RTF_1.Font = fnt;
        }
        private void TSMI_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
