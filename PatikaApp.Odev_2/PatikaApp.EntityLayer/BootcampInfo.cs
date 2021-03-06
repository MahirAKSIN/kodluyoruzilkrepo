using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.EntityLayer
{
    public class BootcampInfo
    {
        //BootcampInfo için bilgilerinin ve diğer entity classlarının admin olan ilişkileri burada tutuyor.
        //Encapsulation yapılmıştır

        [Key]
        public int BootcampId { get; set; }
        public string BootcampName { get; set; }
        public string BootcampContent { get; set; }
        public List<AdminInfo> AdminInfos { get; set; }
    }
}
