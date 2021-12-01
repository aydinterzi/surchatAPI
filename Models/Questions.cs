using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.Models
{
    public class Questions
    {
        //public Questions()
        //{
        //    Options = new List<Options>();
        //}
        public int Id { get; set; }
        public string Question { get; set; }


        public int SurveyId { get; set; }
        public Surveys Survey  { get; set; }

        public List<Options> Options { get; set; }
    }
}
