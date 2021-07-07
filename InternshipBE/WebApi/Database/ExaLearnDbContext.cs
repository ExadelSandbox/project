using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<FileDetail> FileDetails { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
        {
            //Database.EnsureCreated(); // we will need to create a database when the site is deployed
        }
    }
}
