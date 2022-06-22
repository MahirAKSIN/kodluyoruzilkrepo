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
    public class PatikaContext : DbContext
    {
        public DbSet<AdminInfo> AdminInfos { get; set; }
        public DbSet<BootcampInfo> BootcampInfos { get; set; }
        public DbSet<EducatorInfo> EducatorInfos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8M7D7GE\\SQLEXPRESS;database=PatikaAppDB;integrated security=true;");
            //optionsBuilder.UseSqlite("Data Source = PatikaAppDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdminInfoConfig).Assembly);

        }

    }
}
