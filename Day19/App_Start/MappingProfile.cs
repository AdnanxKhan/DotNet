﻿     using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MyApp.Dtos;
using MyApp.Models;
namespace MyApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>();
        }

    }
}