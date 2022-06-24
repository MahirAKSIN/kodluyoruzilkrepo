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

    //AdminInfos tablosuna manuel data aktarımı yappıldı bu classta.
    //mainde kod ilk ayağa kalktığında herhangi bir nullExcp hatasına uğramamk için düşünmüştür,
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
                    EducatorInfoId = 1,
                    BootcampInfoId = 1

                },
                new AdminInfo()
                {
                    AdminId = 2,
                    AdminName = "Serkan",
                    AdminEmail = "ince@hotmail.com",
                    EducatorInfoId = 2,
                    BootcampInfoId = 2
                });
        }
    }
}
