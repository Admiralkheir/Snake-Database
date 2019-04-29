using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YilanBilgiBankasi.Entities.DTO;
using YilanBilgiBankasi.BLL.YilanBilgiBankasiService;

namespace YilanBilgiBankasi.WinUI
{
    public partial class YilanRapor : Form
    {
        YilanlarService _yilanService;
        public YilanRapor()
        {
            InitializeComponent();
            _yilanService = new YilanlarService();
        }

        private void YilanRapor_Load(object sender, EventArgs e)
        {
            dgvYilanRapor.DataSource = null;
            List<YilanCinsEpidetDTO> yilanCinsEpidets = _yilanService.YilanCinsEpidetService();
            dgvYilanRapor.DataSource = yilanCinsEpidets;
        }
    }
}
