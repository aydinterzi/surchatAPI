using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.Models
{
    public class Surveys
    {
        //public Surveys()
        //{
        //    Questions = new List<Questions>();
        //}
        public int Id { get; set; }
        public int Code { get; set; }
        public int Time { get; set; }
        public bool IsOpen { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public List<Questions> Questions { get; set; }
    }
}
