using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.DAL.RepositoryConcrete;
using YilanBilgiBankasi.Entities;
using System.Windows.Forms;
using YilanBilgiBankasi.Entities.DTO;

namespace YilanBilgiBankasi.BLL.YilanBilgiBankasiService
{
    public class YilanlarService
    {
        YilanlarRepository _yilanRepository;
        public YilanlarService()
        {
            _yilanRepository = new YilanlarRepository();
        }
        public int AddYilanService(yilanlar yilan)
        {
            try
            {
                return _yilanRepository.AddItem(yilan);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata"+e.Message);
                return 0;
            }
        }
        public int DeleteYilanService (yilanlar yilan)
        {
            try
            {
                return _yilanRepository.DeleteItem(yilan);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<yilanlar> GetAllYilanService()
        {

            return _yilanRepository.GetAll();
            
        }

        public int YilanUpdateService(yilanlar yilan)
        {
            return _yilanRepository.UpdateItem(yilan);
        }

        public yilanlar GetByIDYilanService (int id)
        {
            return _yilanRepository.GetByID(id);
        }

        public List<YilanCinsEpidetDTO> YilanCinsEpidetService()
        {
            return _yilanRepository.YilanCinsEpidet().ToList();
        }

        public List<YilanFamilyaDTO> YilanFamilyaService()
        {
            return _yilanRepository.YilanFamilya().ToList();
        }
        public List<YilanCinsDTO> YilanCinsleri()
        {
            return _yilanRepository.YilanCins().ToList();
        }
    }
}
