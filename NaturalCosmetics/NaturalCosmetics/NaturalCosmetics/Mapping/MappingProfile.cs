using AutoMapper;
using NaturalCosmetics.Dto;
using NaturalCosmetics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderDto, Order>();
            CreateMap<CosmeticsDto, Cosmetics>();
            CreateMap<Cosmetics, CosmeticsDto>();
        }
    }
}
