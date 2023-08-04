using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Videoteka.Models;
using Videoteka.Models.Dtos;

namespace Videoteka.App_Start
{
    public class MappingProfile : Profile
    {   
        public MappingProfile() 
        {
            Mapper.CreateMap<Kupac, KupacDto>();
            Mapper.CreateMap<KupacDto, Kupac>();

            Mapper.CreateMap<Film, FilmDto>();
            Mapper.CreateMap<FilmDto, Film>();

            Mapper.CreateMap<Pozajmica, PozajmicaDto>();
            Mapper.CreateMap<PozajmicaDto, Pozajmica>();
        }
    }
}