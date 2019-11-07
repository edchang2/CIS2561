using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterQuiz
{
    class Question
    {
        public Question()
        {
        }
        public Question(string cat, string ques, string ans)
        {
            Category = cat;
            QuestionText = ques;
            Answer = ans; 
        }
        public string Category { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
    }
}
