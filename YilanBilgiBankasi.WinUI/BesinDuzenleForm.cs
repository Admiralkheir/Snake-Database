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
    public partial class BesinDuzenleForm : Form
    {
        int _id;
        BesinlerService _besinService;
        public BesinDuzenleForm()
        {
            InitializeComponent();
            _besinService = new BesinlerService();
        }
        public void BesinListele()
        {
            dgvBesinlerListesi.DataSource = null;
            dgvBesinlerListesi.DataSource = _besinService.GetAllBesinlerService();
        }
        private void BesinDuzenleForm_Load(object sender, EventArgs e)
        {
            BesinListele();
        }

        private void dgvBesinlerListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(dgvBesinlerListesi.SelectedRows[0].Cells["besinID"].Value);
            txtBesinAd.Text = (_besinService.GetByIDBesinlerService(_id)).besinAd;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _besinService.DeleteBesinlerService(_besinService.GetByIDBesinlerService(_id));
            BesinListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            besinler besin = (_besinService.GetByIDBesinlerService(_id));
            besin.besinAd = txtBesinAd.Text;
            _besinService.BesinUpdateService(besin);
            BesinListele();
        }
    }
}
