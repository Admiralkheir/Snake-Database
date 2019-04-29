using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.DAL.RepositoryAbstract;
using YilanBilgiBankasi.Entities;

namespace YilanBilgiBankasi.DAL.RepositoryConcrete
{
    public class YilanCinRepository : IYilanCinRepository
    {
        YilanDBContext _db;
        int _etkilenenSatir;
        public YilanCinRepository()
        {
            _db = new YilanDBContext();
        }
        public int AddItem(yilanCin item)
        {
            _db.yilanCins.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(yilanCin item)
        {
            _db.yilanCins.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public List<yilanCin> GetAll()
        {
            return _db.yilanCins.ToList();
        }

        public yilanCin GetByID(int id)
        {
            return _db.yilanCins.Where(x => x.yilanCinsID == id).FirstOrDefault();
        }

        public int UpdateItem(yilanCin item)
        {
            yilanCin eskiCins = _db.yilanCins.Where(x => x.yilanCinsID == item.yilanCinsID).FirstOrDefault();
            eskiCins.yilanAile = item.yilanAile;
            eskiCins.yilanCinsi = item.yilanCinsi;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
    }
}
