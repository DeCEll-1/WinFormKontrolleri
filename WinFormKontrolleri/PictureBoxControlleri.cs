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
    public partial class PictureBoxControlleri : Form
    {
        public PictureBoxControlleri()
        {
            InitializeComponent();
        }

        private void PictureBoxControlleri_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = "../../Resimler/dog-ga2f8955e0_1920.jpg";
            comboBox1.SelectedIndex = 4;
            ResimleriGetir();
        }

        private void ResimleriGetir()
        {
            DirectoryInfo di = new DirectoryInfo("../../Resimler/");
            FileInfo[] resimler = di.GetFiles();
            foreach (FileInfo file in resimler)
            {
                listBox1.Items.Add(file.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();
            switch (secilen)
            {
                case "Normal":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Stretch Image":
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Auto Size":
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case "Center Image":
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "Zoom":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string resim = listBox1.SelectedItem.ToString();
                pictureBox1.ImageLocation = "../../Resimler/" + resim;
            }

        }
    }
}
