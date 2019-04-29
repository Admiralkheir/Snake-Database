using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YilanBilgiBankasi.DAL.RepositoryConcrete;
using YilanBilgiBankasi.Entities;

namespace YilanBilgiBankasi.BLL.YilanBilgiBankasiService
{
    public class YilanCinService
    {
        YilanCinRepository _yilanCinRepository;

        public YilanCinService()
        {
            _yilanCinRepository = new YilanCinRepository();
        }

        public int AddYilanCinService(yilanCin yilanCins)
        {
            try
            {
                return _yilanCinRepository.AddItem(yilanCins);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:{0}", e.Message);
                return 0;
            }
        }
        public int DeleteYilanCinService(yilanCin yilanCins)
        {
            try
            {
                return _yilanCinRepository.DeleteItem(yilanCins);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<yilanCin> GetAllYilanCinService()
        {

            return _yilanCinRepository.GetAll();

        }

        public int YilanCinUpdateService(yilanCin yilanCins)
        {
            return _yilanCinRepository.UpdateItem(yilanCins);
        }

        public yilanCin GetByIDYilanCinService(int id)
        {
            return _yilanCinRepository.GetByID(id);
        }
    }
}
