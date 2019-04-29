using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.DAL.RepositoryAbstract;
using YilanBilgiBankasi.Entities;
using YilanBilgiBankasi.Entities.DTO;

namespace YilanBilgiBankasi.DAL.RepositoryConcrete
{
    public class YilanlarRepository : IYilanlarRepository
    {
        YilanDBContext _db;
        int _etkilenenSatir;
        public YilanlarRepository()
        {
            _db = new YilanDBContext();
        }
        public int AddItem(yilanlar item)
        {
            _db.yilanlars.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(yilanlar item)
        {
            _db.yilanlars.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public List<yilanlar> GetAll()
        {
            return _db.yilanlars.ToList();
        }

        public yilanlar GetByID(int id)
        {
            return _db.yilanlars.Where(x => x.yilanID == id).FirstOrDefault();
        }

        public int UpdateItem(yilanlar item)
        {
            yilanlar eskiYilan = _db.yilanlars.Where(x => x.yilanID == item.yilanID).FirstOrDefault();
            eskiYilan.bilinenAd = item.bilinenAd;
            eskiYilan.besinlers = item.besinlers;
            eskiYilan.biyotops = item.biyotops;
            eskiYilan.ils = item.ils;
            eskiYilan.ortalamaUzunluk = item.ortalamaUzunluk;
            eskiYilan.yilanCin = item.yilanCin;
            eskiYilan.yilanEpidet = item.yilanEpidet;
            eskiYilan.yilanRenks = item.yilanRenks;
            eskiYilan.zehirlilik = item.zehirlilik;
            eskiYilan.ortalamaUzunluk = item.ortalamaUzunluk;

            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public ICollection<YilanCinsDTO> YilanCins()
        {
            return (from yilan in _db.yilanlars
                    join yilanCins in _db.yilanCins on yilan.yilanCinsID equals yilanCins.yilanCinsID
                    select new YilanCinsDTO
                    {
                        YilanAd = yilan.bilinenAd,
                        YilanCinsi = yilanCins.yilanCinsi,
                        Zehirlilik = yilan.zehirlilik


                    }).ToList();
        }

        public ICollection<YilanCinsEpidetDTO> YilanCinsEpidet()
        {
            return (from yilan in _db.yilanlars
                    join yilanCins in _db.yilanCins on yilan.yilanCinsID equals yilanCins.yilanCinsID
                    join yilanEpidetler in _db.yilanEpidets on yilan.yilanEpidetID equals yilanEpidetler.yilanEpidetID
                    select new YilanCinsEpidetDTO
                    {
                        yilanAd = yilan.bilinenAd,
                        yilanCinsAdi = yilanCins.yilanCinsi,
                        OrtalamaUzunluk = yilan.ortalamaUzunluk,
                        zehirlilik = yilan.zehirlilik,
                        yilanEpidetAdi=yilanEpidetler.epidetAd

                    }).ToList();
                    
        }

        public ICollection<YilanFamilyaDTO> YilanFamilya()
        {
            return (from yilan in _db.yilanlars
                    join yilanCins in _db.yilanCins on yilan.yilanCinsID equals yilanCins.yilanCinsID
                    join yilanFamilya in _db.yilanAiles on yilanCins.yilanAileID equals yilanFamilya.yilanAileID
                    select new YilanFamilyaDTO
                    {
                        YilanAd = yilan.bilinenAd,
                        YilanFamilya = yilanFamilya.yilanAileAd,
                        Zehirlilik = yilan.zehirlilik
                    }).ToList();
        }

        //public ICollection<YilanIlDTO> YilanIl()
        //{
        //    return (_db.ils.Select(x=> new YilanIlDTO {})) çoka çoktaki 3.tablo burada oluşmuyor veritabanında var joinlerken ona ulaşmam gerekiyor ne yapmak gerek.
        //}
    }
}
