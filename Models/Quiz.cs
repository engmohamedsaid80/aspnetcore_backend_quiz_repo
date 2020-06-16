using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_Backend.Models
{
    public class Quiz
    {
        public int id { get; set; }
        public string title { get; set; }

        public string OwnerId { get; set; }
    }
}
