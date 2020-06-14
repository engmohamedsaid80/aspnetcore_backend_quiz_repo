using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_Backend.Models
{
    public class Question
    {
        public int id { get; set; }
        public string questionText { get; set; }

        public string correctAnswer { get; set; }

        public string wrongAnswer1 { get; set; }

        public string wrongAnswer2 { get; set; }

        public string wrongAnswer3 { get; set; }

        public int quizId { get; set; }
    }
}
