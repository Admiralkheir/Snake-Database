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
    public class BesinlerService
    {
        BesinlerRepository _besinlerRepository;


        public BesinlerService()
        {
            _besinlerRepository = new BesinlerRepository();
        }
        public int AddBesinlerService(besinler besin)
        {
            try
            {
                return _besinlerRepository.AddItem(besin);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:{0}", e.Message);
                return 0;
            }
        }
        public int DeleteBesinlerService(besinler besin)
        {
            try
            {
                return _besinlerRepository.DeleteItem(besin);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<besinler> GetAllBesinlerService()
        {

            return _besinlerRepository.GetAll();

        }

        public int BesinUpdateService(besinler  besin)
        {
            return _besinlerRepository.UpdateItem(besin);
        }

        public besinler GetByIDBesinlerService(int id)
        {
            return _besinlerRepository.GetByID(id);
        }



    }
}
