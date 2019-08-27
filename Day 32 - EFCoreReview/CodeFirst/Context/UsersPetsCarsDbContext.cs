using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Context
{
    public class UsersPetsCarsDbContext : DbContext
    {
        public UsersPetsCarsDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Pets> Pets { get; set; }
        public DbSet<Cars> Cars { get; set; }
    }
}
