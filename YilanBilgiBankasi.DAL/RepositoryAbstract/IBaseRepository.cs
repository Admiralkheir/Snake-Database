using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilanBilgiBankasi.DAL.RepositoryAbstract
{
    interface IBaseRepository<T> where T:class
    {
        int AddItem(T item);
        int UpdateItem(T item);
        int DeleteItem(T item);
        T GetByID(int id);
        List<T> GetAll();

    }
}
