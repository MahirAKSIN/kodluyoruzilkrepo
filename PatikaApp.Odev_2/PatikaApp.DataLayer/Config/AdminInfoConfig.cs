using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.DataLayer.Config
{
    public class AdminInfoConfig : IEntityTypeConfiguration<AdminInfo>
    {

        //Admin Default olarak değerler atandı

        public void Configure(EntityTypeBuilder<AdminInfo> builder)
        {
            builder.HasData(

                new AdminInfo()
                {
                    AdminId = 1,
                    AdminName = "Mahir",
                    AdminEmail = "mahir@hotmail.com",
                    EducatorId = 1,
                    BootcampId = 1

                },
                new AdminInfo()
                {
                    AdminId = 2,
                    AdminName = "Serkan",
                    AdminEmail = "ince@hotmail.com",
                    EducatorId = 2,
                    BootcampId = 2
                });
        }
    }
}
