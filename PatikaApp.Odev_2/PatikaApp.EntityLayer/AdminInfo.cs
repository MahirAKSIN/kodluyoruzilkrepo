using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.EntityLayer
{
    public class AdminInfo
    {

        //Admin için bilgilerinin ve diğer entity classlarının admin olan ilişkileri burada tutuyor.

        [Key]

       public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminEmail { get; set; }

        //Diğer Tablolara ilişkiler ,tek tek ilişki
        public int BootcampId { get; set; }
        public int EducatorId { get; set; }

        public BootcampInfo BootcampInfo { get; set; }
        public EducatorInfo EducatorInfo { get; set; }
    }
}
