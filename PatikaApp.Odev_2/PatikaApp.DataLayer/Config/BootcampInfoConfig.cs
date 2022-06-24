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
    public class BootcampInfoConfig : IEntityTypeConfiguration<BootcampInfo>
    {


        //BootcampInfo tablosuna manuel data aktarımı yappıldı bu classta.
        //mainde kod ilk ayağa kalktığında herhangi bir nullExcp hatasına uğramamk için düşünmüştür,
        public void Configure(EntityTypeBuilder<BootcampInfo> builder)
        {
            builder.HasData(

                new BootcampInfo()
                {
                    BootcampId = 1,
                    BootcampName = "Arvato Bootcamp",
                    BootcampContent = ".Net Eğitimi"

                } ,   new BootcampInfo()
                {
                    BootcampId = 2,
                    BootcampName = "Kodluyoruz Bootcamp",
                    BootcampContent = "React Eğitimi"

                }

                );


        }
    }
}
