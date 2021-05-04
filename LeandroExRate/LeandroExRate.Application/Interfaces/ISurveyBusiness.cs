using LeandroExRate.Domain.Entities;

namespace LeandroExRate.Application.Interfaces
{
    public interface ISurveyBusiness : IBusiness<SurveyVersion>
    {
        void DisableVersion(long surveyId, int version);
    }
}
