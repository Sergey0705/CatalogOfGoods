using AutoMapper;
using CatalogOfGoods.Dtos;
using CatalogOfGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Goods.Profiles
{
    public class GoodsProfile : Profile
    {
        public GoodsProfile() 
        {
            CreateMap<Good, GoodReadDto>();
            CreateMap<GoodCreateDto, Good>();
            CreateMap<GoodUpdateDto, Good>();      
        }     
    }
}
