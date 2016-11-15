using CompanyProfile.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProfile.EntityFramework
{
    public class CompanyDbContext:DbContext
    {
        public CompanyDbContext() : base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
    }
}
