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
    public class YilanEpidetService
    {
        YilanEpidetRepository _yilanEpidetRepository;

        public YilanEpidetService()
        {
            _yilanEpidetRepository = new YilanEpidetRepository();
        }

        public int AddYilanEpidetService(yilanEpidet epidet)
        {
            try
            {
                return _yilanEpidetRepository.AddItem(epidet);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:{0}", e.Message);
                return 0;
            }
        }
        public int DeleteYilanEpidetService(yilanEpidet epidet)
        {
            try
            {
                return _yilanEpidetRepository.DeleteItem(epidet);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<yilanEpidet> GetAllYilanEpidetService()
        {

            return _yilanEpidetRepository.GetAll();

        }

        public int YilanEpidetUpdateService(yilanEpidet epidet)
        {
            return _yilanEpidetRepository.UpdateItem(epidet);
        }

        public yilanEpidet GetByIDYilanEpidetService(int id)
        {
            return _yilanEpidetRepository.GetByID(id);
        }


    }
}
