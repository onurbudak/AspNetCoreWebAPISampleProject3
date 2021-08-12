using AutoMapper;
using Entities.Concrete;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapping
{
    public class MappingProfile : Profile
    {
        
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            //CreateMap<Customer, CustomerDto>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            //    ;
        }
    }
}
