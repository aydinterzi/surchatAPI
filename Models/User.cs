using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.Models
{
    public class User:IdentityUser<int>
    {
        public int ConnectionId { get; set; }
        public List<Surveys> Surveys { get; set; }
    }
}
