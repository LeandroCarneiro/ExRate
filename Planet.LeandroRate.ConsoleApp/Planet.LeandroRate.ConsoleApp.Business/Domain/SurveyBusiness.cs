using Microsoft.EntityFrameworkCore;
using Planet.LeandroRate.ConsoleApp.Application.Interfaces;
using Planet.LeandroRate.ConsoleApp.Domain.Entities;
using System.Linq;

namespace Planet.LeandroRate.ConsoleApp.Business.Domain
{
    public class SurveyBusiness : AppBusiness<SurveyVersion>, ISurveyBusiness
    {
        public override IQueryable<SurveyVersion> SetIncluding => (Set.Include(x => x.Survey).ThenInclude(s => s.Questions).ThenInclude(a => a.Answers).Include(y => y.CreatedBy)).AsNoTracking();
        public override IQueryable<SurveyVersion> SetIncludingTracking => (Set.Include(x => x.Survey).ThenInclude(s => s.Questions).ThenInclude(a => a.Answers).Include(y => y.CreatedBy)).AsTracking();

        public void DisableVersion(long surveyId, int version)
        {
            using (var trans = _uow.BeginTransaction())
            {
                var versionSurvey = Find(x => x.VersionNumber == version && x.SurveyId == surveyId);
                versionSurvey.Active = false;
                trans.Commit();

                _uow.Commit();
            }
        }
    }
}
