using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project
{
    abstract class QUESTIONBASE
    {
        public int Level;
        public string Text; 
        public QUESTIONBASE(int level, string text)
        {
            Level = level;
            Text = text;
        }
       

        public abstract bool IsCorrect(string answer);
    }
}
