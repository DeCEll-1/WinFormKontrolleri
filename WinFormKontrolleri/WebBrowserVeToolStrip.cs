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
    public partial class WebBrowserVeToolStrip : Form
    {
        public WebBrowserVeToolStrip()
        {
            InitializeComponent();
        }

        private void WebBrowserVeToolStrip_Load(object sender, EventArgs e)
        {
            WB_MainBrowser.Url = new Uri("http://www.google.com");
        }

        private void TSTB_AramaMotoru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TSTB_AramaMotoru.Text.Length !=0)
                {
                    WB_MainBrowser.Url = new Uri(TSTB_AramaMotoru.Text);
                }
            }
        }
    }
}
