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
        //databse tablolarının oluştuğu class.Kalıtım olarak Dbcontext kullanıldı.
        public DbSet<AdminInfo> AdminInfos { get; set; }
        public DbSet<BootcampInfo> BootcampInfos { get; set; }
        public DbSet<EducatorInfo> EducatorInfos { get; set; }



        //database bağlantı yollu Hem Msql hemde sqlite bağlantısı mevcut.
        //Sqlite tercih edildi cunku programı baska pc calıştırırken extra database yolu vermeye gerek yok
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
<<<<<<< HEAD
            //optionsBuilder.UseSqlServer("server=DESKTOP-8M7D7GE\\SQLEXPRESS;database=PatikaAppDB;integrated security=true;");
            optionsBuilder.UseSqlite("Data Source = PatikaAppDB.db");
=======
            optionsBuilder.UseSqlServer("server=DESKTOP-8M7D7GE\\SQLEXPRESS;database=PatikaAppDB;integrated security=true;");
            //optionsBuilder.UseSqlite("Data Source = PatikaAppDB.db");
>>>>>>> 08ff82ae35036c308dab168a753680acd1d96e67
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdminInfoConfig).Assembly);

        }

    }
}
