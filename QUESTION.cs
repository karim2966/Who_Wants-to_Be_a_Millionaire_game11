using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project
{
    class QUESTION:QUESTIONBASE 
    {
        public string CorrectAnswer;
        public string[] WrongAnswers;
        public QUESTION(int level, string text, string correct, string[] wrongs) : base(level, text)
        {
            CorrectAnswer = correct;
            WrongAnswers = wrongs;
        }
        public override bool IsCorrect(string answer)
        {
            return answer == CorrectAnswer;
        }



    }
}
