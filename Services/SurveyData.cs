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
       
        public async Task<List<Surveys>> GetSurveys(int userId)
        {
            return await _surchatContext.Survey.Where(i=>i.UserId==userId).Include(i=>i.Questions).ThenInclude(i=>i.Options).ToListAsync();

        }
        public async Task<Surveys> GetSurvey(int code)
        {
            Surveys surveys;
            surveys= await _surchatContext.Survey.Include(i => i.Questions).ThenInclude(i => i.Options).Where(i=>i.Code==code).FirstOrDefaultAsync();
            return surveys;
        }

        public async Task CreateQuestion(QuestionForCreateDTO model)
        {
            var options = new List<Options>();
            for (int i = 0; i < model.Options.Count; i++)
            {
                options.Add(new Options
                {
                    Option = model.Options[i].Option
                });
            }
            
            Surveys survey = _surchatContext.Survey.FirstOrDefault(x => x.Code == model.Code);
            survey.Questions = new List<Questions>();
            survey.Questions.Add(new Questions()
            {
                Question = model.Question,
                Options = options,
            });
            await _surchatContext.SaveChangesAsync();
        }

        public async Task AnswerSurvey(UserAnswersDTO userAnswersDTO)
        {
           for(int i=0;i<userAnswersDTO.QuestionsId.Count;i++)
            {
                await _surchatContext.UserAnswer.AddAsync(new UserAnswers {
                    UserId=userAnswersDTO.UserId,
                    QuestionsId=userAnswersDTO.QuestionsId[i],
                    Answers=userAnswersDTO.Answers[i]
                });
            }
            await _surchatContext.SaveChangesAsync();

        }


        public async Task<Surveys> GetResults(int code)
        {
            var surveys = await _surchatContext.Survey.Include(i => i.Questions).ThenInclude(i => i.UserAnswers).Where(i => i.Code == code).FirstOrDefaultAsync();

            return surveys;
        }

        public async Task DeleteSurvey(int code)
        {
            var survey = await _surchatContext.Survey.FirstOrDefaultAsync(s => s.Code == code);
            _surchatContext.Survey.Remove(survey);
            await _surchatContext.SaveChangesAsync();
        }

    }
}
