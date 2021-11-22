using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using surchatAPI.DTO;
using surchatAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly SurveyData _surveyData;
        public SurveyController(SurveyData surveyData)
        {
            _surveyData = surveyData;
        }


        [HttpPost("createsurvey")]
        public async Task<IActionResult> CreateSurvey(SurveyForCreateDTO model)
        {
          await  _surveyData.CreateSurvey(model);
            return Ok();
        }
    }
}
