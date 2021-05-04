using AutoMapper;
using Planet.LeandroRate.ConsoleApp.Domain;
using Planet.LeandroRate.ConsoleApp.Domain.Entities;
using Planet.LeandroRate.ConsoleApp.ViewModels;
using Planet.LeandroRate.ConsoleApp.ViewModels.AppObjects;

namespace Planet.LeandroRate.ConsoleApp.Mapping.Profiles
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
