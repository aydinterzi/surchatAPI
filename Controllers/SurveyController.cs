using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using surchatAPI.DTO;
using surchatAPI.Models;
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
            await _surveyData.CreateSurvey(model);
            return Ok();
        }

        [HttpGet("{userId}")]
        public async Task<List<Surveys>> GetSurveys(int userId)
        {
            return await _surveyData.GetSurveys(userId);
        }

        [HttpPost("createquestion")]
        public async Task<IActionResult> CreateQuestion(QuestionForCreateDTO model)
        {
            await _surveyData.CreateQuestion(model);
            return Ok();

        }

        [HttpGet("getsurvey/{code}")]
        public async Task<Surveys> Getsurvey(int code)
        {
            return await _surveyData.GetSurvey(code);

        }

        [HttpPost("answersurvey")]
        public async Task<IActionResult> AnswerSurvey(UserAnswersDTO userAnswers)
        {
            await _surveyData.AnswerSurvey(userAnswers);
            return Ok();
        }

        [HttpGet("result/{code}")]
        public async Task<Surveys> GetResults(int code)
        {
            return await _surveyData.GetResults(code);

        }
        [HttpDelete("{code}")]
        public async Task DeleteSurvey(int code)
        {
            await _surveyData.DeleteSurvey(code);
        }
        
    }
}
