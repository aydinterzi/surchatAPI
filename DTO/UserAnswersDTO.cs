using System.Collections.Generic;

namespace surchatAPI.DTO
{
    public class UserAnswersDTO
    {
        public List<string> Answers { get; set; }
        public List<int> QuestionsId { get; set; }
        public int UserId { get; set; }
    }
}
