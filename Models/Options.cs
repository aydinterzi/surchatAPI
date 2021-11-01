using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.Models
{
    public class Options
    {
        public int Id { get; set; }
        public string Option { get; set; }


        public int QuestionId { get; set; }
        public Questions Question { get; set; }
        
    }
}
