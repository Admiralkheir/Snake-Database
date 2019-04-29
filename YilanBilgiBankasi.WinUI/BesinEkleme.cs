using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YilanBilgiBankasi.BLL.YilanBilgiBankasiService;
using YilanBilgiBankasi.Entities;
namespace YilanBilgiBankasi.WinUI
{
    public partial class BesinEkleme : Form
    {
        BesinlerService _besinService;
        public BesinEkleme()
        {
            InitializeComponent();
            _besinService = new BesinlerService();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            besinler besin = new besinler();
            besin.besinAd = txtBesinAd.Text;
            _besinService.AddBesinlerService(besin);
        }
    }
}
