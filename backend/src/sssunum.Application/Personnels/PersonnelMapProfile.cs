using AutoMapper;
using sssunum.Entities;
using sssunum.Personnels.Dto;

namespace sssunum.Personnels
{
    public class PersonnelMapProfile : Profile
    {
        public PersonnelMapProfile()
        {
            CreateMap<Personnel, PersonnelDto>();
            CreateMap<CreatePersonnelDto, Personnel>();
            CreateMap<PersonnelDto, Personnel>();
        }
    }
}
