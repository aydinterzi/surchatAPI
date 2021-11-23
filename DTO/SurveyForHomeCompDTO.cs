using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.DTO
{
    public class SurveyForHomeCompDTO
    {
        public int Code { get; set; }
        public int Time { get; set; }
        public bool IsOpen { get; set; }
        public string Title { get; set; }
    }
}
