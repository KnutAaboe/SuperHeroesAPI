﻿using HeroesAndVilliansAPI.Model;
using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesAPI.Data
{
    public interface IApiFetcher
    {
        //IEnumerable<SuperHero> GetSuperHeroes();
        AllinfoHV.Root GetHeroVillianInfoByID(string id);
        List<string> GetAllHeroesVillians(int startID, string alignment);
        Search.Results SearchForHeroesVillians(string letters, string where);
        List<Comparisons.Data> HeroesVilliansStats(string id, string id2);



    }
}
