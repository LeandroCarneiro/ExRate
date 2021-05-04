using LeandroExRate.Application.Interfaces;
using LeandroExRate.Domain.Entities;
using LeandroExRate.ViewModels.AppObjects;

namespace LeandroExRate.Application.AppServices
{
    public class SurveyAppService : BaseAppService<SurveyVersion_vw, SurveyVersion>
    {
        readonly ISurveyBusiness _business;

        public SurveyAppService(ISurveyBusiness business) : base(business)
        {
            _business = business;
        }

        public override void Update(SurveyVersion_vw entity)
        {
            var newSurvey = Resolve(entity);
            _business.DisableVersion(entity.Survey.Id, entity.VersionNumber);

            newSurvey.Survey.Id = 0;
            newSurvey.VersionNumber = entity.VersionNumber + 1;
            newSurvey.Active = true;

            _baseBusiness.Add(newSurvey);
        }
    }
}
