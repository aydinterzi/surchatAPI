using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using surchatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surchatAPI.Data
{
    public class SurchatContext :IdentityDbContext<User,Role,int>
    {
        public SurchatContext(DbContextOptions<SurchatContext> options) :base(options)
        {

        }

        public DbSet<Surveys> Survey { get; set; }
        public DbSet<Questions> Question { get; set; }
        public DbSet<Options> Option { get; set; }
        public DbSet<UserAnswers> UserAnswer { get; set; }
    }
}
