using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EntityLayer
{
    public class LoginEntity
    {

        /// <summary>
        /// Jwt kimlik doğrulama için yaratılan class.
        /// </summary>

        public int Id { get; set; }
        public string  UserName { get; set; }
        public string  Passwored { get; set; }
    }
}
