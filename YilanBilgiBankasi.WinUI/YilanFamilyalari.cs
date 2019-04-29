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
using YilanBilgiBankasi.Entities.DTO;

namespace YilanBilgiBankasi.WinUI
{
    public partial class YilanFamilyalari : Form
    {
        YilanlarService _yilanService;
        public YilanFamilyalari()
        {
            InitializeComponent();
            _yilanService = new YilanlarService();
        }

        private void YilanFamilyalari_Load(object sender, EventArgs e)
        {
            dgvYilanFamilyalar.DataSource = null;
            List<YilanFamilyaDTO> yilanFamilyalari = _yilanService.YilanFamilyaService();
            dgvYilanFamilyalar.DataSource = yilanFamilyalari;
        }
    }
}
