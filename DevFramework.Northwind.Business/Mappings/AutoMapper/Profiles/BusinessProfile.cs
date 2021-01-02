using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DevFramework.Northwind.Entities.Concrete;

/*
 Created by OlcerTugba 2020
 */
namespace DevFramework.Northwind.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<Product, Product>();
        }
    }
}