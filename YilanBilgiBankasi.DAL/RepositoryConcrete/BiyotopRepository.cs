using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.DAL.RepositoryAbstract;
using YilanBilgiBankasi.Entities;

namespace YilanBilgiBankasi.DAL.RepositoryConcrete
{
    public class BiyotopRepository : IBiyotopRepository
    {
        YilanDBContext _db;
        int _etkilenenSatir;
        public BiyotopRepository()
        {
            _db = new YilanDBContext();
        }

        public int AddItem(biyotop item)
        {
            _db.biyotops.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(biyotop item)
        {
            _db.biyotops.Remove(item);
            _etkilenenSatir= _db.SaveChanges();
            return _etkilenenSatir;
        }

        public List<biyotop> GetAll()
        {
            return _db.biyotops.ToList();

        }

        public biyotop GetByID(int id)
        {
            return _db.biyotops.Where(x => x.biyotopID == id).FirstOrDefault();
        }

        public int UpdateItem(biyotop item)
        {
            biyotop eskiBiyotop= _db.biyotops.Where(x => x.biyotopID == item.biyotopID).FirstOrDefault();
            eskiBiyotop.biyotopAd = item.biyotopAd;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
    }
}
