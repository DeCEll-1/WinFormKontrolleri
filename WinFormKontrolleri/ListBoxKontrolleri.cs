using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormKontrolleri
{
    public partial class ListBoxKontrolleri : Form
    {
        public ListBoxKontrolleri()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            lb_Text.Items.Add(tb_Text.Text);
        }
        private void btn_Goster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lb_Text.SelectedItem.ToString());
        }

        private void lb_Text_DoubleClick(object sender, EventArgs e)
        {
            if (lb_Text.SelectedItem!= null)
            {
                MessageBox.Show(lb_Text.SelectedItem.ToString());
            }
        }

        private void ListBoxKontrolleri_Load(object sender, EventArgs e)
        {
            lb_Text.Items.Add("Ahmet");
            lb_Text.Items.Add("Mehmet");
            lb_Text.Items.Add("Mazuran");
        }
    }
}
