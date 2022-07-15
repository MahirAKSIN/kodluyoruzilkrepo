﻿using FinalProject.BusinessLayer.Abstarct;
using FinalProject.DataLayer.Abstract;
using FinalProject.DataLayer.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLayer.Concrete
{
    /// <summary>
    /// Bu classta ITrendingsService'i implement yaparak imzasız olana 
    /// methodları içine linq sorguları ile imzalanır. 
    /// 
    /// </summary>
    public class TrendingsManager : ITrendingsService
    {
        ITrendingsRepository _trendingsRepository;

        public TrendingsManager(ITrendingsRepository trendingsRepository)
        {
            _trendingsRepository = trendingsRepository;
        }

        public Task<Mytable> ListMostViewedMovies(int voteCount)
        {
            throw new NotImplementedException();
        }

        public Task<Mytable> ListTopRatedMovies(int voteAverage)
        {
            throw new NotImplementedException();
        }
    }
}
