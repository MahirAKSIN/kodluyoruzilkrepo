﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.EntityLayer
{
    public class EducatorInfo
    {
        [Key]
        public int EducatorId { get; set; }
        public string EducatorName { get; set; }
        public string EducatorSurName { get; set; }
        public string EducatorEmail { get; set; }

        public List<AdminInfo> AdminInfos { get; set; }

    }
}
