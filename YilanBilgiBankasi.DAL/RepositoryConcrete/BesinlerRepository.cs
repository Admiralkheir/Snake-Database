using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.DAL.RepositoryAbstract;
using YilanBilgiBankasi.Entities;

namespace YilanBilgiBankasi.DAL.RepositoryConcrete
{
    public class BesinlerRepository : IBesinlerRepository
    {
        YilanDBContext _db;
        int _etkilenenSatir;
        public BesinlerRepository()
        {
            _db = new YilanDBContext();
        }
        public int AddItem(besinler item)
        {
            _db.besinlers.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(besinler item)
        {
            _db.besinlers.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public List<besinler> GetAll()
        {
            return _db.besinlers.ToList();
        }

        public besinler GetByID(int id)
        {
            return _db.besinlers.Where(x => x.besinID == id).FirstOrDefault();
        }

        public int UpdateItem(besinler item)
        {
            besinler eskiBesin = _db.besinlers.Where(x => x.besinID == item.besinID).FirstOrDefault();
            eskiBesin.besinAd = item.besinAd;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;

        }
    }
}
