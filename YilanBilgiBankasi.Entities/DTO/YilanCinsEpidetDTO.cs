using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilanBilgiBankasi.Entities.DTO
{
    public class YilanCinsEpidetDTO
    {
        public string yilanAd { get; set; }
        public string yilanCinsAdi { get; set; }
        public string yilanEpidetAdi { get; set; }
        public bool? zehirlilik { get; set; }
        public short? OrtalamaUzunluk { get; set; }
    }
}
