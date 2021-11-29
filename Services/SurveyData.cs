using Microsoft.EntityFrameworkCore;
using surchatAPI.Data;
using surchatAPI.DTO;
using surchatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.Services
{
    public class SurveyData
    {
        private readonly SurchatContext _surchatContext;
        public SurveyData(SurchatContext surchatContext)
        {
            _surchatContext = surchatContext;
        }

        public async Task CreateSurvey(SurveyForCreateDTO model)
        {
            Surveys survey = new Surveys()
            {
                Time = model.Time,
                Title = model.Title,
                UserId = model.userId,
                Code = model.Code,
                IsOpen = false,
            };
            await _surchatContext.Survey.AddAsync(survey);
            await _surchatContext.SaveChangesAsync();
        }

        public async Task<List<Surveys>> GetSurveys()
        {
            return await _surchatContext.Survey.ToListAsync();

        }

        public async Task CreateQuestion(QuestionForCreateDTO model)
        {
            Surveys survey = _surchatContext.Survey.FirstOrDefault(x => x.Code == model.Code);
            survey.Questions = new List<Questions>();
            survey.Questions.Add(new Questions()
            {
                Question = model.Question,
                Options = new List<Options>()
                {
                    new Options()
                    {
                        Option = "deneme1"
                    },
                    new Options()
                    {
                        Option="deneme2"
                    },
                    new Options()
                    {
                        Option="deneme3"
                    },
                    new Options()
                    {
                        Option="deneme4"
                    },
                }
            });
            await _surchatContext.SaveChangesAsync();
        }

    }
}
