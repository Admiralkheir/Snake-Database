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
    public partial class YilanEkleme : Form
    {
        public YilanlarService _yilanService;
        public YilanEpidetService _yilanEpidetService;
        public YilanCinService _yilanCinService;
        public BesinlerService _besinlerService;
        public IlService _ilService;
        public BiyotopService _biyotopService;
        public YilanRenkService _yilanRenkService;
        public YilanEkleme()
        {
            InitializeComponent();
            _yilanService = new YilanlarService();
            _yilanEpidetService = new YilanEpidetService();
            _yilanCinService = new YilanCinService();
            _besinlerService = new BesinlerService();
            _ilService = new IlService();
            _biyotopService = new BiyotopService();
            _yilanRenkService = new YilanRenkService();
        }

        private void YilanEkleme_Load(object sender, EventArgs e)
        {
            cbxEpidet.DataSource = null;
            cbxEpidet.DisplayMember = "epidetAd";
            cbxEpidet.ValueMember = "yilanEpidetID";
            cbxEpidet.DataSource = _yilanEpidetService.GetAllYilanEpidetService();

            cbxCins.DataSource = null;
            cbxCins.DisplayMember = "yilanCinsi";
            cbxCins.ValueMember = "yilanCinsID";
            cbxCins.DataSource = _yilanCinService.GetAllYilanCinService();

            cbxBesinler.DataSource = null;
            cbxBesinler.DisplayMember = "besinAd";
            cbxBesinler.ValueMember = "besinID";
            cbxBesinler.DataSource = _besinlerService.GetAllBesinlerService();

            cbxİller.DataSource = null;
            cbxİller.DisplayMember = "ilAd";
            cbxİller.ValueMember = "ilID";
            cbxİller.DataSource = _ilService.GetAllIlService();

            cbxRenkler.DataSource = null;
            cbxRenkler.DisplayMember = "yilanRenk1";
            cbxRenkler.ValueMember = "yilanRenkID";
            cbxRenkler.DataSource = _yilanRenkService.GetAllYilanRenkService();

            cbxBiyotop.DataSource = null;
            cbxBiyotop.DisplayMember = "biyotopAd";
            cbxBiyotop.ValueMember = "biyotopID";
            cbxBiyotop.DataSource = _biyotopService.GetAllBiyotopService();
        }

        private void btnYilaKaydet_Click(object sender, EventArgs e)
        {
            yilanlar yeniYilan = new yilanlar();
            yeniYilan.bilinenAd = txtBilinenAd.Text;
            yeniYilan.besinlers.Add(_besinlerService.GetByIDBesinlerService(Convert.ToInt16(cbxBesinler.SelectedValue)));

            yeniYilan.biyotops.Add(_biyotopService.GetByIDBiyotopService(Convert.ToInt16(cbxBiyotop.SelectedValue)));

            yeniYilan.ils.Add(_ilService.GetByIDIlService(Convert.ToInt16(cbxİller.SelectedValue)));
            yeniYilan.ortalamaUzunluk = Convert.ToInt16(txtOrtalamaUzunluk.Text);

            yeniYilan.yilanCinsID = Convert.ToInt16(cbxCins.SelectedValue);
            yeniYilan.yilanEpidetID = Convert.ToInt16(cbxEpidet.SelectedValue);
            yeniYilan.yilanRenks.Add(_yilanRenkService.GetByIDYilanRenkService(Convert.ToInt16(cbxRenkler.SelectedValue)));


            if (ckbZehirlilik.Checked == true)
            {
                yeniYilan.zehirlilik = true;
            }
            else if(ckbZehirlilik.Checked == false)
            {
                yeniYilan.zehirlilik = false;
            }
            _yilanService.AddYilanService(yeniYilan);

        }
    }
}
