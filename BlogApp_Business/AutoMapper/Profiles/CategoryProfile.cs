using AutoMapper;
using BlogApp_Entities.Concrete;
using BlogApp_Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Business.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() 
        {
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
            CreateMap<Category,CategoryAddDto>().ReverseMap();
        }
    }
}
