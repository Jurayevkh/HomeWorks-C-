using AutoMapper;
using Domain.Entities;
using Services.Dtos;

namespace Services.AutoMapper
{
    public class DemoProfile : Profile
    {
        public DemoProfile()
        {
            CreateMap<Company,CreateCompanyDto>();
        }
    }
}
