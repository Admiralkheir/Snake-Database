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
    public class YilanRenkService
    {
        YilanRenkRepository _yilanRenkRepository;
        public YilanRenkService()
        {
            _yilanRenkRepository = new YilanRenkRepository();
        }
        public int AddYilanRenkService(yilanRenk yilanRenk)
        {
            try
            {
                return _yilanRenkRepository.AddItem(yilanRenk);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:{0}", e.Message);
                return 0;
            }
        }
        public int DeleteYilanRenkService(yilanRenk yilanRenk)
        {
            try
            {
                return _yilanRenkRepository.DeleteItem(yilanRenk);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<yilanRenk> GetAllYilanRenkService()
        {

            return _yilanRenkRepository.GetAll();

        }

        public int YilanRenkUpdateService(yilanRenk yilanRenk)
        {
            return _yilanRenkRepository.UpdateItem(yilanRenk);
        }

        public yilanRenk GetByIDYilanRenkService(int id)
        {
            return _yilanRenkRepository.GetByID(id);
        }



    }
}
