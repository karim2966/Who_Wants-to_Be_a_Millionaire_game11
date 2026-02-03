using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project
{
    internal class GAMEMANAGE
    {
        const string File = "question.txt";
        public string[,] questionsAndAnswers = new string[15, 5];
        Random random = new Random();
        string[] swap(string[] Answer, int n1, int n2)
        {
            string S1 = Answer[n1];
            Answer[n1] = Answer[n2];
            Answer[n2] = S1;
            return Answer;
        }
        public string[] LoadQuestions(string file)
        {
            TextReader ReadFile = new StreamReader(File);
            string Line="";
            string[] LinesOfQuestions = new string[110];
           
            for(int  i=0; i < LinesOfQuestions.Length ;i++) 
            {
               
                    
                Line = ReadFile.ReadLine();
                LinesOfQuestions[i] = Line;
               
               


            } 
            return LinesOfQuestions;
        }
        public string GetRandomQuestion(int Level)
        {
            string[] LinesOfQuestions = LoadQuestions(File);
            string LineQuestion;
            for (int i=0;i < LinesOfQuestions.Length;i++)
            {
                if (LinesOfQuestions[i]=="#Level"+Level.ToString())
                {
                    int RandNumber = random.Next(i + 1, i + 6);
                    return LineQuestion = LinesOfQuestions[RandNumber];
                }
            }
            return "0";
        }
        public string[] GetShuffledAnswers(QUESTION Q)
        {
            string[] Answers = new string[4];
            Answers[0] = Q.CorrectAnswer;
            Answers[1] = Q.WrongAnswers[random.Next(0, Q.WrongAnswers.Length)];
            while((Answers[2]= Q.WrongAnswers[random.Next(0, Q.WrongAnswers.Length )])== Answers[1])
            {
                Answers[2] = Q.WrongAnswers[random.Next(0, Q.WrongAnswers.Length )];
            }
            while ((Answers[3] = Q.WrongAnswers[random.Next(0, Q.WrongAnswers.Length )]) == Answers[1] || (Answers[3] = Q.WrongAnswers[random.Next(0, Q.WrongAnswers.Length )]) == Answers[2])
            {
                Answers[3] = Q.WrongAnswers[random.Next(0, Q.WrongAnswers.Length )];
            }
            for(int i=0;i<Answers.Length;i++)
            {
                swap(Answers, random.Next(0, 3), random.Next(0, 3));
            }
            return Answers;
            
        }
    }
}
