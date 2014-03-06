﻿using System;
using System.Linq;

namespace QuickMGenerate.NHibernate.Testing.Sample.Handlers.GetSuperHero
{
    public class GetSuperHeroHandler
    {
        private readonly GetSuperHeroQuery query;

        public GetSuperHeroHandler(GetSuperHeroQuery query)
        {
            this.query = query;
        }

        public SuperHeroDto Handle(Guid superHeroId)
        {
            var hero = query.One(superHeroId);
            return
                new SuperHeroDto
                    {
                        Name = hero.Name,
                        SuperPowers =
                            hero.SuperPowers
                                .Select(sp => sp.Name).ToList(),
                        SuperPowerEffects =
                            hero.SuperPowers
                                .SelectMany(sp => sp.SuperPowerEffects)
                                .Select(spe => spe.Name).ToList()
                    };
        }
    }
}
