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
            Surveys survey = new Surveys() {
                Time = model.Time,
                Title = model.Title,
                UserId = model.userId,
                Code = new Random().Next(100000,999999),
                IsOpen=false,
            };
            await _surchatContext.Survey.AddAsync(survey);
            await _surchatContext.SaveChangesAsync();
        }

        public async Task<List<Surveys>> GetSurveys()
        {
           return await _surchatContext.Survey.ToListAsync();
           
        }
    }
}
