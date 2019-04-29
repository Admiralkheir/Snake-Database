using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.DAL.RepositoryAbstract;
using YilanBilgiBankasi.Entities;

namespace YilanBilgiBankasi.DAL.RepositoryConcrete
{
    public class YilanRenkRepository : IYilanRenk
    {
        YilanDBContext _db;
        int _etkilenenSatir;
        public YilanRenkRepository()
        {
            _db = new YilanDBContext();
        }

        public int AddItem(yilanRenk item)
        {
            _db.yilanRenks.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(yilanRenk item)
        {
            _db.yilanRenks.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public List<yilanRenk> GetAll()
        {
            return _db.yilanRenks.ToList();
        }

        public yilanRenk GetByID(int id)
        {
            return _db.yilanRenks.Where(x => x.yilanRenkID == id).FirstOrDefault();
        }

        public int UpdateItem(yilanRenk item)
        {
            yilanRenk eskiYilanRenk = _db.yilanRenks.Where(x => x.yilanRenkID == item.yilanRenkID).FirstOrDefault();
            eskiYilanRenk.yilanRenk1 = item.yilanRenk1;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
    }
}
