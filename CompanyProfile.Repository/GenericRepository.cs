using CompanyProfile.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProfile.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public CompanyDbContext _entities;
        public GenericRepository()
        {
            _entities = new CompanyDbContext();
        }
        public GenericRepository(CompanyDbContext entities)
        {
            _entities = entities;
        }
        public bool Create(T entity)
        {
            _entities.Set<T>().Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public bool Save()
        {
            _entities.SaveChanges();
            return true;
        }

        public bool Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
