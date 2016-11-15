using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProfile.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        IQueryable<T> GetAll();
        bool Create(T entity);
        bool Update(int id, T entity);
        bool Delete(int id);
        bool Save();
    }
}
