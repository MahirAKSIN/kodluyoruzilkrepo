﻿using Microsoft.EntityFrameworkCore;
using PatikaApp.DataLayer.Abstract;
using PatikaApp.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaApp.DataLayer.Concrete.Ef
{
    public class EfCoreAdminInfoRepository : EfCoreGenericRepository<AdminInfo>, IAdminInfoRepository
    {
        public async Task<List<AdminInfo>> GetAllWithDetails()
        {
            using (var c = new PatikaContext())
            {
                var d= await c.AdminInfos.ToListAsync();
                return d;
            }
        }
    }
}

