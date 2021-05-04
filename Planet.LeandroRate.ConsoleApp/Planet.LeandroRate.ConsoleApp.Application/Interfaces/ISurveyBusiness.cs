using Planet.LeandroRate.ConsoleApp.Domain.Entities;

namespace Planet.LeandroRate.ConsoleApp.Application.Interfaces
{
    public interface ISurveyBusiness : IBusiness<SurveyVersion>
    {
        void DisableVersion(long surveyId, int version);
    }
}
