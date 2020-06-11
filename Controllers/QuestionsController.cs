using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public ActionResult<IEnumerable<Question>> Get()
        {
            return this.context.Questions.ToList();
        }

        // POST api/questions
        [HttpPost]
        public async Task<IActionResult> Post(Question question)
        {
            this.context.Questions.Add(question);
            await this.context.SaveChangesAsync();

            return Ok(question);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Question question)
        {
            this.context.Entry(question).State = EntityState.Modified;

            await this.context.SaveChangesAsync();


            return Ok(question);
        }
    }
}
