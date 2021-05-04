using AutoMapper;
using LeandroExRate.Domain.Entities;
using LeandroExRate.ViewModels.AppObjects;

namespace LeandroExRate.Mapping.Profiles
{
    public class TeslaDomainProfile : Profile
    {
        public TeslaDomainProfile()
        {
            CreateMap<Rate, Rate_vw>().ReverseMap();            
        }
    }
}
