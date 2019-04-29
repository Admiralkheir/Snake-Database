using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.Entities;
namespace YilanBilgiBankasi.DAL.RepositoryConcrete
{
    public class YilanEpidetRepository
    {
        YilanDBContext _db;
        int _etkilenenSatir;

        public YilanEpidetRepository()
        {
            _db = new YilanDBContext();
        }

        public int AddItem(yilanEpidet item)
        {
            _db.yilanEpidets.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(yilanEpidet item)
        {
            _db.yilanEpidets.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public List<yilanEpidet> GetAll()
        {
            return _db.yilanEpidets.ToList();
        }

        public yilanEpidet GetByID(int id)
        {
            return _db.yilanEpidets.Where(x => x.yilanEpidetID == id).FirstOrDefault();
        }

        public int UpdateItem(yilanEpidet item)
        {
            yilanEpidet eskiEpidet = _db.yilanEpidets.Where(x => x.yilanEpidetID == item.yilanEpidetID).FirstOrDefault();

            eskiEpidet.epidetAd = item.epidetAd;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
    }
}
