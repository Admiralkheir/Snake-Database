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
    public class IlService
    {
        IlRepository _ilRepository;
        public IlService()
        {
            _ilRepository = new IlRepository();
        }

        public int AddIlService(il il)
        {
            try
            {
                return _ilRepository.AddItem(il);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:{0}", e.Message);
                return 0;
            }
        }
        public int DeleteIlService(il il)
        {
            try
            {
                return _ilRepository.DeleteItem(il);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<il> GetAllIlService()
        {

            return _ilRepository.GetAll();

        }

        public int IlUpdateService(il il)
        {
            return _ilRepository.UpdateItem(il);
        }

        public il GetByIDIlService(int id)
        {
            return _ilRepository.GetByID(id);
        }


    }
}
