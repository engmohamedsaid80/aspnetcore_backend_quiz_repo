using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_Backend.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }

        public string CorrectAnswer { get; set; }

        public string WrongAnswer1 { get; set; }

        public string WrongAnswer2 { get; set; }

        public string WrongAnswer3 { get; set; }
    }
}
