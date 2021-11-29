using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.DTO
{
    public class SurveyForCreateDTO
    {
        public int Time { get; set; }
        public string Title { get; set; }
        public int userId { get; set; }
        public int Code { get; set; }
    }
}
