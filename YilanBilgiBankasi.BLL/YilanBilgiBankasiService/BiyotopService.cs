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
    public class BiyotopService
    {
        BiyotopRepository _biyotopRepository;
        public BiyotopService()
        {
            _biyotopRepository = new BiyotopRepository();
        }
        public int AddBiyotopService(biyotop biyotop)
        {
            try
            {
                return _biyotopRepository.AddItem(biyotop);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:{0}", e.Message);
                return 0;
            }
        }
        public int DeleteBiyotopService(biyotop biyotop)
        {
            try
            {
                return _biyotopRepository.DeleteItem(biyotop);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<biyotop> GetAllBiyotopService()
        {

            return _biyotopRepository.GetAll();

        }

        public int BiyotopUpdateService(biyotop biyotop)
        {
            return _biyotopRepository.UpdateItem(biyotop);
        }

        public biyotop GetByIDBiyotopService(int id)
        {
            return _biyotopRepository.GetByID(id);
        }


    }
}
