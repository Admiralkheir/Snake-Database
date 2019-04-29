using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilanBilgiBankasi.Entities;
using YilanBilgiBankasi.Entities.DTO;
namespace YilanBilgiBankasi.DAL.RepositoryAbstract
{
    interface IYilanlarRepository:IBaseRepository<yilanlar>
    {
        ICollection<YilanCinsEpidetDTO> YilanCinsEpidet();
        ICollection<YilanFamilyaDTO> YilanFamilya();
        //ICollection<YilanIlDTO> YilanIl();
        ICollection<YilanCinsDTO> YilanCins();
    }
}
