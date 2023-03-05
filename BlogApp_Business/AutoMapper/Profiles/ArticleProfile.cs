﻿using AutoMapper;
using BlogApp_Entities.Concrete;
using BlogApp_Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Business.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article,ArticleDto>().ReverseMap();
            CreateMap<Article,ArticleListDto>().ReverseMap();
            CreateMap<Article,ArticleUpdateDto>().ReverseMap();
            CreateMap<Article,ArticleAddDto>().ReverseMap();
        }
    }
}
