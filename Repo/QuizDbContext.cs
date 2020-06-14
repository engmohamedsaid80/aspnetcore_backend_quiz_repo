using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quiz_Backend.Models;

namespace quiz_Backend.Repo
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options) {}

        public DbSet<Models.Question> Questions { get; set; }

        public DbSet<quiz_Backend.Models.Quiz> Quiz { get; set; }
    }
}
