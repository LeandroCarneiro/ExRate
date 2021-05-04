using Microsoft.AspNetCore.Mvc;
using Planet.LeandroRate.ConsoleApp.Application.AppServices;
using Planet.LeandroRate.ConsoleApp.ViewModels.AppObjects;

namespace Planet.LeandroRate.ConsoleApp.Api.Controllers
{
    public class SurveyController : BaseController
    {
        private readonly SurveyAppService _appService;

        public SurveyController(SurveyAppService appService)
        {
            this._appService = appService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return ReturnResult(_appService.FindById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] SurveyVersion_vw value)
        {
            return ReturnResult(_appService.Add(value));
        }

        [HttpPut]
        public IActionResult Put([FromBody] SurveyVersion_vw value)
        {
            _appService.Update(value);
            return Ok();
        }
    }
}
