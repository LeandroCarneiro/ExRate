using AutoMapper;
using LeandroExRate.Domain;
using LeandroExRate.Domain.Entities;
using LeandroExRate.ViewModels;
using LeandroExRate.ViewModels.AppObjects;

namespace LeandroExRate.Mapping.Profiles
{
    public class TeslaDomainProfile : Profile
    {
        public TeslaDomainProfile()
        {
            CreateMap<EntityBase<long>, EntityBase_vw<long>>().ReverseMap();
            CreateMap<UserApp, UserApp_vw>().ReverseMap();
            CreateMap<SurveyVersion, SurveyVersion_vw>().ReverseMap();
            CreateMap<Survey, Survey_vw>().ReverseMap();
            CreateMap<Answer, Answer_vw>().ReverseMap();
            CreateMap<Question, Question_vw>().ReverseMap();
        }
    }
}
