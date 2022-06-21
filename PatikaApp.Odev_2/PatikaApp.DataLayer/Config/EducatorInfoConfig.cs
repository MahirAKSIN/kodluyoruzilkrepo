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
    public class EducatorInfoConfig : IEntityTypeConfiguration<EducatorInfo>
    {
        public void Configure(EntityTypeBuilder<EducatorInfo> builder)
        {

            builder.HasData(
                
                new EducatorInfo()
                {
                    EducatorId=1,
                    EducatorName="Serkan",
                    EducatorSurName="Ince",
                    EducatorEmail="inceSerkan@gmail.com"
                }, new EducatorInfo()
                {
                    EducatorId = 2,
                    EducatorName = "Zeynep",
                    EducatorSurName = "Guzel",
                    EducatorEmail = "guzel@gmail.com"
                }

                );


        }
    }
}
