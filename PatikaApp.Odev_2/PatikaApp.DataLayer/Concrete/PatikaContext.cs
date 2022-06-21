using Microsoft.EntityFrameworkCore;
using PatikaApp.DataLayer.Config;
using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.DataLayer.Concrete
{
    class PatikaContext : DbContext
    {
        public DbSet<AdminInfo> AdminInfos { get; set; }
        public DbSet<BootcampInfo> BootcampInfos { get; set; }
        public DbSet<EducatorInfo> EducatorInfos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = PatikaAppDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdminInfoConfig).Assembly);

        }

    }
}
