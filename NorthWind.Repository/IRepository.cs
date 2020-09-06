using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> SelectAll();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
