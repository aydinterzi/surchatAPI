using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.Models
{
    public class UserAnswers
    {

        public int Id { get; set; }
        public string Answers { get; set; }
        public int QuestionsId { get; set; }
        public int UserId { get; set; }
        

    }
}
