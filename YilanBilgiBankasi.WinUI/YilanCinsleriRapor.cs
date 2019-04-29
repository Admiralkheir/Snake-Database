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

namespace YilanBilgiBankasi.WinUI
{
    public partial class YilanCinsleriRapor : Form
    {
        YilanlarService _yilanlarService;
        public YilanCinsleriRapor()
        {
            InitializeComponent();
            _yilanlarService = new YilanlarService();
        }

        private void YilanCinsleriRapor_Load(object sender, EventArgs e)
        {
            dgvCinsler.DataSource = null;
            dgvCinsler.DataSource = _yilanlarService.YilanCinsleri();
        }
    }
}
