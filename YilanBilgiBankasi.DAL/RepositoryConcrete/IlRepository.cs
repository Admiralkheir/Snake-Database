using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.DAL.RepositoryAbstract;
using YilanBilgiBankasi.Entities;

namespace YilanBilgiBankasi.DAL.RepositoryConcrete
{
    public class IlRepository : IIlRepository
    {
        YilanDBContext _db;
        int _etkilenenSatir;
        public IlRepository()
        {
            _db = new YilanDBContext();
        }
        public int AddItem(il item)
        {
            _db.ils.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;

        }

        public int DeleteItem(il item)
        {
            _db.ils.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public List<il> GetAll()
        {
            return _db.ils.ToList();
        }

        public il GetByID(int id)
        {
            return _db.ils.Where(x => x.ilID == id).FirstOrDefault();

        }

        public int UpdateItem(il item)
        {
            il eskiIl = _db.ils.Where(x => x.ilID == item.ilID).FirstOrDefault();
            eskiIl.bolge = item.bolge;
            eskiIl.ilAd = item.ilAd;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
    }
}
