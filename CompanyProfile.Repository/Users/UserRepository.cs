using CompanyProfile.Domain.Users;
using CompanyProfile.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProfile.Repository.Users
{
    public class UserRepository:GenericRepository<User>
    {
        public UserRepository()
        {

        }

        public UserRepository(CompanyDbContext entities):base(entities)
        {

        }
    }
}
