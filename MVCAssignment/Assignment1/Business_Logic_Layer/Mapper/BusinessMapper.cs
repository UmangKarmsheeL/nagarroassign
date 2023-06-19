using AutoMapper;
using BookReadingEvent1.DTOs;
using BookReadingEvent1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Mapper
{
    public class BusinessMapper:Profile
    {
        public BusinessMapper(): base("BusinessMapper")
        {
            CreateMap<EventDTO, EventModel>().ReverseMap();
            CreateMap<SignInDTO, SignInModel>().ReverseMap();
            CreateMap<SignUpDTO, SignUpModel>().ReverseMap();
        }
    }
}
