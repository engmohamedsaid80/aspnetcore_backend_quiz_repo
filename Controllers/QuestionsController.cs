using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using quiz_Backend.Models;
using quiz_Backend.Repo;

namespace quiz_Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly QuizDbContext context;

        public QuestionsController(QuizDbContext context)
        {
            this.context = context;
        }

        [AllowAnonymous]
        [HttpGet("{quizId}")]
        public ActionResult<IEnumerable<Question>> Get([FromRoute] int quizId)
        {
            return this.context.Questions.Where(q => q.quizId == quizId).ToList();
        }

        // POST api/questions
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(Question question)
        {
            var quiz = this.context.Quiz.Where(q => q.id == question.quizId).SingleOrDefaultAsync();

            if (quiz == null) return NotFound();

            this.context.Questions.Add(question);
            await this.context.SaveChangesAsync();

            return Ok(question);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Put(Question question)
        {
            this.context.Entry(question).State = EntityState.Modified;

            await this.context.SaveChangesAsync();


            return Ok(question);
        }
    }
}
