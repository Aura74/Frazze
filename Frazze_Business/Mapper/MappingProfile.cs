using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frazze_Models;
using Frazze_DataAccess;


namespace Frazze_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Phrases, PhrasesDTO>().ReverseMap();
            CreateMap<Applications, ApplicationsDTO>().ReverseMap();
            CreateMap<Cultures, CulturesDTO>().ReverseMap();
            CreateMap<Pages, PagesDTO>().ReverseMap();
        }
    }
}
