using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilanBilgiBankasi.WinUI
{
    public partial class YilanAnaForm : Form
    {
        public YilanAnaForm()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YilanEkleme yilanEklemeForm = new YilanEkleme();
            yilanEklemeForm.MdiParent = this;
            yilanEklemeForm.Show();
        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YilanRapor yilanRaporForm = new YilanRapor();
            yilanRaporForm.MdiParent = this;
            yilanRaporForm.Show();
        }

        private void yilanlarıBağlıOlduğuFamilyalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YilanFamilyalari yilanFamilyaRaporForm = new YilanFamilyalari();
            yilanFamilyaRaporForm.MdiParent = this;
            yilanFamilyaRaporForm.Show();
        }

        private void cinslereGöreYılanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YilanCinsleriRapor yilanCinsForm = new YilanCinsleriRapor();
            yilanCinsForm.MdiParent = this;
            yilanCinsForm.Show();
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BesinEkleme besinEklemeForm = new BesinEkleme();
            besinEklemeForm.MdiParent = this;
            besinEklemeForm.Show();
        }

        private void güncelleVeSilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BesinDuzenleForm besinDuzenleForm = new BesinDuzenleForm();
            besinDuzenleForm.MdiParent = this;
            besinDuzenleForm.Show();
        }
    }
}
